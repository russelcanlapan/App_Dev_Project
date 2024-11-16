﻿using System;
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
    public partial class MemberLogin : Form
    {
        public MemberLogin()
        {
            InitializeComponent();
            UpdateComponent();
        }

        private void viewProfileButton_Click(object sender, EventArgs e)
        {
            // Hide the MemberLogin form
            this.Hide();

            // Open the ViewProfile form as a modal dialog
            ViewProfile viewProfileForm = new ViewProfile();
            viewProfileForm.ShowDialog();

            // Show MemberLogin again when ViewProfile is closed
            this.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            // Hide the MemberLogin form
            this.Hide();

            // Access the main form (Form1)
            Form1 form1 = (Form1)Application.OpenForms["Form1"];

            // Hide the GroupBox in Form1
            form1.memberLoginGB.Visible = false;

            // Show Form1 again
            form1.Show();

            // Close the MemberLogin form
            this.Close();
        }

        private void updateProfileButton_Click(object sender, EventArgs e)
        {
            // Hide the MemberLogin form
            this.Hide();

            // Open the ViewProfile form as a modal dialog
            UpdateProfile updateProfileForm = new UpdateProfile();
            updateProfileForm.ShowDialog();

            // Show MemberLogin again when ViewProfile is closed
            this.Show();
        }
    }
}
