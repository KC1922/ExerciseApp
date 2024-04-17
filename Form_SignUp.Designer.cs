namespace ExerciseApp
{
    partial class Form_SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBox_fName = new TextBox();
            textBox_lName = new TextBox();
            textBox_Email = new TextBox();
            textBox_Username = new TextBox();
            textBox_ConfirmPswd = new TextBox();
            label_fName = new Label();
            label_lName = new Label();
            label_Email = new Label();
            label_Pswd = new Label();
            label_ConfirmPswrd = new Label();
            label_Username = new Label();
            textBox_Password = new TextBox();
            groupBox_AccountDetails = new GroupBox();
            groupBox_UserDetails = new GroupBox();
            comboBox_Gender = new ComboBox();
            textBox_Weight = new TextBox();
            textBox_Height = new TextBox();
            textBox_Age = new TextBox();
            label_Weight = new Label();
            label_Height = new Label();
            label_Gender = new Label();
            label_Age = new Label();
            toolTip1 = new ToolTip(components);
            button_CreateAccount = new Button();
            groupBox_AccountDetails.SuspendLayout();
            groupBox_UserDetails.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_fName
            // 
            textBox_fName.Location = new Point(8, 49);
            textBox_fName.Name = "textBox_fName";
            textBox_fName.Size = new Size(116, 23);
            textBox_fName.TabIndex = 4;
            // 
            // textBox_lName
            // 
            textBox_lName.Location = new Point(8, 95);
            textBox_lName.Name = "textBox_lName";
            textBox_lName.Size = new Size(116, 23);
            textBox_lName.TabIndex = 5;
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(18, 49);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(116, 23);
            textBox_Email.TabIndex = 0;
            // 
            // textBox_Username
            // 
            textBox_Username.Location = new Point(18, 95);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(116, 23);
            textBox_Username.TabIndex = 1;
            // 
            // textBox_ConfirmPswd
            // 
            textBox_ConfirmPswd.Location = new Point(18, 187);
            textBox_ConfirmPswd.Name = "textBox_ConfirmPswd";
            textBox_ConfirmPswd.Size = new Size(116, 23);
            textBox_ConfirmPswd.TabIndex = 3;
            // 
            // label_fName
            // 
            label_fName.AutoSize = true;
            label_fName.Location = new Point(6, 30);
            label_fName.Name = "label_fName";
            label_fName.Size = new Size(67, 15);
            label_fName.TabIndex = 5;
            label_fName.Text = "First Name:";
            // 
            // label_lName
            // 
            label_lName.AutoSize = true;
            label_lName.Location = new Point(6, 76);
            label_lName.Name = "label_lName";
            label_lName.Size = new Size(66, 15);
            label_lName.TabIndex = 6;
            label_lName.Text = "Last Name:";
            // 
            // label_Email
            // 
            label_Email.AutoSize = true;
            label_Email.Location = new Point(16, 30);
            label_Email.Name = "label_Email";
            label_Email.Size = new Size(44, 15);
            label_Email.TabIndex = 7;
            label_Email.Text = "*Email:";
            // 
            // label_Pswd
            // 
            label_Pswd.AutoSize = true;
            label_Pswd.Location = new Point(16, 122);
            label_Pswd.Name = "label_Pswd";
            label_Pswd.Size = new Size(65, 15);
            label_Pswd.TabIndex = 8;
            label_Pswd.Text = "*Password:";
            // 
            // label_ConfirmPswrd
            // 
            label_ConfirmPswrd.AutoSize = true;
            label_ConfirmPswrd.Location = new Point(16, 168);
            label_ConfirmPswrd.Name = "label_ConfirmPswrd";
            label_ConfirmPswrd.Size = new Size(112, 15);
            label_ConfirmPswrd.TabIndex = 9;
            label_ConfirmPswrd.Text = "*Confirm Password:";
            // 
            // label_Username
            // 
            label_Username.AutoSize = true;
            label_Username.Location = new Point(16, 76);
            label_Username.Name = "label_Username";
            label_Username.Size = new Size(68, 15);
            label_Username.TabIndex = 10;
            label_Username.Text = "*Username:";
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(18, 141);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(116, 23);
            textBox_Password.TabIndex = 2;
            // 
            // groupBox_AccountDetails
            // 
            groupBox_AccountDetails.Controls.Add(textBox_Password);
            groupBox_AccountDetails.Controls.Add(label_Username);
            groupBox_AccountDetails.Controls.Add(label_ConfirmPswrd);
            groupBox_AccountDetails.Controls.Add(textBox_Email);
            groupBox_AccountDetails.Controls.Add(label_Pswd);
            groupBox_AccountDetails.Controls.Add(textBox_Username);
            groupBox_AccountDetails.Controls.Add(label_Email);
            groupBox_AccountDetails.Controls.Add(textBox_ConfirmPswd);
            groupBox_AccountDetails.Location = new Point(12, 21);
            groupBox_AccountDetails.Name = "groupBox_AccountDetails";
            groupBox_AccountDetails.RightToLeft = RightToLeft.No;
            groupBox_AccountDetails.Size = new Size(157, 232);
            groupBox_AccountDetails.TabIndex = 12;
            groupBox_AccountDetails.TabStop = false;
            groupBox_AccountDetails.Text = "Account Details";
            // 
            // groupBox_UserDetails
            // 
            groupBox_UserDetails.Controls.Add(comboBox_Gender);
            groupBox_UserDetails.Controls.Add(textBox_Weight);
            groupBox_UserDetails.Controls.Add(textBox_Height);
            groupBox_UserDetails.Controls.Add(textBox_Age);
            groupBox_UserDetails.Controls.Add(label_Weight);
            groupBox_UserDetails.Controls.Add(label_fName);
            groupBox_UserDetails.Controls.Add(label_Height);
            groupBox_UserDetails.Controls.Add(textBox_fName);
            groupBox_UserDetails.Controls.Add(label_Gender);
            groupBox_UserDetails.Controls.Add(label_lName);
            groupBox_UserDetails.Controls.Add(label_Age);
            groupBox_UserDetails.Controls.Add(textBox_lName);
            groupBox_UserDetails.Location = new Point(175, 21);
            groupBox_UserDetails.Name = "groupBox_UserDetails";
            groupBox_UserDetails.Size = new Size(259, 183);
            groupBox_UserDetails.TabIndex = 13;
            groupBox_UserDetails.TabStop = false;
            groupBox_UserDetails.Text = "Personal Information";
            toolTip1.SetToolTip(groupBox_UserDetails, "Not required, but this information helps in\r\ncalculations dealing with calorie burning.\r\n");
            // 
            // comboBox_Gender
            // 
            comboBox_Gender.FormattingEnabled = true;
            comboBox_Gender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            comboBox_Gender.Location = new Point(8, 141);
            comboBox_Gender.Name = "comboBox_Gender";
            comboBox_Gender.Size = new Size(116, 23);
            comboBox_Gender.TabIndex = 6;
            // 
            // textBox_Weight
            // 
            textBox_Weight.Location = new Point(171, 95);
            textBox_Weight.Name = "textBox_Weight";
            textBox_Weight.Size = new Size(68, 23);
            textBox_Weight.TabIndex = 8;
            // 
            // textBox_Height
            // 
            textBox_Height.Location = new Point(171, 48);
            textBox_Height.Name = "textBox_Height";
            textBox_Height.Size = new Size(68, 23);
            textBox_Height.TabIndex = 7;
            // 
            // textBox_Age
            // 
            textBox_Age.Location = new Point(171, 141);
            textBox_Age.Name = "textBox_Age";
            textBox_Age.Size = new Size(68, 23);
            textBox_Age.TabIndex = 9;
            // 
            // label_Weight
            // 
            label_Weight.AutoSize = true;
            label_Weight.Location = new Point(168, 76);
            label_Weight.Name = "label_Weight";
            label_Weight.Size = new Size(71, 15);
            label_Weight.TabIndex = 17;
            label_Weight.Text = "Weight(lbs):";
            // 
            // label_Height
            // 
            label_Height.AutoSize = true;
            label_Height.Location = new Point(168, 30);
            label_Height.Name = "label_Height";
            label_Height.Size = new Size(62, 15);
            label_Height.TabIndex = 16;
            label_Height.Text = "Height(ft):";
            // 
            // label_Gender
            // 
            label_Gender.AutoSize = true;
            label_Gender.Location = new Point(6, 123);
            label_Gender.Name = "label_Gender";
            label_Gender.Size = new Size(48, 15);
            label_Gender.TabIndex = 15;
            label_Gender.Text = "Gender:";
            // 
            // label_Age
            // 
            label_Age.AutoSize = true;
            label_Age.Location = new Point(168, 122);
            label_Age.Name = "label_Age";
            label_Age.Size = new Size(31, 15);
            label_Age.TabIndex = 14;
            label_Age.Text = "Age:";
            // 
            // button_CreateAccount
            // 
            button_CreateAccount.Location = new Point(175, 210);
            button_CreateAccount.Name = "button_CreateAccount";
            button_CreateAccount.Size = new Size(259, 43);
            button_CreateAccount.TabIndex = 14;
            button_CreateAccount.Text = "Create Account";
            button_CreateAccount.UseVisualStyleBackColor = true;
            button_CreateAccount.Click += button_CreateAccount_Click;
            // 
            // Form_SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 273);
            Controls.Add(button_CreateAccount);
            Controls.Add(groupBox_UserDetails);
            Controls.Add(groupBox_AccountDetails);
            Name = "Form_SignUp";
            Text = "Form_SignUp";
            Load += Form_SignUp_Load;
            groupBox_AccountDetails.ResumeLayout(false);
            groupBox_AccountDetails.PerformLayout();
            groupBox_UserDetails.ResumeLayout(false);
            groupBox_UserDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox_fName;
        private TextBox textBox_lName;
        private TextBox textBox_Email;
        private TextBox textBox_Username;
        private TextBox textBox_ConfirmPswd;
        private Label label_fName;
        private Label label_lName;
        private Label label_Email;
        private Label label_Pswd;
        private Label label_ConfirmPswrd;
        private Label label_Username;
        private TextBox textBox_Password;
        private GroupBox groupBox_AccountDetails;
        private GroupBox groupBox_UserDetails;
        private Label label_Age;
        private Label label_Gender;
        private Label label_Height;
        private Label label_Weight;
        private ComboBox comboBox_Gender;
        private TextBox textBox_Weight;
        private TextBox textBox_Height;
        private TextBox textBox_Age;
        private ToolTip toolTip1;
        private Button button_CreateAccount;
    }
}