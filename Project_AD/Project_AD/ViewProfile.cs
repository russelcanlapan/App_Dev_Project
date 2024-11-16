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
    public partial class ViewProfile : Form
    {
        public ViewProfile()
        {
            InitializeComponent();
            UpdateComponent();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            // Hide the current form (ViewProfile)
            this.Hide();

            // Show the main form (Form1)
            Application.OpenForms["MemberLogin"].Show();

            // Close the current form
            this.Close();
        }

        public void SetMemberData(string memberId, string firstName, string lastName, string phoneNumber, string streetNumber, string streetName,
                                    string city, string province, string zipCode, string membershipType, double balance)
        {
            memberIdResultsLabel.Text = memberId;
            firstNameResultsLabel.Text = firstName;
            lastNameResultsLabel.Text = lastName;
            phoneNumResultsLabel.Text = phoneNumber;
            streetNumResultsLabel.Text = streetNumber;
            streetNameResultsLabel.Text = streetName;
            cityResultsLabel.Text = city;
            provinceResultsLabel.Text = province;
            zipcodeResultsLabel.Text = zipCode;
            membershipTypeResultsLabel.Text = membershipType;
            balanceResultsLabel.Text = Convert.ToString(balance);
        }
    }
}
