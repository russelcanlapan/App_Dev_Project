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
    public partial class MemberLogin : Form
    {
        public MemberLogin()
        {
            InitializeComponent();
            UpdateComponent();
        }

        private void viewProfileButton_Click(object sender, EventArgs e)
        {
            ViewProfile viewProfile = new ViewProfile();
            viewProfile.ShowDialog();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Show the main form (Form1)
            Application.OpenForms["Form1"].Show();

            // Close the MemberLogin form
            this.Close();
        }
    }
}
