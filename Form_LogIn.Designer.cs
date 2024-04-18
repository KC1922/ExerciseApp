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
            label_Username = new Label();
            label_Password = new Label();
            linkLabel_Signup = new LinkLabel();
            label_NewUser = new Label();
            textBox_Username = new TextBox();
            textBox_Password = new TextBox();
            button_LogIn = new Button();
            panel1 = new Panel();
            metroSetControlBox_LogIn = new MetroSet_UI.Controls.MetroSetControlBox();
            label_Title = new Label();
            metroSetContextMenuStrip1 = new MetroSet_UI.Controls.MetroSetContextMenuStrip();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label_Username
            // 
            label_Username.Anchor = AnchorStyles.Top;
            label_Username.AutoSize = true;
            label_Username.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_Username.Location = new Point(157, 106);
            label_Username.Name = "label_Username";
            label_Username.Size = new Size(70, 17);
            label_Username.TabIndex = 1;
            label_Username.Text = "Username:";
            // 
            // label_Password
            // 
            label_Password.Anchor = AnchorStyles.Top;
            label_Password.AutoSize = true;
            label_Password.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_Password.Location = new Point(159, 154);
            label_Password.Name = "label_Password";
            label_Password.Size = new Size(66, 17);
            label_Password.TabIndex = 2;
            label_Password.Text = "Password:";
            // 
            // linkLabel_Signup
            // 
            linkLabel_Signup.Anchor = AnchorStyles.Top;
            linkLabel_Signup.AutoSize = true;
            linkLabel_Signup.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel_Signup.Location = new Point(198, 251);
            linkLabel_Signup.Name = "linkLabel_Signup";
            linkLabel_Signup.Size = new Size(55, 17);
            linkLabel_Signup.TabIndex = 3;
            linkLabel_Signup.TabStop = true;
            linkLabel_Signup.Text = "Sign Up!";
            linkLabel_Signup.LinkClicked += linkLabel_Signup_LinkClicked;
            // 
            // label_NewUser
            // 
            label_NewUser.Anchor = AnchorStyles.Top;
            label_NewUser.AutoSize = true;
            label_NewUser.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_NewUser.Location = new Point(133, 251);
            label_NewUser.Name = "label_NewUser";
            label_NewUser.Size = new Size(70, 17);
            label_NewUser.TabIndex = 4;
            label_NewUser.Text = "New User?";
            // 
            // textBox_Username
            // 
            textBox_Username.Anchor = AnchorStyles.Top;
            textBox_Username.ForeColor = SystemColors.ControlText;
            textBox_Username.Location = new Point(114, 124);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(156, 23);
            textBox_Username.TabIndex = 0;
            textBox_Username.Click += textBox_Username_Click;
            // 
            // textBox_Password
            // 
            textBox_Password.Anchor = AnchorStyles.Top;
            textBox_Password.Location = new Point(114, 176);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.PasswordChar = '*';
            textBox_Password.Size = new Size(156, 23);
            textBox_Password.TabIndex = 1;
            textBox_Password.Click += textBox_Password_Click;
            textBox_Password.PreviewKeyDown += textBox_Password_PreviewKeyDown;
            // 
            // button_LogIn
            // 
            button_LogIn.Anchor = AnchorStyles.Top;
            button_LogIn.BackColor = Color.FromArgb(152, 95, 153);
            button_LogIn.FlatStyle = FlatStyle.Flat;
            button_LogIn.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_LogIn.ForeColor = Color.Transparent;
            button_LogIn.Location = new Point(143, 212);
            button_LogIn.Name = "button_LogIn";
            button_LogIn.Size = new Size(100, 29);
            button_LogIn.TabIndex = 2;
            button_LogIn.Text = "Log In";
            button_LogIn.UseVisualStyleBackColor = false;
            button_LogIn.Click += button_LogIn_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(56, 61, 59);
            panel1.Controls.Add(metroSetControlBox_LogIn);
            panel1.Controls.Add(label_Title);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 75);
            panel1.TabIndex = 5;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // metroSetControlBox_LogIn
            // 
            metroSetControlBox_LogIn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            metroSetControlBox_LogIn.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            metroSetControlBox_LogIn.CloseHoverForeColor = Color.White;
            metroSetControlBox_LogIn.CloseNormalForeColor = Color.Gray;
            metroSetControlBox_LogIn.DisabledForeColor = Color.DimGray;
            metroSetControlBox_LogIn.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            metroSetControlBox_LogIn.IsDerivedStyle = true;
            metroSetControlBox_LogIn.Location = new Point(300, 0);
            metroSetControlBox_LogIn.MaximizeBox = true;
            metroSetControlBox_LogIn.MaximizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroSetControlBox_LogIn.MaximizeHoverForeColor = Color.Gray;
            metroSetControlBox_LogIn.MaximizeNormalForeColor = Color.Gray;
            metroSetControlBox_LogIn.MinimizeBox = true;
            metroSetControlBox_LogIn.MinimizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroSetControlBox_LogIn.MinimizeHoverForeColor = Color.Gray;
            metroSetControlBox_LogIn.MinimizeNormalForeColor = Color.Gray;
            metroSetControlBox_LogIn.Name = "metroSetControlBox_LogIn";
            metroSetControlBox_LogIn.Size = new Size(100, 25);
            metroSetControlBox_LogIn.Style = MetroSet_UI.Enums.Style.Light;
            metroSetControlBox_LogIn.StyleManager = null;
            metroSetControlBox_LogIn.TabIndex = 7;
            metroSetControlBox_LogIn.Text = "metroSetControlBox1";
            metroSetControlBox_LogIn.ThemeAuthor = "Narwin";
            metroSetControlBox_LogIn.ThemeName = "MetroLite";
            // 
            // label_Title
            // 
            label_Title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_Title.AutoSize = true;
            label_Title.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Title.ForeColor = Color.White;
            label_Title.Location = new Point(104, 21);
            label_Title.Name = "label_Title";
            label_Title.Size = new Size(177, 41);
            label_Title.TabIndex = 0;
            label_Title.Text = "MyFitness";
            // 
            // metroSetContextMenuStrip1
            // 
            metroSetContextMenuStrip1.IsDerivedStyle = true;
            metroSetContextMenuStrip1.Name = "metroSetContextMenuStrip1";
            metroSetContextMenuStrip1.Size = new Size(61, 4);
            metroSetContextMenuStrip1.Style = MetroSet_UI.Enums.Style.Light;
            metroSetContextMenuStrip1.StyleManager = null;
            metroSetContextMenuStrip1.ThemeAuthor = "Narwin";
            metroSetContextMenuStrip1.ThemeName = "MetroLite";
            // 
            // Form_LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 229, 233);
            ClientSize = new Size(399, 299);
            Controls.Add(panel1);
            Controls.Add(linkLabel_Signup);
            Controls.Add(button_LogIn);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Username);
            Controls.Add(label_NewUser);
            Controls.Add(label_Password);
            Controls.Add(label_Username);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            Load += Form_LogIn_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Label label_Title;
        private MetroSet_UI.Controls.MetroSetContextMenuStrip metroSetContextMenuStrip1;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox_LogIn;
    }
}