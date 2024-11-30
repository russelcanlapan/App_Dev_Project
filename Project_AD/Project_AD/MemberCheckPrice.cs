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
    public partial class MemberCheckPrice : Form
    {
        public MemberCheckPrice()
        {
            InitializeComponent();
            UpdateComponent();

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Hide the current form (ViewProfile)
            this.Hide();

            // Show the main form (Form1)
            Application.OpenForms["MemberLogin"].Show();

            // Close the current form
            this.Close();
        }
    }
}
