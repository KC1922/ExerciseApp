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
            panel_steps = new Panel();
            panel_WeekReview.SuspendLayout();
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
            // panel_steps
            // 
            panel_steps.BackColor = Color.FromArgb(238, 229, 233);
            panel_steps.Location = new Point(21, 62);
            panel_steps.Name = "panel_steps";
            panel_steps.Size = new Size(134, 100);
            panel_steps.TabIndex = 1;
            // 
            // Form_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(707, 456);
            Controls.Add(panel_steps);
            Controls.Add(panel_WeekReview);
            Name = "Form_Home";
            Text = "Home";
            panel_WeekReview.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_WeekReview;
        private Label label_WeekInReview;
        private Panel panel_steps;
    }
}