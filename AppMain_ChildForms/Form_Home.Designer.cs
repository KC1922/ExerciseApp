namespace ExerciseApp.AppMain_ChildForms
{
    partial class Form_Home
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
            panel_WeekReview = new Panel();
            label_WeekInReview = new Label();
            panel_WeeklySteps = new Panel();
            label_WeeklySteps = new Label();
            label_TotalStepsCount = new Label();
            panel_Weight = new Panel();
            label_Weight = new Label();
            label_WeightScale = new Label();
            panel_CurrentTrends = new Panel();
            label_CurrentTrends = new Label();
            panel_CaloriesBurned = new Panel();
            label_CaloriesBurned = new Label();
            label_CaloriesTotal = new Label();
            panel_Time = new Panel();
            label_TimeSpent = new Label();
            label_TimeSpentCount = new Label();
            panel_AverageKal = new Panel();
            label_AvgCalories = new Label();
            label_AvgCaloriesCount = new Label();
            panel_AvgTime = new Panel();
            label_AvgTime = new Label();
            label_AbgTimeTimestamp = new Label();
            panel_Goals = new Panel();
            label_Goals = new Label();
            panel_Goal = new Panel();
            label_TrackedGoal = new Label();
            label_TrackedGoalCount = new Label();
            panel_WeekReview.SuspendLayout();
            panel_WeeklySteps.SuspendLayout();
            panel_Weight.SuspendLayout();
            panel_CurrentTrends.SuspendLayout();
            panel_CaloriesBurned.SuspendLayout();
            panel_Time.SuspendLayout();
            panel_AverageKal.SuspendLayout();
            panel_AvgTime.SuspendLayout();
            panel_Goals.SuspendLayout();
            panel_Goal.SuspendLayout();
            SuspendLayout();
            // 
            // panel_WeekReview
            // 
            panel_WeekReview.BackColor = Color.FromArgb(146, 220, 229);
            panel_WeekReview.Controls.Add(label_WeekInReview);
            panel_WeekReview.Location = new Point(12, 12);
            panel_WeekReview.Name = "panel_WeekReview";
            panel_WeekReview.Size = new Size(683, 44);
            panel_WeekReview.TabIndex = 0;
            // 
            // label_WeekInReview
            // 
            label_WeekInReview.Dock = DockStyle.Fill;
            label_WeekInReview.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_WeekInReview.Location = new Point(0, 0);
            label_WeekInReview.Name = "label_WeekInReview";
            label_WeekInReview.Padding = new Padding(50, 0, 0, 0);
            label_WeekInReview.Size = new Size(683, 44);
            label_WeekInReview.TabIndex = 1;
            label_WeekInReview.Text = "Week in Review";
            label_WeekInReview.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel_WeeklySteps
            // 
            panel_WeeklySteps.BackColor = Color.FromArgb(238, 229, 233);
            panel_WeeklySteps.Controls.Add(label_WeeklySteps);
            panel_WeeklySteps.Controls.Add(label_TotalStepsCount);
            panel_WeeklySteps.Location = new Point(12, 62);
            panel_WeeklySteps.Name = "panel_WeeklySteps";
            panel_WeeklySteps.Size = new Size(215, 100);
            panel_WeeklySteps.TabIndex = 3;
            // 
            // label_WeeklySteps
            // 
            label_WeeklySteps.AutoSize = true;
            label_WeeklySteps.Dock = DockStyle.Left;
            label_WeeklySteps.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_WeeklySteps.Location = new Point(0, 0);
            label_WeeklySteps.Name = "label_WeeklySteps";
            label_WeeklySteps.Size = new Size(76, 17);
            label_WeeklySteps.TabIndex = 0;
            label_WeeklySteps.Text = "Total Steps:";
            // 
            // label_TotalStepsCount
            // 
            label_TotalStepsCount.Dock = DockStyle.Fill;
            label_TotalStepsCount.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_TotalStepsCount.Location = new Point(0, 0);
            label_TotalStepsCount.Margin = new Padding(0);
            label_TotalStepsCount.Name = "label_TotalStepsCount";
            label_TotalStepsCount.Size = new Size(215, 100);
            label_TotalStepsCount.TabIndex = 1;
            label_TotalStepsCount.Text = "100";
            label_TotalStepsCount.TextAlign = ContentAlignment.MiddleCenter;
            label_TotalStepsCount.Click += label_TotalStepsCount_Click;
            // 
            // panel_Weight
            // 
            panel_Weight.BackColor = Color.FromArgb(238, 229, 233);
            panel_Weight.Controls.Add(label_Weight);
            panel_Weight.Controls.Add(label_WeightScale);
            panel_Weight.Location = new Point(12, 227);
            panel_Weight.Name = "panel_Weight";
            panel_Weight.Size = new Size(215, 100);
            panel_Weight.TabIndex = 4;
            // 
            // label_Weight
            // 
            label_Weight.AutoSize = true;
            label_Weight.Dock = DockStyle.Left;
            label_Weight.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_Weight.Location = new Point(0, 0);
            label_Weight.Name = "label_Weight";
            label_Weight.Size = new Size(102, 17);
            label_Weight.TabIndex = 0;
            label_Weight.Text = "Current Weight:";
            // 
            // label_WeightScale
            // 
            label_WeightScale.Dock = DockStyle.Fill;
            label_WeightScale.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_WeightScale.Location = new Point(0, 0);
            label_WeightScale.Margin = new Padding(0);
            label_WeightScale.Name = "label_WeightScale";
            label_WeightScale.Size = new Size(215, 100);
            label_WeightScale.TabIndex = 1;
            label_WeightScale.Text = "100";
            label_WeightScale.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_CurrentTrends
            // 
            panel_CurrentTrends.BackColor = Color.FromArgb(146, 220, 229);
            panel_CurrentTrends.Controls.Add(label_CurrentTrends);
            panel_CurrentTrends.Location = new Point(12, 177);
            panel_CurrentTrends.Name = "panel_CurrentTrends";
            panel_CurrentTrends.Size = new Size(683, 44);
            panel_CurrentTrends.TabIndex = 2;
            // 
            // label_CurrentTrends
            // 
            label_CurrentTrends.Dock = DockStyle.Fill;
            label_CurrentTrends.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_CurrentTrends.Location = new Point(0, 0);
            label_CurrentTrends.Name = "label_CurrentTrends";
            label_CurrentTrends.Padding = new Padding(50, 0, 0, 0);
            label_CurrentTrends.Size = new Size(683, 44);
            label_CurrentTrends.TabIndex = 1;
            label_CurrentTrends.Text = "Current Trends";
            label_CurrentTrends.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel_CaloriesBurned
            // 
            panel_CaloriesBurned.BackColor = Color.FromArgb(238, 229, 233);
            panel_CaloriesBurned.Controls.Add(label_CaloriesBurned);
            panel_CaloriesBurned.Controls.Add(label_CaloriesTotal);
            panel_CaloriesBurned.Location = new Point(246, 62);
            panel_CaloriesBurned.Name = "panel_CaloriesBurned";
            panel_CaloriesBurned.Size = new Size(215, 100);
            panel_CaloriesBurned.TabIndex = 4;
            // 
            // label_CaloriesBurned
            // 
            label_CaloriesBurned.AutoSize = true;
            label_CaloriesBurned.Dock = DockStyle.Left;
            label_CaloriesBurned.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_CaloriesBurned.Location = new Point(0, 0);
            label_CaloriesBurned.Name = "label_CaloriesBurned";
            label_CaloriesBurned.Size = new Size(103, 17);
            label_CaloriesBurned.TabIndex = 0;
            label_CaloriesBurned.Text = "Calories Burned:";
            // 
            // label_CaloriesTotal
            // 
            label_CaloriesTotal.Dock = DockStyle.Fill;
            label_CaloriesTotal.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_CaloriesTotal.Location = new Point(0, 0);
            label_CaloriesTotal.Margin = new Padding(0);
            label_CaloriesTotal.Name = "label_CaloriesTotal";
            label_CaloriesTotal.Size = new Size(215, 100);
            label_CaloriesTotal.TabIndex = 1;
            label_CaloriesTotal.Text = "100";
            label_CaloriesTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_Time
            // 
            panel_Time.BackColor = Color.FromArgb(238, 229, 233);
            panel_Time.Controls.Add(label_TimeSpent);
            panel_Time.Controls.Add(label_TimeSpentCount);
            panel_Time.Location = new Point(480, 62);
            panel_Time.Name = "panel_Time";
            panel_Time.Size = new Size(215, 100);
            panel_Time.TabIndex = 5;
            // 
            // label_TimeSpent
            // 
            label_TimeSpent.AutoSize = true;
            label_TimeSpent.Dock = DockStyle.Left;
            label_TimeSpent.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_TimeSpent.Location = new Point(0, 0);
            label_TimeSpent.Name = "label_TimeSpent";
            label_TimeSpent.Size = new Size(92, 17);
            label_TimeSpent.TabIndex = 0;
            label_TimeSpent.Text = "Workout Time:";
            // 
            // label_TimeSpentCount
            // 
            label_TimeSpentCount.Dock = DockStyle.Fill;
            label_TimeSpentCount.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_TimeSpentCount.Location = new Point(0, 0);
            label_TimeSpentCount.Margin = new Padding(0);
            label_TimeSpentCount.Name = "label_TimeSpentCount";
            label_TimeSpentCount.Size = new Size(215, 100);
            label_TimeSpentCount.TabIndex = 1;
            label_TimeSpentCount.Text = "100";
            label_TimeSpentCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_AverageKal
            // 
            panel_AverageKal.BackColor = Color.FromArgb(238, 229, 233);
            panel_AverageKal.Controls.Add(label_AvgCalories);
            panel_AverageKal.Controls.Add(label_AvgCaloriesCount);
            panel_AverageKal.Location = new Point(246, 227);
            panel_AverageKal.Name = "panel_AverageKal";
            panel_AverageKal.Size = new Size(215, 100);
            panel_AverageKal.TabIndex = 5;
            // 
            // label_AvgCalories
            // 
            label_AvgCalories.AutoSize = true;
            label_AvgCalories.Dock = DockStyle.Left;
            label_AvgCalories.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_AvgCalories.Location = new Point(0, 0);
            label_AvgCalories.Name = "label_AvgCalories";
            label_AvgCalories.Size = new Size(159, 17);
            label_AvgCalories.TabIndex = 0;
            label_AvgCalories.Text = "Average Calories Burned:";
            // 
            // label_AvgCaloriesCount
            // 
            label_AvgCaloriesCount.Dock = DockStyle.Fill;
            label_AvgCaloriesCount.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_AvgCaloriesCount.Location = new Point(0, 0);
            label_AvgCaloriesCount.Margin = new Padding(0);
            label_AvgCaloriesCount.Name = "label_AvgCaloriesCount";
            label_AvgCaloriesCount.Size = new Size(215, 100);
            label_AvgCaloriesCount.TabIndex = 1;
            label_AvgCaloriesCount.Text = "100";
            label_AvgCaloriesCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_AvgTime
            // 
            panel_AvgTime.BackColor = Color.FromArgb(238, 229, 233);
            panel_AvgTime.Controls.Add(label_AvgTime);
            panel_AvgTime.Controls.Add(label_AbgTimeTimestamp);
            panel_AvgTime.Location = new Point(480, 227);
            panel_AvgTime.Name = "panel_AvgTime";
            panel_AvgTime.Size = new Size(215, 100);
            panel_AvgTime.TabIndex = 6;
            // 
            // label_AvgTime
            // 
            label_AvgTime.AutoSize = true;
            label_AvgTime.Dock = DockStyle.Left;
            label_AvgTime.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_AvgTime.Location = new Point(0, 0);
            label_AvgTime.Name = "label_AvgTime";
            label_AvgTime.Size = new Size(148, 17);
            label_AvgTime.TabIndex = 0;
            label_AvgTime.Text = "Average Workout Time:";
            // 
            // label_AbgTimeTimestamp
            // 
            label_AbgTimeTimestamp.Dock = DockStyle.Fill;
            label_AbgTimeTimestamp.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_AbgTimeTimestamp.Location = new Point(0, 0);
            label_AbgTimeTimestamp.Margin = new Padding(0);
            label_AbgTimeTimestamp.Name = "label_AbgTimeTimestamp";
            label_AbgTimeTimestamp.Size = new Size(215, 100);
            label_AbgTimeTimestamp.TabIndex = 1;
            label_AbgTimeTimestamp.Text = "100";
            label_AbgTimeTimestamp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_Goals
            // 
            panel_Goals.BackColor = Color.FromArgb(146, 220, 229);
            panel_Goals.Controls.Add(label_Goals);
            panel_Goals.Location = new Point(12, 348);
            panel_Goals.Name = "panel_Goals";
            panel_Goals.Size = new Size(449, 100);
            panel_Goals.TabIndex = 2;
            // 
            // label_Goals
            // 
            label_Goals.Dock = DockStyle.Fill;
            label_Goals.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_Goals.Location = new Point(0, 0);
            label_Goals.Name = "label_Goals";
            label_Goals.Padding = new Padding(50, 0, 0, 0);
            label_Goals.Size = new Size(449, 100);
            label_Goals.TabIndex = 1;
            label_Goals.Text = "Tracked Goal Progress:";
            label_Goals.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel_Goal
            // 
            panel_Goal.BackColor = Color.FromArgb(140, 33, 85);
            panel_Goal.Controls.Add(label_TrackedGoal);
            panel_Goal.Controls.Add(label_TrackedGoalCount);
            panel_Goal.Location = new Point(480, 348);
            panel_Goal.Name = "panel_Goal";
            panel_Goal.Size = new Size(215, 100);
            panel_Goal.TabIndex = 7;
            // 
            // label_TrackedGoal
            // 
            label_TrackedGoal.AutoSize = true;
            label_TrackedGoal.Dock = DockStyle.Left;
            label_TrackedGoal.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_TrackedGoal.ForeColor = SystemColors.ButtonFace;
            label_TrackedGoal.Location = new Point(0, 0);
            label_TrackedGoal.Name = "label_TrackedGoal";
            label_TrackedGoal.Size = new Size(117, 17);
            label_TrackedGoal.TabIndex = 0;
            label_TrackedGoal.Text = "Tracked Goal Title:";
            // 
            // label_TrackedGoalCount
            // 
            label_TrackedGoalCount.Dock = DockStyle.Fill;
            label_TrackedGoalCount.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_TrackedGoalCount.ForeColor = SystemColors.ButtonHighlight;
            label_TrackedGoalCount.Location = new Point(0, 0);
            label_TrackedGoalCount.Margin = new Padding(0);
            label_TrackedGoalCount.Name = "label_TrackedGoalCount";
            label_TrackedGoalCount.Size = new Size(215, 100);
            label_TrackedGoalCount.TabIndex = 1;
            label_TrackedGoalCount.Text = "100";
            label_TrackedGoalCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(707, 456);
            Controls.Add(panel_Goal);
            Controls.Add(panel_Goals);
            Controls.Add(panel_AvgTime);
            Controls.Add(panel_AverageKal);
            Controls.Add(panel_Time);
            Controls.Add(panel_CaloriesBurned);
            Controls.Add(panel_CurrentTrends);
            Controls.Add(panel_Weight);
            Controls.Add(panel_WeeklySteps);
            Controls.Add(panel_WeekReview);
            Name = "Form_Home";
            Text = "Home";
            Load += Form_Home_Load;
            panel_WeekReview.ResumeLayout(false);
            panel_WeeklySteps.ResumeLayout(false);
            panel_WeeklySteps.PerformLayout();
            panel_Weight.ResumeLayout(false);
            panel_Weight.PerformLayout();
            panel_CurrentTrends.ResumeLayout(false);
            panel_CaloriesBurned.ResumeLayout(false);
            panel_CaloriesBurned.PerformLayout();
            panel_Time.ResumeLayout(false);
            panel_Time.PerformLayout();
            panel_AverageKal.ResumeLayout(false);
            panel_AverageKal.PerformLayout();
            panel_AvgTime.ResumeLayout(false);
            panel_AvgTime.PerformLayout();
            panel_Goals.ResumeLayout(false);
            panel_Goal.ResumeLayout(false);
            panel_Goal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_WeekReview;
        private Label label_WeekInReview;
        private Panel panel_WeeklySteps;
        private Label label_WeeklySteps;
        private Label label_TotalStepsCount;
        private Panel panel_Weight;
        private Label label_Weight;
        private Label label_WeightScale;
        private Panel panel_CurrentTrends;
        private Label label_CurrentTrends;
        private Panel panel_CaloriesBurned;
        private Label label_CaloriesBurned;
        private Label label_CaloriesTotal;
        private Panel panel_Time;
        private Label label_TimeSpent;
        private Label label_TimeSpentCount;
        private Panel panel_AverageKal;
        private Label label_AvgCalories;
        private Label label_AvgCaloriesCount;
        private Panel panel_AvgTime;
        private Label label_AvgTime;
        private Label label_AbgTimeTimestamp;
        private Panel panel_Goals;
        private Label label_Goals;
        private Panel panel_Goal;
        private Label label_TrackedGoal;
        private Label label_TrackedGoalCount;
    }
}