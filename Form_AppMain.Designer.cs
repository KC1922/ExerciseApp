namespace ExerciseApp
{
    partial class Form_AppMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AppMain));
            panel_SideBar = new Panel();
            button_Steps = new Button();
            imageList_AppMain = new ImageList(components);
            button_Trends = new Button();
            button_Calories = new Button();
            button_AddWorkout = new Button();
            button_Home = new Button();
            panel1 = new Panel();
            label_Title = new Label();
            panel_UpperBar = new Panel();
            label_TabTitle = new Label();
            panel_TabForms = new Panel();
            panel_SideBar.SuspendLayout();
            panel1.SuspendLayout();
            panel_UpperBar.SuspendLayout();
            SuspendLayout();
            // 
            // panel_SideBar
            // 
            panel_SideBar.BackColor = Color.FromArgb(56, 61, 59);
            panel_SideBar.Controls.Add(button_Steps);
            panel_SideBar.Controls.Add(button_Trends);
            panel_SideBar.Controls.Add(button_Calories);
            panel_SideBar.Controls.Add(button_AddWorkout);
            panel_SideBar.Controls.Add(button_Home);
            panel_SideBar.Controls.Add(panel1);
            panel_SideBar.Dock = DockStyle.Left;
            panel_SideBar.Location = new Point(0, 0);
            panel_SideBar.Name = "panel_SideBar";
            panel_SideBar.Size = new Size(181, 511);
            panel_SideBar.TabIndex = 0;
            // 
            // button_Steps
            // 
            button_Steps.BackColor = Color.Transparent;
            button_Steps.FlatAppearance.BorderSize = 0;
            button_Steps.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 79, 76);
            button_Steps.FlatStyle = FlatStyle.Flat;
            button_Steps.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button_Steps.ForeColor = Color.White;
            button_Steps.ImageAlign = ContentAlignment.MiddleLeft;
            button_Steps.ImageIndex = 4;
            button_Steps.ImageList = imageList_AppMain;
            button_Steps.Location = new Point(0, 172);
            button_Steps.Name = "button_Steps";
            button_Steps.Padding = new Padding(5, 0, 0, 0);
            button_Steps.Size = new Size(181, 51);
            button_Steps.TabIndex = 3;
            button_Steps.Text = "Step Tracker";
            button_Steps.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Steps.UseVisualStyleBackColor = false;
            button_Steps.Click += button_Steps_Click;
            // 
            // imageList_AppMain
            // 
            imageList_AppMain.ColorDepth = ColorDepth.Depth32Bit;
            imageList_AppMain.ImageStream = (ImageListStreamer)resources.GetObject("imageList_AppMain.ImageStream");
            imageList_AppMain.TransparentColor = Color.Transparent;
            imageList_AppMain.Images.SetKeyName(0, "Dave_Gandy_home.png");
            imageList_AppMain.Images.SetKeyName(1, "Freepik_calories.png");
            imageList_AppMain.Images.SetKeyName(2, "nawicon_report.png");
            imageList_AppMain.Images.SetKeyName(3, "Smashicons_person.png");
            imageList_AppMain.Images.SetKeyName(4, "Freepik_footsteps.png");
            // 
            // button_Trends
            // 
            button_Trends.BackColor = Color.Transparent;
            button_Trends.FlatAppearance.BorderSize = 0;
            button_Trends.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 79, 76);
            button_Trends.FlatStyle = FlatStyle.Flat;
            button_Trends.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button_Trends.ForeColor = Color.White;
            button_Trends.ImageAlign = ContentAlignment.MiddleLeft;
            button_Trends.ImageIndex = 2;
            button_Trends.ImageList = imageList_AppMain;
            button_Trends.Location = new Point(0, 274);
            button_Trends.Name = "button_Trends";
            button_Trends.Padding = new Padding(5, 0, 0, 0);
            button_Trends.Size = new Size(181, 51);
            button_Trends.TabIndex = 5;
            button_Trends.Text = "Trends";
            button_Trends.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Trends.UseVisualStyleBackColor = false;
            button_Trends.Click += button_Trends_Click;
            // 
            // button_Calories
            // 
            button_Calories.BackColor = Color.Transparent;
            button_Calories.FlatAppearance.BorderSize = 0;
            button_Calories.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 79, 76);
            button_Calories.FlatStyle = FlatStyle.Flat;
            button_Calories.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button_Calories.ForeColor = Color.White;
            button_Calories.ImageAlign = ContentAlignment.MiddleLeft;
            button_Calories.ImageIndex = 1;
            button_Calories.ImageList = imageList_AppMain;
            button_Calories.Location = new Point(0, 223);
            button_Calories.Name = "button_Calories";
            button_Calories.Padding = new Padding(5, 0, 0, 0);
            button_Calories.Size = new Size(181, 51);
            button_Calories.TabIndex = 4;
            button_Calories.Text = "Calorie Tracker";
            button_Calories.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Calories.UseVisualStyleBackColor = false;
            button_Calories.Click += button_Calories_Click;
            // 
            // button_AddWorkout
            // 
            button_AddWorkout.BackColor = Color.Transparent;
            button_AddWorkout.FlatAppearance.BorderSize = 0;
            button_AddWorkout.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 79, 76);
            button_AddWorkout.FlatStyle = FlatStyle.Flat;
            button_AddWorkout.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button_AddWorkout.ForeColor = Color.White;
            button_AddWorkout.ImageAlign = ContentAlignment.MiddleLeft;
            button_AddWorkout.ImageIndex = 3;
            button_AddWorkout.ImageList = imageList_AppMain;
            button_AddWorkout.Location = new Point(0, 121);
            button_AddWorkout.Name = "button_AddWorkout";
            button_AddWorkout.Padding = new Padding(5, 0, 0, 0);
            button_AddWorkout.Size = new Size(181, 51);
            button_AddWorkout.TabIndex = 2;
            button_AddWorkout.Text = "Add Workout";
            button_AddWorkout.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_AddWorkout.UseVisualStyleBackColor = false;
            button_AddWorkout.Click += button_AddWorkout_Click;
            // 
            // button_Home
            // 
            button_Home.BackColor = Color.Transparent;
            button_Home.FlatAppearance.BorderSize = 0;
            button_Home.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 79, 76);
            button_Home.FlatStyle = FlatStyle.Flat;
            button_Home.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button_Home.ForeColor = Color.White;
            button_Home.ImageAlign = ContentAlignment.MiddleLeft;
            button_Home.ImageIndex = 0;
            button_Home.ImageList = imageList_AppMain;
            button_Home.Location = new Point(0, 70);
            button_Home.Name = "button_Home";
            button_Home.Padding = new Padding(5, 0, 0, 0);
            button_Home.Size = new Size(181, 51);
            button_Home.TabIndex = 1;
            button_Home.Text = "Home";
            button_Home.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Home.UseVisualStyleBackColor = false;
            button_Home.Click += button_Home_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 35, 33);
            panel1.Controls.Add(label_Title);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(181, 70);
            panel1.TabIndex = 2;
            // 
            // label_Title
            // 
            label_Title.BackColor = Color.Transparent;
            label_Title.Dock = DockStyle.Fill;
            label_Title.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_Title.ForeColor = Color.White;
            label_Title.Location = new Point(0, 0);
            label_Title.Name = "label_Title";
            label_Title.Size = new Size(181, 70);
            label_Title.TabIndex = 0;
            label_Title.Text = "MyFitness";
            label_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_UpperBar
            // 
            panel_UpperBar.BackColor = Color.FromArgb(139, 58, 112);
            panel_UpperBar.Controls.Add(label_TabTitle);
            panel_UpperBar.Dock = DockStyle.Top;
            panel_UpperBar.Location = new Point(181, 0);
            panel_UpperBar.Name = "panel_UpperBar";
            panel_UpperBar.Size = new Size(723, 70);
            panel_UpperBar.TabIndex = 1;
            // 
            // label_TabTitle
            // 
            label_TabTitle.BackColor = Color.Transparent;
            label_TabTitle.Dock = DockStyle.Fill;
            label_TabTitle.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_TabTitle.ForeColor = Color.White;
            label_TabTitle.Location = new Point(0, 0);
            label_TabTitle.Name = "label_TabTitle";
            label_TabTitle.Size = new Size(723, 70);
            label_TabTitle.TabIndex = 0;
            label_TabTitle.Text = "Welcome Back User";
            label_TabTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_TabForms
            // 
            panel_TabForms.Dock = DockStyle.Fill;
            panel_TabForms.Location = new Point(181, 70);
            panel_TabForms.Name = "panel_TabForms";
            panel_TabForms.Size = new Size(723, 441);
            panel_TabForms.TabIndex = 2;
            // 
            // Form_AppMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 511);
            Controls.Add(panel_TabForms);
            Controls.Add(panel_UpperBar);
            Controls.Add(panel_SideBar);
            Name = "Form_AppMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyFitness";
            FormClosed += Form_AppMain_FormClosed;
            Load += Form_AppMain_Load;
            panel_SideBar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel_UpperBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_SideBar;
        private Panel panel_UpperBar;
        private Panel panel1;
        private Label label_Title;
        private Label label_TabTitle;
        private Button button_Home;
        private ImageList imageList_AppMain;
        private Button button_AddWorkout;
        private Button button_Trends;
        private Button button_Calories;
        private Panel panel_TabForms;
        private Button button_Steps;
    }
}