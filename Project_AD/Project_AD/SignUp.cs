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

            membershipType = regularRB.Checked ? MembershipType.Regular : MembershipType.Premium;
            string frequencyType = monthlyRB.Checked ? "Monthly" : "Yearly";


            // Create a new User instance
            Member newUser = new Member(firstNameTB.Text, lastNameTB.Text, phoneNumberTB.Text, 
                new Address(int.Parse(streetNumberTB.Text), streetNameTB.Text,
                cityTB.Text, provinceTB.Text, zipcodeTB.Text), membership, membership.GetPrice(frequencyType));

            MessageBox.Show($"Sign-up complete!\nYour Member ID is: {newUser.MemberId}");
            this.Close();
        }

        private void backlButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Show the main form (Form1)
            Application.OpenForms["Form1"].Show();

            // Close the MemberLogin form
            this.Close();
        }
    }
}
