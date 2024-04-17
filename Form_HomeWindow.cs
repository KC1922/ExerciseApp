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
        public Form_HomeWindow()
        {
            InitializeComponent();
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
                textBox_AvgPace.Enabled = false;
                textBox_AvgSpeed.Enabled = false;
                textBox_Distance.Enabled = false;
            }
            else
            {
                textBox_AvgPace.Enabled = true;
                textBox_AvgSpeed.Enabled = true;
                textBox_Distance.Enabled = true;
            }
        }
    }
}
