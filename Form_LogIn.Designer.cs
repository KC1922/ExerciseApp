namespace ExerciseApp
{
    partial class Form_LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_Title = new Label();
            label_Username = new Label();
            label_Password = new Label();
            linkLabel_Signup = new LinkLabel();
            label_NewUser = new Label();
            textBox_Username = new TextBox();
            textBox_Password = new TextBox();
            button_LogIn = new Button();
            SuspendLayout();
            // 
            // label_Title
            // 
            label_Title.AutoSize = true;
            label_Title.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Title.Location = new Point(12, 9);
            label_Title.Name = "label_Title";
            label_Title.Size = new Size(161, 32);
            label_Title.TabIndex = 0;
            label_Title.Text = "MyExercise";
            // 
            // label_Username
            // 
            label_Username.AutoSize = true;
            label_Username.Location = new Point(18, 56);
            label_Username.Name = "label_Username";
            label_Username.Size = new Size(63, 15);
            label_Username.TabIndex = 1;
            label_Username.Text = "Username:";
            // 
            // label_Password
            // 
            label_Password.AutoSize = true;
            label_Password.Location = new Point(18, 104);
            label_Password.Name = "label_Password";
            label_Password.Size = new Size(60, 15);
            label_Password.TabIndex = 2;
            label_Password.Text = "Password:";
            // 
            // linkLabel_Signup
            // 
            linkLabel_Signup.AutoSize = true;
            linkLabel_Signup.Location = new Point(76, 186);
            linkLabel_Signup.Name = "linkLabel_Signup";
            linkLabel_Signup.Size = new Size(51, 15);
            linkLabel_Signup.TabIndex = 3;
            linkLabel_Signup.TabStop = true;
            linkLabel_Signup.Text = "Sign Up!";
            linkLabel_Signup.LinkClicked += linkLabel_Signup_LinkClicked;
            // 
            // label_NewUser
            // 
            label_NewUser.AutoSize = true;
            label_NewUser.Location = new Point(18, 186);
            label_NewUser.Name = "label_NewUser";
            label_NewUser.Size = new Size(62, 15);
            label_NewUser.TabIndex = 4;
            label_NewUser.Text = "New User?";
            // 
            // textBox_Username
            // 
            textBox_Username.ForeColor = SystemColors.ControlText;
            textBox_Username.Location = new Point(18, 74);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(100, 23);
            textBox_Username.TabIndex = 0;
            textBox_Username.Click += textBox_Username_Click;
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(18, 126);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.PasswordChar = '*';
            textBox_Password.Size = new Size(100, 23);
            textBox_Password.TabIndex = 1;
            textBox_Password.Click += textBox_Password_Click;
            // 
            // button_LogIn
            // 
            button_LogIn.Location = new Point(18, 156);
            button_LogIn.Name = "button_LogIn";
            button_LogIn.Size = new Size(100, 23);
            button_LogIn.TabIndex = 2;
            button_LogIn.Text = "Log In";
            button_LogIn.UseVisualStyleBackColor = true;
            button_LogIn.Click += button_LogIn_Click;
            // 
            // Form_LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 239);
            Controls.Add(button_LogIn);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Username);
            Controls.Add(label_NewUser);
            Controls.Add(linkLabel_Signup);
            Controls.Add(label_Password);
            Controls.Add(label_Username);
            Controls.Add(label_Title);
            Name = "Form_LogIn";
            Text = "Log In";
            Load += Form_LogIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Title;
        private Label label_Username;
        private Label label_Password;
        private LinkLabel linkLabel_Signup;
        private Label label_NewUser;
        private TextBox textBox_Username;
        private TextBox textBox_Password;
        private Button button_LogIn;
    }
}