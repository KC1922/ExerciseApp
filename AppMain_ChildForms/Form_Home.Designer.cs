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
            panel_WeekReview.SuspendLayout();
            panel_WeeklySteps.SuspendLayout();
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
            label_WeeklySteps.Size = new Size(105, 17);
            label_WeeklySteps.TabIndex = 0;
            label_WeeklySteps.Text = "Steps This Week:";
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
            // Form_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(707, 456);
            Controls.Add(panel_WeeklySteps);
            Controls.Add(panel_WeekReview);
            Name = "Form_Home";
            Text = "Home";
            Load += Form_Home_Load;
            panel_WeekReview.ResumeLayout(false);
            panel_WeeklySteps.ResumeLayout(false);
            panel_WeeklySteps.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_WeekReview;
        private Label label_WeekInReview;
        private Panel panel_WeeklySteps;
        private Label label_WeeklySteps;
        private Label label_TotalStepsCount;
    }
}