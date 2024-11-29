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
    public partial class EmployeeRemoveMemberForm : Form
    {
        public EmployeeRemoveMemberForm()
        {
            InitializeComponent();
            UpdateComponent();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            FileSystemAPI.RemoveMember(int.Parse(MemberIdTB.Text));
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Hide the current form (ViewMemberProfile)
            this.Hide();

            // Show the employee form
            Application.OpenForms["EmployeeLogin"].Show();

            // Close the current form
            this.Close();
        }
    }
}
