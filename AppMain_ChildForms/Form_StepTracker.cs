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
        private Color highlight = Color.FromArgb(140, 33, 85);
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
                    object queryResult = 0;
                    try { queryResult = command.ExecuteScalar(); }
                    catch (Exception ex) { MessageBox.Show("Error loading from database"); }

                    if (queryResult != DBNull.Value && queryResult != null)
                    {
                        label_PreviousStepsCount.Text = queryResult.ToString();
                    }
                    else
                    {
                        label_PreviousStepsCount.Text = "0";
                    }

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

                string totalDailySteps = "SELECT SUM(steps) FROM steps WHERE user_id = @user_id AND date = @date GROUP BY date ORDER BY date DESC LIMIT 1";
                using (NpgsqlCommand command = new NpgsqlCommand(totalDailySteps, connection))
                {
                    DateTime today = DateTime.Now;
                    command.Parameters.AddWithValue("@user_id", userId);
                    command.Parameters.AddWithValue("@date", today);
                    object queryResult = 0;
                    try { queryResult = command.ExecuteScalar(); }
                    catch { MessageBox.Show("Error loading from database"); }
                    // Check if a entry exists for the current
                    if (queryResult != DBNull.Value)
                    {
                        this.totalDailySteps = Convert.ToInt32(queryResult);
                        label_DayProgress.Text = this.totalDailySteps.ToString() + "/8000";
                    }
                    else
                    {
                        label_DayProgress.Text = "0/8000";
                    }


                }

                if (this.totalDailySteps >= 8000)
                {
                    label_DayProgress.ForeColor = highlight;
                }
            }
        }
    }
}
