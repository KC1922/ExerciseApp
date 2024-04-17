using Npgsql;
using System.Configuration;

namespace ExerciseApp
{
    public partial class Form_LogIn : Form
    {
        string dbConnection = ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString;
        public Form_LogIn()
        {
            InitializeComponent();

        }

        private void Form_LogIn_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel_Signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_SignUp form_SignUp = new Form_SignUp();
            form_SignUp.ShowDialog();
        }

        private void button_LogIn_Click(object sender, EventArgs e)
        {
            string enteredUsername = textBox_Username.Text;
            string enteredPassword = textBox_Password.Text;

            if (string.IsNullOrEmpty(enteredUsername) || string.IsNullOrEmpty(enteredPassword))
            {
                MessageBox.Show("Please enter a username and password.");
                return;
            }

            using (NpgsqlConnection connection = new NpgsqlConnection(dbConnection))
            {
                connection.Open();

                string query_findUser = "SELECT * FROM users WHERE username = @username AND password = @password";

                using (NpgsqlCommand command = new NpgsqlCommand(query_findUser, connection))
                {
                    command.Parameters.AddWithValue("@username", enteredUsername);
                    command.Parameters.AddWithValue("@password", enteredPassword);
                    NpgsqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        Form_HomeWindow form_HomeWindow = new Form_HomeWindow();
                        form_HomeWindow.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password!");
                        textBox_Username.Clear();
                        textBox_Password.Clear();

                    }
                }
            }
        }

        private void textBox_Username_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Password_Click(object sender, EventArgs e)
        {

        }
    }
}