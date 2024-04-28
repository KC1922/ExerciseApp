using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ExerciseApp.AppMain_ChildForms
{
    public partial class Form_Home : Form
    {
        private Form_AppMain parentForm;
        private string dbConnection = ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString;
        private int userId;

        public Form_Home(Form_AppMain parentForm, int user_id)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.userId = user_id;
        }

        private void Form_Home_Load(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(dbConnection))
            {
                connection.Open();
                DateTime today = DateTime.Now;
                string formattedDate = today.ToString("yyyy-MM-dd");
                today = DateTime.ParseExact(formattedDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                DateTime startOfWeek = CalculateStartOfWeek();

                string totalWeeklyStepsQuery = "SELECT SUM(steps) FROM steps WHERE date BETWEEN @startOfWeek AND @today AND user_id = @user_id";
                using (NpgsqlCommand command = new NpgsqlCommand(totalWeeklyStepsQuery, connection))
                {
                    command.Parameters.AddWithValue("@user_id", userId);
                    command.Parameters.AddWithValue("@today", today);
                    command.Parameters.AddWithValue("@startOfWeek", startOfWeek);
                    try
                    {
                        object totalSteps = command.ExecuteScalar();
                        if (totalSteps != DBNull.Value && totalSteps != null)
                        {
                            string steps = totalSteps.ToString();
                            label_TotalStepsCount.Text = steps;
                        }
                        else
                        {
                            label_TotalStepsCount.Text = "0";
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("Error loading from database"); }

                }
            }
        }

        private void label_TotalStepsCount_Click(object sender, EventArgs e)
        {
            parentForm.button_Steps_Click(sender, e);
        }

        /// <summary>
        /// Calculates what date is the start of the week (Monday)
        /// </summary>
        /// <returns></returns>
        private DateTime CalculateStartOfWeek()
        {
            DateTime startOfWeek = DateTime.Now;
            DateTime currentDay = DateTime.Now;
            DayOfWeek currentDayOfWeek = currentDay.DayOfWeek;

            int dayDifference = ((int)currentDayOfWeek - (int)DayOfWeek.Monday + 7) % 7;

            startOfWeek = currentDay.AddDays(-dayDifference);

            string formattedDate = startOfWeek.ToString("yyyy-MM-dd");
            startOfWeek = DateTime.ParseExact(formattedDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);

            return startOfWeek;
        }


    }
}
