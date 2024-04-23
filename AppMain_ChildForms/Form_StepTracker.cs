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

namespace ExerciseApp.AppMain_ChildForms
{

    public partial class Form_StepTracker : Form
    {
        private int userId;
        private int totalSteps;
        private int totalDailySteps;
        private string dbConnection = ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString;
        DateTime currentDate = DateTime.Today;
        public Form_StepTracker(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void Form_StepTracker_Load(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(dbConnection))
            {
                connection.Open();

                string totalStepsQuery = "SELECT SUM(steps) FROM steps WHERE user_id = @user_id";
                using (NpgsqlCommand command = new NpgsqlCommand(totalStepsQuery, connection))
                {
                    command.Parameters.AddWithValue("@user_id", userId);
                    try { this.totalSteps = Convert.ToInt32(command.ExecuteScalar()); }
                    catch (Exception ex) { MessageBox.Show("Error loading from database"); }
                    label_TotalStepsCount.Text = totalSteps.ToString();
                }

                string previousStepsQuery = "SELECT steps FROM steps WHERE user_id = @user_id ORDER BY date DESC LIMIT 1";
                using (NpgsqlCommand command = new NpgsqlCommand(previousStepsQuery, connection))
                {
                    command.Parameters.AddWithValue("@user_id", userId);
                    int prevSteps = 0;
                    try { prevSteps = Convert.ToInt32(command.ExecuteScalar()); }
                    catch (Exception ex) { MessageBox.Show("Error loading from database"); }
                    label_PreviousStepsCount.Text = prevSteps.ToString();
                }

                string recordStepsQuery = "SELECT MAX(steps) FROM steps WHERE user_id = @user_id GROUP BY date";
                using (NpgsqlCommand command = new NpgsqlCommand(recordStepsQuery, connection))
                {
                    command.Parameters.AddWithValue("@user_id", userId);
                    int recordSteps = 0;
                    try { recordSteps = Convert.ToInt32(command.ExecuteScalar()); }
                    catch (Exception ex) { MessageBox.Show("Error loading from database"); }
                    label_RecordCount.Text = recordSteps.ToString();
                }

                string totalDailySteps = "SELECT SUM(steps) FROM steps WHERE user_id = @user_id GROUP BY date ORDER BY date DESC LIMIT 1";
                using (NpgsqlCommand command = new NpgsqlCommand(totalDailySteps, connection))
                {
                    command.Parameters.AddWithValue("@user_id", userId);
                    try { this.totalDailySteps = Convert.ToInt32(command.ExecuteScalar()); }
                    catch { MessageBox.Show("Error loading from database"); }
                    label_DayProgress.Text = this.totalDailySteps.ToString() + "/8000";
                }
            }
        }
    }
}
