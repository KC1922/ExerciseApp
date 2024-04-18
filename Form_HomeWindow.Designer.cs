﻿namespace ExerciseApp
{
    partial class Form_HomeWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_HomeWindow));
            label_Welcome = new Label();
            panel_Top = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button_AddWorkout = new Button();
            imageList1 = new ImageList(components);
            panel_BackAddWorkout = new Panel();
            button_Add = new Button();
            dateTimePicker_Duration = new DateTimePicker();
            dateTimePicker_StartTime = new DateTimePicker();
            dateTimePicker_Date = new DateTimePicker();
            label_Duration = new Label();
            label_StartTime = new Label();
            label_Date = new Label();
            textBox_MinHR = new TextBox();
            textBox_MaxHR = new TextBox();
            textBox_Distance = new TextBox();
            label_MinHR = new Label();
            label_MaxHR = new Label();
            label_Distance = new Label();
            label_AverageSpeed = new Label();
            comboBox_ExerciseList = new ComboBox();
            label_AveragePace = new Label();
            label_Exercise = new Label();
            label_CaloriesBurned = new Label();
            textBox_AvgSpeed = new TextBox();
            textBox_AvgPace = new TextBox();
            textBox_Calories = new TextBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel_Top.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_BackAddWorkout.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label_Welcome
            // 
            label_Welcome.AutoSize = true;
            label_Welcome.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_Welcome.ForeColor = Color.FromArgb(152, 95, 153);
            label_Welcome.Location = new Point(11, 9);
            label_Welcome.Name = "label_Welcome";
            label_Welcome.Size = new Size(234, 25);
            label_Welcome.TabIndex = 0;
            label_Welcome.Text = "Welcome back User   ";
            // 
            // panel_Top
            // 
            panel_Top.BackColor = Color.WhiteSmoke;
            panel_Top.Controls.Add(label_Welcome);
            panel_Top.Location = new Point(184, 0);
            panel_Top.Name = "panel_Top";
            panel_Top.Size = new Size(640, 42);
            panel_Top.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(73, 163, 215);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(189, 585);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(73, 163, 215);
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button_AddWorkout
            // 
            button_AddWorkout.BackColor = Color.FromArgb(55, 142, 191);
            button_AddWorkout.FlatAppearance.BorderSize = 0;
            button_AddWorkout.FlatStyle = FlatStyle.Flat;
            button_AddWorkout.Font = new Font("Archivo Black", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            button_AddWorkout.ImageAlign = ContentAlignment.MiddleLeft;
            button_AddWorkout.ImageList = imageList1;
            button_AddWorkout.Location = new Point(33, 1);
            button_AddWorkout.Name = "button_AddWorkout";
            button_AddWorkout.Size = new Size(145, 40);
            button_AddWorkout.TabIndex = 0;
            button_AddWorkout.Text = "Add Workout";
            button_AddWorkout.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_AddWorkout.UseVisualStyleBackColor = false;
            button_AddWorkout.Click += button_AddWorkout_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Freepik_dumbbell.png");
            // 
            // panel_BackAddWorkout
            // 
            panel_BackAddWorkout.BackColor = Color.FromArgb(233, 241, 247);
            panel_BackAddWorkout.Controls.Add(button_Add);
            panel_BackAddWorkout.Controls.Add(dateTimePicker_Duration);
            panel_BackAddWorkout.Controls.Add(dateTimePicker_StartTime);
            panel_BackAddWorkout.Controls.Add(dateTimePicker_Date);
            panel_BackAddWorkout.Controls.Add(label_Duration);
            panel_BackAddWorkout.Controls.Add(label_StartTime);
            panel_BackAddWorkout.Controls.Add(label_Date);
            panel_BackAddWorkout.Controls.Add(textBox_MinHR);
            panel_BackAddWorkout.Controls.Add(textBox_MaxHR);
            panel_BackAddWorkout.Controls.Add(textBox_Distance);
            panel_BackAddWorkout.Controls.Add(label_MinHR);
            panel_BackAddWorkout.Controls.Add(label_MaxHR);
            panel_BackAddWorkout.Controls.Add(label_Distance);
            panel_BackAddWorkout.Controls.Add(label_AverageSpeed);
            panel_BackAddWorkout.Controls.Add(comboBox_ExerciseList);
            panel_BackAddWorkout.Controls.Add(label_AveragePace);
            panel_BackAddWorkout.Controls.Add(label_Exercise);
            panel_BackAddWorkout.Controls.Add(label_CaloriesBurned);
            panel_BackAddWorkout.Controls.Add(textBox_AvgSpeed);
            panel_BackAddWorkout.Controls.Add(textBox_AvgPace);
            panel_BackAddWorkout.Controls.Add(textBox_Calories);
            panel_BackAddWorkout.Location = new Point(184, 42);
            panel_BackAddWorkout.Name = "panel_BackAddWorkout";
            panel_BackAddWorkout.Size = new Size(637, 543);
            panel_BackAddWorkout.TabIndex = 3;
            // 
            // button_Add
            // 
            button_Add.BackColor = Color.FromArgb(152, 95, 153);
            button_Add.FlatAppearance.BorderColor = Color.White;
            button_Add.FlatStyle = FlatStyle.Popup;
            button_Add.Location = new Point(215, 223);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(106, 30);
            button_Add.TabIndex = 17;
            button_Add.Text = "Add to Log";
            button_Add.UseVisualStyleBackColor = false;
            button_Add.Click += button_Add_Click;
            // 
            // dateTimePicker_Duration
            // 
            dateTimePicker_Duration.CustomFormat = "HH:mm";
            dateTimePicker_Duration.Format = DateTimePickerFormat.Custom;
            dateTimePicker_Duration.Location = new Point(215, 163);
            dateTimePicker_Duration.Name = "dateTimePicker_Duration";
            dateTimePicker_Duration.ShowUpDown = true;
            dateTimePicker_Duration.Size = new Size(106, 23);
            dateTimePicker_Duration.TabIndex = 9;
            dateTimePicker_Duration.Value = new DateTime(2024, 4, 16, 0, 0, 0, 0);
            // 
            // dateTimePicker_StartTime
            // 
            dateTimePicker_StartTime.Format = DateTimePickerFormat.Time;
            dateTimePicker_StartTime.Location = new Point(215, 102);
            dateTimePicker_StartTime.Name = "dateTimePicker_StartTime";
            dateTimePicker_StartTime.ShowUpDown = true;
            dateTimePicker_StartTime.Size = new Size(106, 23);
            dateTimePicker_StartTime.TabIndex = 8;
            // 
            // dateTimePicker_Date
            // 
            dateTimePicker_Date.Format = DateTimePickerFormat.Short;
            dateTimePicker_Date.Location = new Point(215, 38);
            dateTimePicker_Date.Name = "dateTimePicker_Date";
            dateTimePicker_Date.Size = new Size(106, 23);
            dateTimePicker_Date.TabIndex = 7;
            // 
            // label_Duration
            // 
            label_Duration.AutoSize = true;
            label_Duration.Location = new Point(215, 138);
            label_Duration.Name = "label_Duration";
            label_Duration.Size = new Size(56, 15);
            label_Duration.TabIndex = 16;
            label_Duration.Text = "Duration:";
            // 
            // label_StartTime
            // 
            label_StartTime.AutoSize = true;
            label_StartTime.Location = new Point(215, 74);
            label_StartTime.Name = "label_StartTime";
            label_StartTime.Size = new Size(63, 15);
            label_StartTime.TabIndex = 15;
            label_StartTime.Text = "Start Time:";
            // 
            // label_Date
            // 
            label_Date.AutoSize = true;
            label_Date.Location = new Point(215, 10);
            label_Date.Name = "label_Date";
            label_Date.Size = new Size(76, 15);
            label_Date.TabIndex = 14;
            label_Date.Text = "Today's Date:";
            // 
            // textBox_MinHR
            // 
            textBox_MinHR.Location = new Point(33, 422);
            textBox_MinHR.Name = "textBox_MinHR";
            textBox_MinHR.Size = new Size(121, 23);
            textBox_MinHR.TabIndex = 6;
            // 
            // textBox_MaxHR
            // 
            textBox_MaxHR.Location = new Point(33, 358);
            textBox_MaxHR.Name = "textBox_MaxHR";
            textBox_MaxHR.Size = new Size(121, 23);
            textBox_MaxHR.TabIndex = 5;
            // 
            // textBox_Distance
            // 
            textBox_Distance.Location = new Point(33, 294);
            textBox_Distance.Name = "textBox_Distance";
            textBox_Distance.Size = new Size(121, 23);
            textBox_Distance.TabIndex = 4;
            // 
            // label_MinHR
            // 
            label_MinHR.AutoSize = true;
            label_MinHR.Location = new Point(33, 394);
            label_MinHR.Name = "label_MinHR";
            label_MinHR.Size = new Size(121, 15);
            label_MinHR.TabIndex = 10;
            label_MinHR.Text = "Minimum Heart Rate:";
            // 
            // label_MaxHR
            // 
            label_MaxHR.AutoSize = true;
            label_MaxHR.Location = new Point(33, 330);
            label_MaxHR.Name = "label_MaxHR";
            label_MaxHR.Size = new Size(91, 15);
            label_MaxHR.TabIndex = 9;
            label_MaxHR.Text = "Max Heart Rate:";
            // 
            // label_Distance
            // 
            label_Distance.AutoSize = true;
            label_Distance.Location = new Point(33, 266);
            label_Distance.Name = "label_Distance";
            label_Distance.Size = new Size(55, 15);
            label_Distance.TabIndex = 8;
            label_Distance.Text = "Distance:";
            // 
            // label_AverageSpeed
            // 
            label_AverageSpeed.AutoSize = true;
            label_AverageSpeed.Location = new Point(33, 202);
            label_AverageSpeed.Name = "label_AverageSpeed";
            label_AverageSpeed.Size = new Size(88, 15);
            label_AverageSpeed.TabIndex = 7;
            label_AverageSpeed.Text = "Average Speed:";
            // 
            // comboBox_ExerciseList
            // 
            comboBox_ExerciseList.FormattingEnabled = true;
            comboBox_ExerciseList.Location = new Point(33, 38);
            comboBox_ExerciseList.Name = "comboBox_ExerciseList";
            comboBox_ExerciseList.Size = new Size(121, 23);
            comboBox_ExerciseList.TabIndex = 0;
            comboBox_ExerciseList.SelectedIndexChanged += comboBox_ExerciseList_SelectedIndexChanged;
            // 
            // label_AveragePace
            // 
            label_AveragePace.AutoSize = true;
            label_AveragePace.Location = new Point(33, 138);
            label_AveragePace.Name = "label_AveragePace";
            label_AveragePace.Size = new Size(81, 15);
            label_AveragePace.TabIndex = 5;
            label_AveragePace.Text = "Average Pace:";
            // 
            // label_Exercise
            // 
            label_Exercise.AutoSize = true;
            label_Exercise.Location = new Point(33, 10);
            label_Exercise.Name = "label_Exercise";
            label_Exercise.Size = new Size(52, 15);
            label_Exercise.TabIndex = 4;
            label_Exercise.Text = "Exercise:";
            // 
            // label_CaloriesBurned
            // 
            label_CaloriesBurned.AutoSize = true;
            label_CaloriesBurned.Location = new Point(33, 74);
            label_CaloriesBurned.Name = "label_CaloriesBurned";
            label_CaloriesBurned.Size = new Size(93, 15);
            label_CaloriesBurned.TabIndex = 3;
            label_CaloriesBurned.Text = "Calories Burned:";
            // 
            // textBox_AvgSpeed
            // 
            textBox_AvgSpeed.Location = new Point(33, 230);
            textBox_AvgSpeed.Name = "textBox_AvgSpeed";
            textBox_AvgSpeed.Size = new Size(121, 23);
            textBox_AvgSpeed.TabIndex = 3;
            // 
            // textBox_AvgPace
            // 
            textBox_AvgPace.Location = new Point(33, 166);
            textBox_AvgPace.Name = "textBox_AvgPace";
            textBox_AvgPace.Size = new Size(121, 23);
            textBox_AvgPace.TabIndex = 2;
            // 
            // textBox_Calories
            // 
            textBox_Calories.Location = new Point(33, 102);
            textBox_Calories.Name = "textBox_Calories";
            textBox_Calories.Size = new Size(121, 23);
            textBox_Calories.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(55, 142, 191);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(button_AddWorkout);
            panel2.Location = new Point(0, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 42);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(8, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Form_HomeWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(821, 584);
            Controls.Add(panel_Top);
            Controls.Add(panel_BackAddWorkout);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form_HomeWindow";
            Text = "Form1";
            FormClosing += Form_HomeWindow_FormClosing;
            Load += Form_HomeWindow_Load;
            panel_Top.ResumeLayout(false);
            panel_Top.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_BackAddWorkout.ResumeLayout(false);
            panel_BackAddWorkout.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label_Welcome;
        private Panel panel_Top;
        private Panel panel1;
        private Button button_AddWorkout;
        private ImageList imageList1;
        private Panel panel_BackAddWorkout;
        private Label label_AverageSpeed;
        private ComboBox comboBox_ExerciseList;
        private Label label_AveragePace;
        private Label label_Exercise;
        private Label label_CaloriesBurned;
        private TextBox textBox_AvgSpeed;
        private TextBox textBox_AvgPace;
        private TextBox textBox_Calories;
        private TextBox textBox_MinHR;
        private TextBox textBox_MaxHR;
        private TextBox textBox_Distance;
        private Label label_MinHR;
        private Label label_MaxHR;
        private Label label_Distance;
        private DateTimePicker dateTimePicker_StartTime;
        private DateTimePicker dateTimePicker_Date;
        private Label label_Duration;
        private Label label_StartTime;
        private Label label_Date;
        private DateTimePicker dateTimePicker_Duration;
        private Button button_Add;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}