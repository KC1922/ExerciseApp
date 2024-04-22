using Npgsql;
using System.Configuration;
using System.Data;


namespace ExerciseApp.AppMain_ChildForms
{
    public partial class Form_AddWorkout : Form
    {
        private string dbConnection = ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString;
        private int userId;
        public Form_AddWorkout(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }


        private void Form_AddWorkout_Load(object sender, EventArgs e)
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
        /// Disables or Enables textboxes on the form.
        /// </summary>
        /// <param name="enable"></param>
        private void ToggleTextBoxes(Boolean enable)
        {
            dateTimePicker_avgPace.Enabled = enable;
            textBox_AvgSpeed.Enabled = enable;
            textBox_Distance.Enabled = enable;
        }
        /// <summary>
        /// Changes textbox color
        /// </summary>
        /// <param name="color"></param>
        private void ChangeTextBoxColor(Color color)
        {
            dateTimePicker_avgPace.BackColor = color;
            textBox_AvgSpeed.BackColor = color;
            textBox_Distance.BackColor = color;
        }


        private void button_Add_Click(object sender, EventArgs e)
        {
            int exercise = comboBox_ExerciseList.SelectedIndex + 1; //Add one since database is offset by 1 compared to combobox index
            string calories = textBox_Calories.Text;
            DateTime avgPace = dateTimePicker_avgPace.Value;
            string distance = textBox_Distance.Text;
            string avgSpeed = textBox_AvgSpeed.Text;
            string maxHr = textBox_MaxHR.Text;
            string minHr = textBox_MinHR.Text;
            DateTime date = dateTimePicker_Date.Value;
            DateTime startTime = dateTimePicker_StartTime.Value;
            DateTime duration = dateTimePicker_Duration.Value;

            using (NpgsqlConnection connection = new NpgsqlConnection(dbConnection))
            {
                connection.Open();


                // Begin a transaction as code inserts values into two tables
                using (NpgsqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string insertWorkoutQuery = @"INSERT INTO workouts (user_id, exercise_id, calories_burned, max_hr, min_hr, distance, avg_speed, avg_pace)
                                   VALUES (@user_id, @exercise, @calories_burned, @max_hr, @min_hr, @distance, @avg_speed, @avg_pace)
                                   RETURNING workout_id";

                        int workout_id;

                        using (NpgsqlCommand command = new NpgsqlCommand(insertWorkoutQuery, connection))
                        {
                            command.Parameters.AddWithValue("@user_id", userId);
                            command.Parameters.AddWithValue("@exercise", exercise);
                            command.Parameters.AddWithValue("@calories_burned", string.IsNullOrEmpty(calories) ? 0 : int.Parse(calories));
                            command.Parameters.AddWithValue("@max_hr", string.IsNullOrEmpty(maxHr) ? 0 : int.Parse(maxHr));
                            command.Parameters.AddWithValue("@min_hr", string.IsNullOrEmpty(minHr) ? 0 : int.Parse(minHr));
                            command.Parameters.AddWithValue("@distance", string.IsNullOrEmpty(distance) ? 0 : int.Parse(distance));
                            command.Parameters.AddWithValue("@avg_pace", avgPace);
                            command.Parameters.AddWithValue("@avg_speed", string.IsNullOrEmpty(avgSpeed) ? 0 : int.Parse(avgSpeed));

                            // Execute the command and retrieve the userid of the newly inserted user
                            workout_id = (int)command.ExecuteScalar();

                            if (workout_id == 0)
                            {
                                throw new Exception("Failed to add workout details. Make sure entered information is correct.");
                            }

                            // Insert into UserPhysicalDetails table
                            string insertTimingQuery = @"INSERT INTO timing (workout_id, date, start_time, duration)
                                                       VALUES (@workout_id, @date, @start_time, @duration)";
                            using (NpgsqlCommand commandInsertTimingQuery = new NpgsqlCommand(insertTimingQuery, connection))
                            {
                                commandInsertTimingQuery.Parameters.AddWithValue("@workout_id", workout_id);
                                commandInsertTimingQuery.Parameters.AddWithValue("@date", date);
                                commandInsertTimingQuery.Parameters.AddWithValue("@start_time", startTime);
                                try
                                {
                                    commandInsertTimingQuery.Parameters.AddWithValue("@duration", duration);
                                }
                                catch (FormatException) { throw new Exception("Enter a valid duration."); }

                                int rowsAffected = commandInsertTimingQuery.ExecuteNonQuery();
                                if (rowsAffected == 0)
                                {
                                    throw new Exception("Failed to insert timings.");
                                }

                            }
                        }
                        transaction.Commit();
                        MessageBox.Show("Workout added.");
                    }
                    catch (PostgresException ex)
                    {
                        transaction.Rollback();
                        //MessageBox.Show("Error adding workout: " + ex.Message);
                        MessageBox.Show($"PostgreSQL Error: {ex.SqlState} - {ex.Message}");
                    }
                }
            }
        }


    }
}
