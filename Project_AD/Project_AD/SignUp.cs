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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            UpdateComponent();

            regularRB.Checked = true;
            monthlyRB.Checked = true;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            MembershipType membershipType = new MembershipType();
            Membership membership = new Membership(membershipType);
            string frequencyType = "";

            if (regularRB.Checked) {
                if (monthlyRB.Checked)
                {
                    frequencyType = "monthly";
                }
                else if (yearlyRB.Checked)
                {
                    frequencyType = "yearly";
                }
            } 
            else if (premiumRB.Checked) {
                membershipType = MembershipType.Premium;
                if (monthlyRB.Checked)
                {
                    frequencyType = "monthly";
                }
                else if (yearlyRB.Checked)
                {
                    frequencyType = "yearly";
                }
            }
            // Create a new User instance
            Member newUser = new Member(firstNameTB.Text, lastNameTB.Text,
                new Address(int.Parse(streetNumberTB.Text), streetNameTB.Text,
                cityTB.Text, provinceTB.Text, zipcodeTB.Text), phoneNumberTB.Text, membership, membership.GetPrice(frequencyType));

            // Save the member information to the file
            FileSystemAPI.SaveMember(
                int.Parse(newUser.MemberId), newUser.FName, newUser.LName, newUser.PhoneNumber,
                newUser.Address.StreetNumber, newUser.Address.StreetName, newUser.Address.City,
                newUser.Address.Province, newUser.Address.ZipCode, membershipType.ToString(),
                newUser.Balance);

            // Display confirmation or handle the user object as needed
            MessageBox.Show("User information saved successfully.\n Member ID: " + newUser.MemberId);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Show the main form (Form1)
            Application.OpenForms["Form1"].Show();

            // Close the MemberLogin form
            this.Close();
        }
    }
}
