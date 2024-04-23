namespace ExerciseApp.AppMain_ChildForms
{
    partial class Form_StepTracker
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
            button_AddSteps = new Button();
            label_TotalSteps = new Label();
            label_TotalStepsCount = new Label();
            panel_TotalSteps = new Panel();
            panel_PreviousEntry = new Panel();
            label_PreviousEntry = new Label();
            label_PreviousStepsCount = new Label();
            panel_MostSteps = new Panel();
            label_Record = new Label();
            label_RecordCount = new Label();
            panel_Progress = new Panel();
            label_CurrentDaily = new Label();
            label_DayProgress = new Label();
            panel_TotalSteps.SuspendLayout();
            panel_PreviousEntry.SuspendLayout();
            panel_MostSteps.SuspendLayout();
            panel_Progress.SuspendLayout();
            SuspendLayout();
            // 
            // button_AddSteps
            // 
            button_AddSteps.BackColor = Color.FromArgb(140, 33, 85);
            button_AddSteps.FlatStyle = FlatStyle.Flat;
            button_AddSteps.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_AddSteps.ForeColor = Color.White;
            button_AddSteps.Location = new Point(320, 339);
            button_AddSteps.Name = "button_AddSteps";
            button_AddSteps.Size = new Size(160, 71);
            button_AddSteps.TabIndex = 0;
            button_AddSteps.Text = "Log Steps";
            button_AddSteps.UseVisualStyleBackColor = false;
            // 
            // label_TotalSteps
            // 
            label_TotalSteps.AutoSize = true;
            label_TotalSteps.Dock = DockStyle.Left;
            label_TotalSteps.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_TotalSteps.Location = new Point(0, 0);
            label_TotalSteps.Name = "label_TotalSteps";
            label_TotalSteps.Size = new Size(76, 17);
            label_TotalSteps.TabIndex = 0;
            label_TotalSteps.Text = "Total Steps:";
            // 
            // label_TotalStepsCount
            // 
            label_TotalStepsCount.Dock = DockStyle.Fill;
            label_TotalStepsCount.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_TotalStepsCount.Location = new Point(0, 0);
            label_TotalStepsCount.Margin = new Padding(0);
            label_TotalStepsCount.Name = "label_TotalStepsCount";
            label_TotalStepsCount.Size = new Size(241, 100);
            label_TotalStepsCount.TabIndex = 1;
            label_TotalStepsCount.Text = "100";
            label_TotalStepsCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_TotalSteps
            // 
            panel_TotalSteps.BackColor = Color.FromArgb(238, 229, 233);
            panel_TotalSteps.Controls.Add(label_TotalSteps);
            panel_TotalSteps.Controls.Add(label_TotalStepsCount);
            panel_TotalSteps.Location = new Point(23, 12);
            panel_TotalSteps.Name = "panel_TotalSteps";
            panel_TotalSteps.Size = new Size(241, 100);
            panel_TotalSteps.TabIndex = 2;
            // 
            // panel_PreviousEntry
            // 
            panel_PreviousEntry.BackColor = Color.FromArgb(238, 229, 233);
            panel_PreviousEntry.Controls.Add(label_PreviousEntry);
            panel_PreviousEntry.Controls.Add(label_PreviousStepsCount);
            panel_PreviousEntry.Location = new Point(280, 12);
            panel_PreviousEntry.Name = "panel_PreviousEntry";
            panel_PreviousEntry.Size = new Size(241, 100);
            panel_PreviousEntry.TabIndex = 3;
            // 
            // label_PreviousEntry
            // 
            label_PreviousEntry.AutoSize = true;
            label_PreviousEntry.BackColor = Color.FromArgb(124, 124, 124);
            label_PreviousEntry.Dock = DockStyle.Left;
            label_PreviousEntry.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_PreviousEntry.ForeColor = Color.White;
            label_PreviousEntry.Location = new Point(0, 0);
            label_PreviousEntry.Name = "label_PreviousEntry";
            label_PreviousEntry.Size = new Size(66, 17);
            label_PreviousEntry.TabIndex = 0;
            label_PreviousEntry.Text = "Last Entry:";
            // 
            // label_PreviousStepsCount
            // 
            label_PreviousStepsCount.BackColor = Color.FromArgb(124, 124, 124);
            label_PreviousStepsCount.Dock = DockStyle.Fill;
            label_PreviousStepsCount.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_PreviousStepsCount.ForeColor = Color.White;
            label_PreviousStepsCount.Location = new Point(0, 0);
            label_PreviousStepsCount.Margin = new Padding(0);
            label_PreviousStepsCount.Name = "label_PreviousStepsCount";
            label_PreviousStepsCount.Size = new Size(241, 100);
            label_PreviousStepsCount.TabIndex = 1;
            label_PreviousStepsCount.Text = "100";
            label_PreviousStepsCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_MostSteps
            // 
            panel_MostSteps.BackColor = Color.FromArgb(238, 229, 233);
            panel_MostSteps.Controls.Add(label_Record);
            panel_MostSteps.Controls.Add(label_RecordCount);
            panel_MostSteps.Location = new Point(537, 12);
            panel_MostSteps.Name = "panel_MostSteps";
            panel_MostSteps.Size = new Size(241, 100);
            panel_MostSteps.TabIndex = 4;
            // 
            // label_Record
            // 
            label_Record.AutoSize = true;
            label_Record.BackColor = Color.FromArgb(146, 220, 229);
            label_Record.Dock = DockStyle.Left;
            label_Record.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_Record.Location = new Point(0, 0);
            label_Record.Name = "label_Record";
            label_Record.Size = new Size(133, 17);
            label_Record.TabIndex = 0;
            label_Record.Text = "Current Daily Record:";
            // 
            // label_RecordCount
            // 
            label_RecordCount.BackColor = Color.FromArgb(146, 220, 229);
            label_RecordCount.Dock = DockStyle.Fill;
            label_RecordCount.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_RecordCount.Location = new Point(0, 0);
            label_RecordCount.Margin = new Padding(0);
            label_RecordCount.Name = "label_RecordCount";
            label_RecordCount.Size = new Size(241, 100);
            label_RecordCount.TabIndex = 1;
            label_RecordCount.Text = "100";
            label_RecordCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_Progress
            // 
            panel_Progress.BackColor = Color.FromArgb(238, 229, 233);
            panel_Progress.Controls.Add(label_CurrentDaily);
            panel_Progress.Controls.Add(label_DayProgress);
            panel_Progress.Location = new Point(23, 175);
            panel_Progress.Name = "panel_Progress";
            panel_Progress.Size = new Size(755, 100);
            panel_Progress.TabIndex = 4;
            // 
            // label_CurrentDaily
            // 
            label_CurrentDaily.BackColor = Color.FromArgb(124, 124, 124);
            label_CurrentDaily.Dock = DockStyle.Top;
            label_CurrentDaily.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_CurrentDaily.ForeColor = Color.White;
            label_CurrentDaily.Location = new Point(0, 0);
            label_CurrentDaily.Name = "label_CurrentDaily";
            label_CurrentDaily.Size = new Size(755, 17);
            label_CurrentDaily.TabIndex = 0;
            label_CurrentDaily.Text = "Current Daily Progress";
            label_CurrentDaily.TextAlign = ContentAlignment.TopCenter;
            // 
            // label_DayProgress
            // 
            label_DayProgress.BackColor = Color.FromArgb(124, 124, 124);
            label_DayProgress.Dock = DockStyle.Fill;
            label_DayProgress.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_DayProgress.ForeColor = Color.White;
            label_DayProgress.Location = new Point(0, 0);
            label_DayProgress.Margin = new Padding(0);
            label_DayProgress.Name = "label_DayProgress";
            label_DayProgress.Size = new Size(755, 100);
            label_DayProgress.TabIndex = 1;
            label_DayProgress.Text = "0/8000";
            label_DayProgress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form_StepTracker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 215, 219);
            ClientSize = new Size(800, 450);
            Controls.Add(panel_Progress);
            Controls.Add(panel_MostSteps);
            Controls.Add(panel_PreviousEntry);
            Controls.Add(panel_TotalSteps);
            Controls.Add(button_AddSteps);
            Name = "Form_StepTracker";
            Text = "Form_StepTracker";
            panel_TotalSteps.ResumeLayout(false);
            panel_TotalSteps.PerformLayout();
            panel_PreviousEntry.ResumeLayout(false);
            panel_PreviousEntry.PerformLayout();
            panel_MostSteps.ResumeLayout(false);
            panel_MostSteps.PerformLayout();
            panel_Progress.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button_AddSteps;
        private Label label_TotalSteps;
        private Label label_TotalStepsCount;
        private Panel panel_TotalSteps;
        private Panel panel_PreviousEntry;
        private Label label_PreviousEntry;
        private Label label_PreviousStepsCount;
        private Panel panel_MostSteps;
        private Label label_Record;
        private Label label_RecordCount;
        private Panel panel_Progress;
        private Label label_CurrentDaily;
        private Label label_DayProgress;
    }
}