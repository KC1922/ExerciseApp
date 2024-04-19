using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseApp
{
    public partial class Form_AppMain : Form
    {
        private Button currentButton;
        private Color highlight = Color.FromArgb(198, 52, 149);
        private Form activeForm;
        private string username;
        private int userId;

        public Form_AppMain(string username, int userId)
        {
            InitializeComponent();
            this.username = username;
            this.userId = userId;
            label_TabTitle.Text = "Welcome Back " + username;
        }

        /// <summary>
        /// Sets a button to be highlighted.
        /// </summary>
        private void buttonToHighlighted(object buttonSender)
        {
            if (buttonSender != null)
            {
                if (currentButton != (Button)buttonSender)
                {
                    buttonToDefault();
                    currentButton = (Button)buttonSender;
                    currentButton.BackColor = highlight;
                    currentButton.Font = new Font("Century Gothic", 12.25F, FontStyle.Regular);
                }
            }
        }

        /// <summary>
        /// Resets all buttons on the sidebar to their default style.
        /// </summary>
        private void buttonToDefault()
        {
            foreach (Control button in panel_SideBar.Controls)
            {
                if (button.GetType() == typeof(Button))
                {
                    button.BackColor = Color.Transparent;
                    button.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular);
                }
            }
        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            OpenChildForms(new AppMain_ChildForms.Form_Home(), sender);
        }

        private void button_AddWorkout_Click(object sender, EventArgs e)
        {
            OpenChildForms(new AppMain_ChildForms.Form_AddWorkout(userId), sender);
        }

        private void button_Calories_Click(object sender, EventArgs e)
        {
            OpenChildForms(new AppMain_ChildForms.Form_CalorieTracker(), sender);
        }

        private void button_Trends_Click(object sender, EventArgs e)
        {
            OpenChildForms(new AppMain_ChildForms.Form_Trends(), sender);
        }

        private void Form_AppMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Opens a child form relating the the button the user selected
        /// </summary>
        /// <param name="childForm"></param>
        /// <param name="buttonSender"></param>
        private void OpenChildForms(Form childForm, object buttonSender)
        {
            if (activeForm != null)
            {
                activeForm.Close(); // Close any previous child form
            }

            buttonToHighlighted(buttonSender);

            // Set child form to display in the center panel and open child form
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_TabForms.Controls.Add(childForm);
            this.panel_TabForms.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();

            label_TabTitle.Text = childForm.Text.ToUpper();

        }
    }
}
