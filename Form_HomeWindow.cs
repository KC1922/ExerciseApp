using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseApp
{
    public partial class Form_HomeWindow : Form
    {
        string dbConnection = ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString;
        public Form_HomeWindow(string userName)
        {
            InitializeComponent();
            label_Welcome.Text = "Welcome back " + userName;
        }

        private void button_AddWorkout_Click(object sender, EventArgs e)
        {

        }

        private void Form_HomeWindow_Load(object sender, EventArgs e)
        {
            // Load exercises from database to populate comboxbox_Exercises
            DataTable exercises = new DataTable();
            comboBox_ExerciseList.Items.Clear();

            using (NpgsqlConnection connection = new NpgsqlConnection(dbConnection))
            {
                connection.Open();
                string selectExercisesQuery = "SELECT DISTINCT exercise_name FROM exercises";
                using (NpgsqlCommand command = new NpgsqlCommand(selectExercisesQuery, connection))
                {

                    exercises.Load(command.ExecuteReader());
                    comboBox_ExerciseList.DataSource = exercises;
                    comboBox_ExerciseList.DisplayMember = "exercise_name";
                }
            }

        }

        private void Form_HomeWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox_ExerciseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string exerciseType = "";
            string exerciseName = comboBox_ExerciseList.Text;
            string selectExerciseType = "SELECT DISTINCT exercise_type FROM exercises WHERE exercise_name = @exercise_name";

            using (NpgsqlConnection connection = new NpgsqlConnection(dbConnection))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(selectExerciseType, connection))
                {
                    command.Parameters.AddWithValue("@exercise_name", exerciseName);
                    exerciseType = command.ExecuteScalar()?.ToString();
                }
            }
            if (string.Compare(exerciseType, "Cardio") != 0)
            {
                ToggleTextBoxes(false);
            }
            else
            {
                ToggleTextBoxes(true);
            }
        }
        /// <summary>
        /// Used to disable or enable certain text boxes.
        /// </summary>
        /// <param name="enable"></param>
        private void ToggleTextBoxes(Boolean enable)
        {
            textBox_AvgPace.Enabled = enable;
            textBox_AvgSpeed.Enabled = enable;
            textBox_Distance.Enabled = enable;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            int exercise = comboBox_ExerciseList.SelectedIndex;
            string calories = textBox_Calories.Text;
            string avgPace = textBox_AvgPace.Text;
            string distance = textBox_Distance.Text;
            string avgSpeed = textBox_AvgSpeed.Text;
            string maxHr = textBox_MaxHR.Text;
            string minHr = textBox_MinHR.Text;
            string date = dateTimePicker_Date.Text;
            string startTime = dateTimePicker_StartTime.Text;
            string duration = dateTimePicker_Duration.Text;

            using (NpgsqlConnection connection = new NpgsqlConnection(dbConnection))
            {
                connection.Open();

  
                // Begin a transaction as code inserts values into two tables
                using (NpgsqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string insertWorkoutQuery = @"INSERT INTO workouts (user_id, exercise_id, calories_burned, max_hr, min_hr, distance, avg_pace, avg_speed)
                                   VALUES (@userId, @exercise, @calories_burned, @max_hr, @min_hr, @distance, @avg_pace, @avg_speed)
                                   RETURNING workout_id";

                        int workout_id;

                        using (NpgsqlCommand command = new NpgsqlCommand(insertWorkoutQuery, connection))
                        {
                            command.Parameters.AddWithValue("@exercise", exercise);
                            command.Parameters.AddWithValue("@calories_burned", string.IsNullOrEmpty(calories) ? 0 : int.Parse(calories));
                            command.Parameters.AddWithValue("@max_hr", string.IsNullOrEmpty(maxHr) ? 0: int.Parse(maxHr));
                            command.Parameters.AddWithValue("@min_hr", string.IsNullOrEmpty(minHr) ? 0 : int.Parse(maxHr));
                            command.Parameters.AddWithValue("@distance", string.IsNullOrEmpty(distance) ? 0 : int.Parse(maxHr));
                            command.Parameters.AddWithValue("@avg_pace", string.IsNullOrEmpty(avgPace) ? 0 : int.Parse(maxHr));
                            command.Parameters.AddWithValue("@avg_speed", string.IsNullOrEmpty(avgSpeed) ? 0 : int.Parse(maxHr));

                            // Execute the command and retrieve the userid of the newly inserted user
                            workout_id = (int)command.ExecuteScalar();

                            if (workout_id == 0)
                            {
                                throw new Exception("Failed to add workout details. Make sure entered information is correct.");
                            }

                            // Insert into UserPhysicalDetails table
                            string insertTimingQuery = @"INSERT INTO timing (workout_id, date, start_time, duration)
                                                       VALUES (@workout_id, @date, @start_time, @duration)";
                            using (NpgsqlCommand commandInsertTimingQuery = new NpgsqlCommand(insertWorkoutQuery, connection))
                            {
                                commandInsertTimingQuery.Parameters.AddWithValue("@workout_id", workout_id);
                                commandInsertTimingQuery.Parameters.AddWithValue("@date", date);
                                commandInsertTimingQuery.Parameters.AddWithValue("@start_time", startTime);
                                try
                                {
                                    commandInsertTimingQuery.Parameters.AddWithValue("@duration", duration);
                                }
                                catch (FormatException) { throw new Exception("Enter a valid duration."); }
                            }
                        }
                        transaction.Commit();
                        MessageBox.Show("Workout added.");
                    }
                    catch (Exception ex) 
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error adding workout: " + ex.Message);
                    }
                }
            }
        }
    }
}
