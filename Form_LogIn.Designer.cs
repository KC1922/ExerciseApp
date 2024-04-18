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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_LogIn));
            label_Username = new Label();
            label_Password = new Label();
            linkLabel_Signup = new LinkLabel();
            label_NewUser = new Label();
            textBox_Username = new TextBox();
            textBox_Password = new TextBox();
            button_LogIn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label_Username
            // 
            label_Username.AutoSize = true;
            label_Username.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_Username.Location = new Point(72, 93);
            label_Username.Name = "label_Username";
            label_Username.Size = new Size(70, 17);
            label_Username.TabIndex = 1;
            label_Username.Text = "Username:";
            // 
            // label_Password
            // 
            label_Password.AutoSize = true;
            label_Password.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_Password.Location = new Point(72, 141);
            label_Password.Name = "label_Password";
            label_Password.Size = new Size(66, 17);
            label_Password.TabIndex = 2;
            label_Password.Text = "Password:";
            // 
            // linkLabel_Signup
            // 
            linkLabel_Signup.AutoSize = true;
            linkLabel_Signup.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel_Signup.Location = new Point(155, 221);
            linkLabel_Signup.Name = "linkLabel_Signup";
            linkLabel_Signup.Size = new Size(55, 17);
            linkLabel_Signup.TabIndex = 3;
            linkLabel_Signup.TabStop = true;
            linkLabel_Signup.Text = "Sign Up!";
            linkLabel_Signup.LinkClicked += linkLabel_Signup_LinkClicked;
            // 
            // label_NewUser
            // 
            label_NewUser.AutoSize = true;
            label_NewUser.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_NewUser.Location = new Point(90, 221);
            label_NewUser.Name = "label_NewUser";
            label_NewUser.Size = new Size(70, 17);
            label_NewUser.TabIndex = 4;
            label_NewUser.Text = "New User?";
            // 
            // textBox_Username
            // 
            textBox_Username.ForeColor = SystemColors.ControlText;
            textBox_Username.Location = new Point(72, 111);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(156, 23);
            textBox_Username.TabIndex = 0;
            textBox_Username.Click += textBox_Username_Click;
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(72, 163);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.PasswordChar = '*';
            textBox_Password.Size = new Size(156, 23);
            textBox_Password.TabIndex = 1;
            textBox_Password.Click += textBox_Password_Click;
            textBox_Password.PreviewKeyDown += textBox_Password_PreviewKeyDown;
            // 
            // button_LogIn
            // 
            button_LogIn.BackColor = Color.FromArgb(152, 95, 153);
            button_LogIn.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_LogIn.Location = new Point(100, 192);
            button_LogIn.Name = "button_LogIn";
            button_LogIn.Size = new Size(100, 23);
            button_LogIn.TabIndex = 2;
            button_LogIn.Text = "Log In";
            button_LogIn.UseVisualStyleBackColor = false;
            button_LogIn.Click += button_LogIn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(72, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form_LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 241, 247);
            ClientSize = new Size(307, 249);
            Controls.Add(linkLabel_Signup);
            Controls.Add(pictureBox1);
            Controls.Add(button_LogIn);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Username);
            Controls.Add(label_NewUser);
            Controls.Add(label_Password);
            Controls.Add(label_Username);
            Name = "Form_LogIn";
            Text = "Log In";
            Load += Form_LogIn_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_Username;
        private Label label_Password;
        private LinkLabel linkLabel_Signup;
        private Label label_NewUser;
        private TextBox textBox_Username;
        private TextBox textBox_Password;
        private Button button_LogIn;
        private PictureBox pictureBox1;
    }
}