using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_AD
{
    public partial class MemberViewNotifications : Form
    {
     

        public MemberViewNotifications()
        {
            InitializeComponent();

            // Initialize components
            notificationTimer = new System.Windows.Forms.Timer();  // Explicitly reference Timer here as well
            notificationLabel = new Label();
            backButton = new Button();

            // Set properties for the components
            notificationLabel.AutoSize = true;
            notificationLabel.ForeColor = System.Drawing.Color.Red;
            notificationLabel.Visible = false;
            notificationLabel.Location = new System.Drawing.Point(10, 10);  // Set location as needed

            backButton.Text = "Back";
            backButton.Click += backButton_Click;
            backButton.Location = new System.Drawing.Point(10, 40); // Adjust location as needed

            // Add components to the form
            this.Controls.Add(notificationLabel);
            this.Controls.Add(backButton);

            // Set up the timer
            notificationTimer.Interval = 5000;  // 5 seconds
            notificationTimer.Tick += NotificationTimer_Tick;

            // Update the component
            UpdateComponent();
        }

        public void ShowNotification(string message)
        {
            notificationLabel.Text = message;
            notificationLabel.Visible = true;
            notificationTimer.Start();
        }

        private void NotificationTimer_Tick(object sender, EventArgs e)
        {
            notificationLabel.Visible = false;
            notificationTimer.Stop();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Hide the current form and show the MemberLogin form
            this.Hide();
            Application.OpenForms["MemberLogin"].Show();
            this.Close();
        }

    }
}
