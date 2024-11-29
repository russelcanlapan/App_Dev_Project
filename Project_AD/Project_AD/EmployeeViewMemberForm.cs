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
    public partial class EmployeeViewMemberForm : Form
    {
        List<Member> members = new List<Member>();
        public EmployeeViewMemberForm()
        {
            InitializeComponent();
            UpdateComponent();
        }

        private void QueryBtn_Click(object sender, EventArgs e)
        {
            foreach (Member m in members)
            {
                if (m.MemberId == QueryBtn.Text)
                {
                    FNameTB.Text = m.FName;
                    LNameTB.Text = m.LName;
                    StreetNumTB.Text = $"{m.Address.StreetNumber}";
                    StreetNameTB.Text = m.Address.StreetName;
                    CityTB.Text = m.Address.City;
                    ProvinceTB.Text = m.Address.Province;
                    ZipcodeTB.Text = m.Address.ZipCode;
                    PhoneTB.Text = m.PhoneNumber;
                    MembershipTypeTB.Text = m.MembershipType.ToString();
                }
            }
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
