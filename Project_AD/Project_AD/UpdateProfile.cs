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
    public partial class UpdateProfile : Form
    {
        public static bool IsOpenedFromEmployeeLogin = false;
        private int memberId;

        public UpdateProfile()
        {
            InitializeComponent();
            UpdateComponent();

            this.memberId = memberId;
            LoadMemberData();
        }

        private void LoadMemberData()
        {
            string memberData = FileSystemAPI.GetMemberById(memberId);
            if (memberData != null)
            {
                string[] data = memberData.Split(',');

                // Populate the textboxes or labels with the existing member data
                firstNameTB.Text = data[1];
                lastNameTB.Text = data[2];
                streetNumberTB.Text = data[4];
                streetNameTB.Text = data[5];
                cityTB.Text = data[6];
                provinceTB.Text = data[7];
                zipcodeTB.Text = data[8];
                phoneNumberTB.Text = data[9];

                // Set radio buttons for membership type
                if (data[10] == "Regular")
                    regularRB.Checked = true;
                else if (data[10] == "Premium")
                    premiumRB.Checked = true;

                // Set frequency type
                if (data[11] == "Monthly")
                    monthlyRB.Checked = true;
                else if (data[11] == "Yearly")
                    yearlyRB.Checked = true;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
    {
        // Retrieve the updated values from the textboxes and radio buttons
        string firstName = firstNameTB.Text;
        string lastName = lastNameTB.Text;
        string phoneNumber = phoneNumberTB.Text;
        int streetNumber = int.Parse(streetNumberTB.Text);
        string streetName = streetNameTB.Text;
        string city = cityTB.Text;
        string province = provinceTB.Text;
        string zipCode = zipcodeTB.Text;
        string membershipType = regularRB.Checked ? "Regular" : "Premium";
        string frequencyType = monthlyRB.Checked ? "Monthly" : "Yearly";
        double balance = (membershipType == "Regular" && frequencyType == "Monthly") ? 19.99 :
                         (membershipType == "Regular" && frequencyType == "Yearly") ? 259.75 :
                         (membershipType == "Premium" && frequencyType == "Monthly") ? 29.99 : 389.75;

        // Update the member information in the file
        FileSystemAPI.UpdateMember(memberId, firstName, lastName, phoneNumber, streetNumber, streetName, city, province, zipCode, membershipType, balance);
    }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Hide the current form (ViewProfile)
            this.Hide();

            if (SignUp.IsOpenedFromEmployeeLogin)
            {
                // If opened from Employee Login, go back to Employee Login
                if (EmployeeLogin.ActiveForm != null)
                {
                    Application.OpenForms["EmployeeLogin"].Show();
                }
            }
            else
            {
                // If opened from Form1, go back to Form1
                if (MemberLogin.ActiveForm != null)
                {
                    Application.OpenForms["MemberLogin"].Show();
                }
            }

            // Close the current form
            this.Close();
        }
    }
}
