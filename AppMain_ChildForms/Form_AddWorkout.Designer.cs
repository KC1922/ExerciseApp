namespace ExerciseApp.AppMain_ChildForms
{
    partial class Form_AddWorkout
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
            SuspendLayout();
            // 
            // button_Add
            // 
            button_Add.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_Add.BackColor = Color.FromArgb(139, 58, 112);
            button_Add.FlatAppearance.BorderColor = Color.White;
            button_Add.FlatStyle = FlatStyle.Flat;
            button_Add.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_Add.ForeColor = Color.White;
            button_Add.Location = new Point(438, 221);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(106, 30);
            button_Add.TabIndex = 38;
            button_Add.Text = "Add to Log";
            button_Add.UseVisualStyleBackColor = false;
            button_Add.Click += button_Add_Click;
            // 
            // dateTimePicker_Duration
            // 
            dateTimePicker_Duration.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker_Duration.CustomFormat = "HH:mm";
            dateTimePicker_Duration.Format = DateTimePickerFormat.Custom;
            dateTimePicker_Duration.Location = new Point(438, 161);
            dateTimePicker_Duration.Name = "dateTimePicker_Duration";
            dateTimePicker_Duration.ShowUpDown = true;
            dateTimePicker_Duration.Size = new Size(106, 23);
            dateTimePicker_Duration.TabIndex = 32;
            dateTimePicker_Duration.Value = new DateTime(2024, 4, 16, 0, 0, 0, 0);
            // 
            // dateTimePicker_StartTime
            // 
            dateTimePicker_StartTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker_StartTime.Format = DateTimePickerFormat.Time;
            dateTimePicker_StartTime.Location = new Point(438, 100);
            dateTimePicker_StartTime.Name = "dateTimePicker_StartTime";
            dateTimePicker_StartTime.ShowUpDown = true;
            dateTimePicker_StartTime.Size = new Size(106, 23);
            dateTimePicker_StartTime.TabIndex = 30;
            // 
            // dateTimePicker_Date
            // 
            dateTimePicker_Date.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker_Date.Format = DateTimePickerFormat.Short;
            dateTimePicker_Date.Location = new Point(438, 36);
            dateTimePicker_Date.Name = "dateTimePicker_Date";
            dateTimePicker_Date.Size = new Size(106, 23);
            dateTimePicker_Date.TabIndex = 28;
            // 
            // label_Duration
            // 
            label_Duration.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_Duration.AutoSize = true;
            label_Duration.Location = new Point(438, 136);
            label_Duration.Name = "label_Duration";
            label_Duration.Size = new Size(56, 15);
            label_Duration.TabIndex = 37;
            label_Duration.Text = "Duration:";
            // 
            // label_StartTime
            // 
            label_StartTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_StartTime.AutoSize = true;
            label_StartTime.Location = new Point(438, 72);
            label_StartTime.Name = "label_StartTime";
            label_StartTime.Size = new Size(63, 15);
            label_StartTime.TabIndex = 36;
            label_StartTime.Text = "Start Time:";
            // 
            // label_Date
            // 
            label_Date.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_Date.AutoSize = true;
            label_Date.Location = new Point(438, 8);
            label_Date.Name = "label_Date";
            label_Date.Size = new Size(76, 15);
            label_Date.TabIndex = 35;
            label_Date.Text = "Today's Date:";
            // 
            // textBox_MinHR
            // 
            textBox_MinHR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_MinHR.Location = new Point(423, 356);
            textBox_MinHR.Name = "textBox_MinHR";
            textBox_MinHR.Size = new Size(121, 23);
            textBox_MinHR.TabIndex = 27;
            // 
            // textBox_MaxHR
            // 
            textBox_MaxHR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_MaxHR.Location = new Point(256, 356);
            textBox_MaxHR.Name = "textBox_MaxHR";
            textBox_MaxHR.Size = new Size(121, 23);
            textBox_MaxHR.TabIndex = 25;
            // 
            // textBox_Distance
            // 
            textBox_Distance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Distance.Location = new Point(256, 292);
            textBox_Distance.Name = "textBox_Distance";
            textBox_Distance.Size = new Size(121, 23);
            textBox_Distance.TabIndex = 24;
            // 
            // label_MinHR
            // 
            label_MinHR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_MinHR.AutoSize = true;
            label_MinHR.Location = new Point(423, 328);
            label_MinHR.Name = "label_MinHR";
            label_MinHR.Size = new Size(121, 15);
            label_MinHR.TabIndex = 34;
            label_MinHR.Text = "Minimum Heart Rate:";
            // 
            // label_MaxHR
            // 
            label_MaxHR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_MaxHR.AutoSize = true;
            label_MaxHR.Location = new Point(256, 328);
            label_MaxHR.Name = "label_MaxHR";
            label_MaxHR.Size = new Size(91, 15);
            label_MaxHR.TabIndex = 33;
            label_MaxHR.Text = "Max Heart Rate:";
            // 
            // label_Distance
            // 
            label_Distance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_Distance.AutoSize = true;
            label_Distance.Location = new Point(256, 264);
            label_Distance.Name = "label_Distance";
            label_Distance.Size = new Size(55, 15);
            label_Distance.TabIndex = 31;
            label_Distance.Text = "Distance:";
            // 
            // label_AverageSpeed
            // 
            label_AverageSpeed.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_AverageSpeed.AutoSize = true;
            label_AverageSpeed.Location = new Point(256, 200);
            label_AverageSpeed.Name = "label_AverageSpeed";
            label_AverageSpeed.Size = new Size(88, 15);
            label_AverageSpeed.TabIndex = 29;
            label_AverageSpeed.Text = "Average Speed:";
            // 
            // comboBox_ExerciseList
            // 
            comboBox_ExerciseList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_ExerciseList.FormattingEnabled = true;
            comboBox_ExerciseList.Location = new Point(256, 36);
            comboBox_ExerciseList.Name = "comboBox_ExerciseList";
            comboBox_ExerciseList.Size = new Size(121, 23);
            comboBox_ExerciseList.TabIndex = 18;
            comboBox_ExerciseList.SelectedIndexChanged += comboBox_ExerciseList_SelectedIndexChanged;
            // 
            // label_AveragePace
            // 
            label_AveragePace.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_AveragePace.AutoSize = true;
            label_AveragePace.Location = new Point(256, 136);
            label_AveragePace.Name = "label_AveragePace";
            label_AveragePace.Size = new Size(81, 15);
            label_AveragePace.TabIndex = 26;
            label_AveragePace.Text = "Average Pace:";
            // 
            // label_Exercise
            // 
            label_Exercise.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_Exercise.AutoSize = true;
            label_Exercise.Location = new Point(256, 8);
            label_Exercise.Name = "label_Exercise";
            label_Exercise.Size = new Size(52, 15);
            label_Exercise.TabIndex = 23;
            label_Exercise.Text = "Exercise:";
            // 
            // label_CaloriesBurned
            // 
            label_CaloriesBurned.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_CaloriesBurned.AutoSize = true;
            label_CaloriesBurned.Location = new Point(256, 72);
            label_CaloriesBurned.Name = "label_CaloriesBurned";
            label_CaloriesBurned.Size = new Size(93, 15);
            label_CaloriesBurned.TabIndex = 22;
            label_CaloriesBurned.Text = "Calories Burned:";
            // 
            // textBox_AvgSpeed
            // 
            textBox_AvgSpeed.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_AvgSpeed.Location = new Point(256, 228);
            textBox_AvgSpeed.Name = "textBox_AvgSpeed";
            textBox_AvgSpeed.Size = new Size(121, 23);
            textBox_AvgSpeed.TabIndex = 21;
            // 
            // textBox_AvgPace
            // 
            textBox_AvgPace.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_AvgPace.Location = new Point(256, 164);
            textBox_AvgPace.Name = "textBox_AvgPace";
            textBox_AvgPace.Size = new Size(121, 23);
            textBox_AvgPace.TabIndex = 20;
            // 
            // textBox_Calories
            // 
            textBox_Calories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Calories.Location = new Point(256, 100);
            textBox_Calories.Name = "textBox_Calories";
            textBox_Calories.Size = new Size(121, 23);
            textBox_Calories.TabIndex = 19;
            // 
            // Form_AddWorkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Add);
            Controls.Add(dateTimePicker_Duration);
            Controls.Add(dateTimePicker_StartTime);
            Controls.Add(dateTimePicker_Date);
            Controls.Add(label_Duration);
            Controls.Add(label_StartTime);
            Controls.Add(label_Date);
            Controls.Add(textBox_MinHR);
            Controls.Add(textBox_MaxHR);
            Controls.Add(textBox_Distance);
            Controls.Add(label_MinHR);
            Controls.Add(label_MaxHR);
            Controls.Add(label_Distance);
            Controls.Add(label_AverageSpeed);
            Controls.Add(comboBox_ExerciseList);
            Controls.Add(label_AveragePace);
            Controls.Add(label_Exercise);
            Controls.Add(label_CaloriesBurned);
            Controls.Add(textBox_AvgSpeed);
            Controls.Add(textBox_AvgPace);
            Controls.Add(textBox_Calories);
            Name = "Form_AddWorkout";
            Text = "Add Workout";
            Load += Form_AddWorkout_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Add;
        private DateTimePicker dateTimePicker_Duration;
        private DateTimePicker dateTimePicker_StartTime;
        private DateTimePicker dateTimePicker_Date;
        private Label label_Duration;
        private Label label_StartTime;
        private Label label_Date;
        private TextBox textBox_MinHR;
        private TextBox textBox_MaxHR;
        private TextBox textBox_Distance;
        private Label label_MinHR;
        private Label label_MaxHR;
        private Label label_Distance;
        private Label label_AverageSpeed;
        private ComboBox comboBox_ExerciseList;
        private Label label_AveragePace;
        private Label label_Exercise;
        private Label label_CaloriesBurned;
        private TextBox textBox_AvgSpeed;
        private TextBox textBox_AvgPace;
        private TextBox textBox_Calories;
    }
}