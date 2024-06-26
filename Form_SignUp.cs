﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Transactions;

namespace ExerciseApp
{

    public partial class Form_SignUp : Form
    {
        string dbConnection = ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString;
        public Form_SignUp()
        {
            InitializeComponent();
        }

        private void Form_SignUp_Load(object sender, EventArgs e)
        {

        }

        private void button_CreateAccount_Click(object sender, EventArgs e)
        {
            string enteredfName = textBox_fName.Text;
            string enteredlName = textBox_lName.Text;
            string enteredEmail = textBox_Email.Text;
            string enteredPassword = textBox_Password.Text;
            string enteredPasswordConfirm = textBox_ConfirmPswd.Text;
            string enteredUsername = textBox_Username.Text;
            string enteredGender = comboBox_Gender.Text;
            string enteredAge = textBox_Age.Text;
            string enteredWeight = textBox_Weight.Text;
            string enteredHeight = textBox_Height.Text;

            if (string.Compare(enteredPassword, enteredPasswordConfirm) != 0)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (string.IsNullOrEmpty(enteredEmail) || string.IsNullOrEmpty(enteredPassword)
                || string.IsNullOrEmpty(enteredUsername) || string.IsNullOrEmpty(enteredPasswordConfirm))
            {
                MessageBox.Show("Please enter information into the required(*) fields.");
                return;
            }


            using (NpgsqlConnection connection = new NpgsqlConnection(dbConnection))
            {
                connection.Open();

                // Begin a transaction as code inserts values into two tables
                using (NpgsqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string checkExistingAccount = @"SELECT * FROM users WHERE email = @email";

                        // Check for existing account
                        using (NpgsqlCommand checkExistingAccountcommand = new NpgsqlCommand(checkExistingAccount, connection))
                        {
                            checkExistingAccountcommand.Parameters.AddWithValue("@email", enteredEmail);
                            NpgsqlDataReader reader = checkExistingAccountcommand.ExecuteReader();
                            if (reader.Read())
                            {
                                MessageBox.Show("An account with that email already exists!");
                                reader.Close();
                                return;
                            }
                            reader.Close();
                        }

                        // Insert into Users table
                        string insertUserQuery = @"INSERT INTO users (email, username, password, fName, lName)
                                   VALUES (@email, @username, @password, @fName, @lName)
                                   RETURNING user_id";

                        // Execute insert command for Users table
                        int userId;
                        using (NpgsqlCommand command = new NpgsqlCommand(insertUserQuery, connection))
                        {
                            command.Parameters.AddWithValue("@email", enteredEmail);
                            command.Parameters.AddWithValue("@username", enteredUsername);
                            command.Parameters.AddWithValue("@password", enteredPassword);
                            command.Parameters.AddWithValue("@fName", string.IsNullOrEmpty(enteredfName) ? (object)DBNull.Value : enteredfName);
                            command.Parameters.AddWithValue("@lName", string.IsNullOrEmpty(enteredlName) ? (object)DBNull.Value : enteredlName);

                            // Execute the command and retrieve the userid of the newly inserted user
                            userId = (int)command.ExecuteScalar();

                            if (userId == 0)
                            {
                                throw new Exception("Failed to add user information.");
                            }

                            // Insert into UserPhysicalDetails table
                            string insertUserPhysicalDetailsQuery = @"INSERT INTO user_physical_details (user_id, age, gender, height)
                                                       VALUES (@userId, @age, @gender, @height)";

                            // Execute insert command for UserPhysicalDetails table
                            using (NpgsqlCommand insertUserPhysicalDetailsCommand = new NpgsqlCommand(insertUserPhysicalDetailsQuery, connection))
                            {

                                insertUserPhysicalDetailsCommand.Parameters.AddWithValue("@userId", userId);
                                insertUserPhysicalDetailsCommand.Parameters.AddWithValue("@gender", string.IsNullOrEmpty(enteredGender)
                                                                                                ? "Other" : enteredGender);
                                // Validate certain inputs to avoid insetion errors
                                try
                                {
                                    insertUserPhysicalDetailsCommand.Parameters.AddWithValue("@age", string.IsNullOrEmpty(enteredAge)
                                                                                                ? (object)DBNull.Value : int.Parse(enteredAge));
                                }
                                catch (FormatException) { throw new Exception("Enter a valid age."); }
                                try
                                {
                                    insertUserPhysicalDetailsCommand.Parameters.AddWithValue("@height", string.IsNullOrEmpty(enteredHeight)
                                                                                                ? (object)DBNull.Value : decimal.Parse(enteredHeight));
                                }
                                catch (FormatException) { throw new Exception("Enter a valid height."); }

                                int rowsAffected = insertUserPhysicalDetailsCommand.ExecuteNonQuery();
                                if (rowsAffected == 0)
                                {
                                    throw new Exception("Failed to add user physical details.");
                                }
                            }
                        }

                        // Insert into Weight table
                        string insertWeightQuery = @"INSERT INTO weight (user_id, weight, date)
                                            VALUES (@userId, @weight, CURRENT_TIMESTAMP)";

                        // Execute insert command for Weight table
                        using (NpgsqlCommand insertWeightCommand = new NpgsqlCommand(insertWeightQuery, connection))
                        {
                            insertWeightCommand.Parameters.AddWithValue("@userId", userId);
                            try
                            {
                                insertWeightCommand.Parameters.AddWithValue("@weight", string.IsNullOrEmpty(enteredWeight)
                                                                                               ? (object)DBNull.Value : decimal.Parse(enteredHeight));
                            }
                            catch (FormatException) { throw new Exception("Enter a valid weight."); }

                            int rowsAffected = insertWeightCommand.ExecuteNonQuery();
                            if (rowsAffected == 0)
                            {
                                throw new Exception("Failed to insert weight.");
                            }
                        }

                        // Commit the transaction if all operations succeed
                        transaction.Commit();
                        MessageBox.Show("Account created successfully!");
                    }
                    catch (Exception ex)
                    {
                        // Rollback the transaction if an exception occurs during any operation
                        transaction.Rollback();
                        MessageBox.Show("Error creating account: " + ex.Message);
                        return;
                    }

                }

            }
            this.Close();
        }
    }
}
