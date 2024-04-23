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
            components = new System.ComponentModel.Container();
            button_Add = new Button();
            dateTimePicker_Duration = new DateTimePicker();
            dateTimePicker_StartTime = new DateTimePicker();
            dateTimePicker_Date = new DateTimePicker();
            label_Duration = new Label();
            label_StartTime = new Label();
            label_Date = new Label();
            textBox_MinHR = new TextBox();
            textBox_MaxHR = new TextBox();
            label_MinHR = new Label();
            label_MaxHR = new Label();
            label_Distance = new Label();
            label_AverageSpeed = new Label();
            comboBox_ExerciseList = new ComboBox();
            label_AveragePace = new Label();
            label_Exercise = new Label();
            label_CaloriesBurned = new Label();
            textBox_AvgSpeed = new TextBox();
            textBox_Calories = new TextBox();
            dateTimePicker_avgPace = new DateTimePicker();
            textBox_Distance = new TextBox();
            toolTip_AddWorkoutForm = new ToolTip(components);
            label_Steps = new Label();
            textBox_Steps = new TextBox();
            SuspendLayout();
            // 
            // button_Add
            // 
            button_Add.BackColor = Color.FromArgb(139, 58, 112);
            button_Add.FlatAppearance.BorderColor = Color.White;
            button_Add.FlatStyle = FlatStyle.Flat;
            button_Add.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Add.ForeColor = Color.White;
            button_Add.Location = new Point(113, 342);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(472, 82);
            button_Add.TabIndex = 38;
            button_Add.Text = "Add to Log";
            button_Add.UseVisualStyleBackColor = false;
            button_Add.Click += button_Add_Click;
            // 
            // dateTimePicker_Duration
            // 
            dateTimePicker_Duration.CustomFormat = "HH:mm:ss";
            dateTimePicker_Duration.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker_Duration.Format = DateTimePickerFormat.Custom;
            dateTimePicker_Duration.Location = new Point(475, 290);
            dateTimePicker_Duration.Name = "dateTimePicker_Duration";
            dateTimePicker_Duration.ShowUpDown = true;
            dateTimePicker_Duration.Size = new Size(100, 22);
            dateTimePicker_Duration.TabIndex = 32;
            dateTimePicker_Duration.Value = new DateTime(2024, 4, 16, 0, 0, 0, 0);
            // 
            // dateTimePicker_StartTime
            // 
            dateTimePicker_StartTime.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker_StartTime.Format = DateTimePickerFormat.Time;
            dateTimePicker_StartTime.Location = new Point(475, 220);
            dateTimePicker_StartTime.Name = "dateTimePicker_StartTime";
            dateTimePicker_StartTime.ShowUpDown = true;
            dateTimePicker_StartTime.Size = new Size(100, 22);
            dateTimePicker_StartTime.TabIndex = 30;
            // 
            // dateTimePicker_Date
            // 
            dateTimePicker_Date.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker_Date.Format = DateTimePickerFormat.Short;
            dateTimePicker_Date.Location = new Point(475, 148);
            dateTimePicker_Date.Name = "dateTimePicker_Date";
            dateTimePicker_Date.Size = new Size(100, 22);
            dateTimePicker_Date.TabIndex = 28;
            // 
            // label_Duration
            // 
            label_Duration.AutoSize = true;
            label_Duration.FlatStyle = FlatStyle.Flat;
            label_Duration.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_Duration.ForeColor = Color.FromArgb(139, 58, 112);
            label_Duration.Location = new Point(472, 261);
            label_Duration.Name = "label_Duration";
            label_Duration.Size = new Size(62, 17);
            label_Duration.TabIndex = 37;
            label_Duration.Text = "Duration:";
            // 
            // label_StartTime
            // 
            label_StartTime.AutoSize = true;
            label_StartTime.FlatStyle = FlatStyle.Flat;
            label_StartTime.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_StartTime.ForeColor = Color.FromArgb(139, 58, 112);
            label_StartTime.Location = new Point(472, 189);
            label_StartTime.Name = "label_StartTime";
            label_StartTime.Size = new Size(70, 17);
            label_StartTime.TabIndex = 36;
            label_StartTime.Text = "Start Time:";
            // 
            // label_Date
            // 
            label_Date.AutoSize = true;
            label_Date.FlatStyle = FlatStyle.Flat;
            label_Date.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_Date.ForeColor = Color.FromArgb(139, 58, 112);
            label_Date.Location = new Point(472, 116);
            label_Date.Name = "label_Date";
            label_Date.Size = new Size(110, 17);
            label_Date.TabIndex = 35;
            label_Date.Text = "Date of Workout:";
            // 
            // textBox_MinHR
            // 
            textBox_MinHR.BorderStyle = BorderStyle.None;
            textBox_MinHR.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_MinHR.Location = new Point(299, 221);
            textBox_MinHR.MaxLength = 100;
            textBox_MinHR.Name = "textBox_MinHR";
            textBox_MinHR.Size = new Size(120, 15);
            textBox_MinHR.TabIndex = 27;
            // 
            // textBox_MaxHR
            // 
            textBox_MaxHR.BorderStyle = BorderStyle.None;
            textBox_MaxHR.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_MaxHR.Location = new Point(299, 148);
            textBox_MaxHR.MaxLength = 100;
            textBox_MaxHR.Name = "textBox_MaxHR";
            textBox_MaxHR.Size = new Size(120, 15);
            textBox_MaxHR.TabIndex = 25;
            // 
            // label_MinHR
            // 
            label_MinHR.AutoSize = true;
            label_MinHR.FlatStyle = FlatStyle.Flat;
            label_MinHR.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_MinHR.ForeColor = Color.FromArgb(139, 58, 112);
            label_MinHR.Location = new Point(296, 189);
            label_MinHR.Name = "label_MinHR";
            label_MinHR.Size = new Size(131, 17);
            label_MinHR.TabIndex = 34;
            label_MinHR.Text = "Minimum Heart Rate:";
            // 
            // label_MaxHR
            // 
            label_MaxHR.AutoSize = true;
            label_MaxHR.FlatStyle = FlatStyle.Flat;
            label_MaxHR.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_MaxHR.ForeColor = Color.FromArgb(139, 58, 112);
            label_MaxHR.Location = new Point(296, 116);
            label_MaxHR.Name = "label_MaxHR";
            label_MaxHR.Size = new Size(103, 17);
            label_MaxHR.TabIndex = 33;
            label_MaxHR.Text = "Max Heart Rate:";
            // 
            // label_Distance
            // 
            label_Distance.AutoSize = true;
            label_Distance.FlatStyle = FlatStyle.Flat;
            label_Distance.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_Distance.ForeColor = Color.FromArgb(139, 58, 112);
            label_Distance.Location = new Point(113, 189);
            label_Distance.Name = "label_Distance";
            label_Distance.Size = new Size(64, 17);
            label_Distance.TabIndex = 31;
            label_Distance.Text = "Distance:";
            // 
            // label_AverageSpeed
            // 
            label_AverageSpeed.AutoSize = true;
            label_AverageSpeed.FlatStyle = FlatStyle.Flat;
            label_AverageSpeed.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_AverageSpeed.ForeColor = Color.FromArgb(139, 58, 112);
            label_AverageSpeed.Location = new Point(116, 261);
            label_AverageSpeed.Name = "label_AverageSpeed";
            label_AverageSpeed.Size = new Size(106, 17);
            label_AverageSpeed.TabIndex = 29;
            label_AverageSpeed.Text = "Average Speed:";
            // 
            // comboBox_ExerciseList
            // 
            comboBox_ExerciseList.FlatStyle = FlatStyle.Flat;
            comboBox_ExerciseList.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_ExerciseList.FormattingEnabled = true;
            comboBox_ExerciseList.Location = new Point(113, 61);
            comboBox_ExerciseList.Name = "comboBox_ExerciseList";
            comboBox_ExerciseList.Size = new Size(120, 25);
            comboBox_ExerciseList.TabIndex = 18;
            comboBox_ExerciseList.SelectedIndexChanged += comboBox_ExerciseList_SelectedIndexChanged;
            // 
            // label_AveragePace
            // 
            label_AveragePace.AutoSize = true;
            label_AveragePace.FlatStyle = FlatStyle.Flat;
            label_AveragePace.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_AveragePace.ForeColor = Color.FromArgb(139, 58, 112);
            label_AveragePace.Location = new Point(296, 261);
            label_AveragePace.Name = "label_AveragePace";
            label_AveragePace.Size = new Size(98, 17);
            label_AveragePace.TabIndex = 26;
            label_AveragePace.Text = "Average Pace:";
            // 
            // label_Exercise
            // 
            label_Exercise.AutoSize = true;
            label_Exercise.FlatStyle = FlatStyle.Flat;
            label_Exercise.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_Exercise.ForeColor = Color.FromArgb(139, 58, 112);
            label_Exercise.Location = new Point(110, 29);
            label_Exercise.Name = "label_Exercise";
            label_Exercise.Size = new Size(59, 17);
            label_Exercise.TabIndex = 23;
            label_Exercise.Text = "Exercise:";
            // 
            // label_CaloriesBurned
            // 
            label_CaloriesBurned.AutoSize = true;
            label_CaloriesBurned.FlatStyle = FlatStyle.Flat;
            label_CaloriesBurned.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_CaloriesBurned.ForeColor = Color.FromArgb(139, 58, 112);
            label_CaloriesBurned.Location = new Point(299, 29);
            label_CaloriesBurned.Name = "label_CaloriesBurned";
            label_CaloriesBurned.Size = new Size(103, 17);
            label_CaloriesBurned.TabIndex = 22;
            label_CaloriesBurned.Text = "Calories Burned:";
            // 
            // textBox_AvgSpeed
            // 
            textBox_AvgSpeed.BorderStyle = BorderStyle.None;
            textBox_AvgSpeed.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_AvgSpeed.Location = new Point(119, 293);
            textBox_AvgSpeed.MaxLength = 100;
            textBox_AvgSpeed.Name = "textBox_AvgSpeed";
            textBox_AvgSpeed.Size = new Size(120, 15);
            textBox_AvgSpeed.TabIndex = 21;
            // 
            // textBox_Calories
            // 
            textBox_Calories.BorderStyle = BorderStyle.None;
            textBox_Calories.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Calories.Location = new Point(302, 60);
            textBox_Calories.MaxLength = 100;
            textBox_Calories.Name = "textBox_Calories";
            textBox_Calories.Size = new Size(120, 15);
            textBox_Calories.TabIndex = 19;
            // 
            // dateTimePicker_avgPace
            // 
            dateTimePicker_avgPace.CustomFormat = "HH:mm:ss";
            dateTimePicker_avgPace.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker_avgPace.Format = DateTimePickerFormat.Custom;
            dateTimePicker_avgPace.Location = new Point(299, 290);
            dateTimePicker_avgPace.Name = "dateTimePicker_avgPace";
            dateTimePicker_avgPace.ShowUpDown = true;
            dateTimePicker_avgPace.Size = new Size(120, 22);
            dateTimePicker_avgPace.TabIndex = 39;
            dateTimePicker_avgPace.Value = new DateTime(2024, 4, 16, 0, 0, 0, 0);
            // 
            // textBox_Distance
            // 
            textBox_Distance.BorderStyle = BorderStyle.None;
            textBox_Distance.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Distance.Location = new Point(116, 221);
            textBox_Distance.MaxLength = 100;
            textBox_Distance.Name = "textBox_Distance";
            textBox_Distance.Size = new Size(120, 15);
            textBox_Distance.TabIndex = 24;
            // 
            // label_Steps
            // 
            label_Steps.AutoSize = true;
            label_Steps.FlatStyle = FlatStyle.Flat;
            label_Steps.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_Steps.ForeColor = Color.FromArgb(139, 58, 112);
            label_Steps.Location = new Point(119, 116);
            label_Steps.Name = "label_Steps";
            label_Steps.Size = new Size(44, 17);
            label_Steps.TabIndex = 40;
            label_Steps.Text = "Steps:";
            // 
            // textBox_Steps
            // 
            textBox_Steps.BorderStyle = BorderStyle.None;
            textBox_Steps.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Steps.Location = new Point(116, 148);
            textBox_Steps.MaxLength = 100;
            textBox_Steps.Name = "textBox_Steps";
            textBox_Steps.Size = new Size(120, 15);
            textBox_Steps.TabIndex = 41;
            // 
            // Form_AddWorkout
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 215, 219);
            ClientSize = new Size(707, 456);
            Controls.Add(textBox_Steps);
            Controls.Add(label_Steps);
            Controls.Add(dateTimePicker_avgPace);
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
            Controls.Add(textBox_Calories);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
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
        private Label label_MinHR;
        private Label label_MaxHR;
        private Label label_Distance;
        private Label label_AverageSpeed;
        private ComboBox comboBox_ExerciseList;
        private Label label_AveragePace;
        private Label label_Exercise;
        private Label label_CaloriesBurned;
        private TextBox textBox_AvgSpeed;
        private TextBox textBox_Calories;
        private DateTimePicker dateTimePicker_avgPace;
        private TextBox textBox_Distance;
        private ToolTip toolTip_AddWorkoutForm;
        private Label label_Steps;
        private TextBox textBox_Steps;
    }
}