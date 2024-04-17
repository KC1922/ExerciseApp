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
    }
}
