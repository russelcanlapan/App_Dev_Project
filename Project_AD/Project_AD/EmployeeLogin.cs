using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_AD
{
    public partial class EmployeeLogin : Form
    {
        Member member;
        Address address;
        List<Member> members;
        Membership membership;
        public Employee _employee;  // Store the employee object

        public EmployeeLogin()
        {
            InitializeComponent();
            memberLoginGB1.Visible = false;
            memberLoginGB2.Visible = false;
            memberLoginGB3.Visible = false;
            UpdateComponent();
        }

        public void SetEmployee(Employee employee)
        {
            _employee = employee;
            // Set the EmployeeName label to the employee's full name
            EmployeeName.Text = $"{_employee.FName} {_employee.LName}";
        }

        private void AddMemberBtn_Click(object sender, EventArgs e)
        {
            SignUp.IsOpenedFromEmployeeLogin = true;

            this.Hide();

            SignUp employeeAddMemberForm = new SignUp();
            employeeAddMemberForm.ShowDialog();

            this.Show();
        }

        private void ViewMemberBtn_Click(object sender, EventArgs e)
        {
            memberLoginGB1.Visible = false;
            memberLoginGB2.Visible = false;
            memberLoginGB3.Visible = true;
        }

        private void UpdateMemberBtn_Click(object sender, EventArgs e)
        {
            memberLoginGB1.Visible = false;
            memberLoginGB2.Visible = true;
            memberLoginGB3.Visible = false;
        }

        private void RemoveMemberBtn_Click(object sender, EventArgs e)
        {
            memberLoginGB1.Visible = true;
            memberLoginGB2.Visible = false;
            memberLoginGB3.Visible = false;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            // Hide the EmployeeLogin form
            this.Hide();

            // Access the main form (Form1)
            Form1 form1 = (Form1)Application.OpenForms["Form1"];

            // Hide the GroupBox in Form1
            form1.employeeLoginGB.Visible = false;

            // Show Form1 again
            form1.Show();

            // Close the MemberLogin form
            this.Close();
        }

        private static bool isValidName(string Name)
        {
            foreach (char c in Name)
            {
                if (!char.IsLetter(c) && c != ' ' && c != '-')
                {
                    return false;
                }
            }
            return true;
        }

        private static bool isValidNumber(string Num)
        {
            foreach (char c in Num)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void memberSubmitButton1_Click(object sender, EventArgs e)
        {
            // Get the Member ID from the textbox
            if (int.TryParse(memberIdTB1.Text, out int memberId))
            {
                // Call the RemoveMember method to delete the member
                FileSystemAPI.RemoveMember(memberId);
            }
            else
            {
                // Show error if the Member ID is not valid
                MessageBox.Show("Please enter a valid Member ID to remove.");
            }
        }

        private void memberSubmitButton2_Click(object sender, EventArgs e)
        {
            int memberId;

            // Check if the input is a valid integer
            if (int.TryParse(memberIdTB2.Text, out memberId))
            {
                // Retrieve the member data from the file
                string memberData = FileSystemAPI.GetMemberById(memberId);

                if (memberData != null)
                {
                    // Hide Form1
                    this.Hide();

                    // Open MemberLogin form
                    UpdateProfile updateProfile = new UpdateProfile();
                    updateProfile.ShowDialog();

                    // Clear the TextBox after submit
                    memberIdTB2.Text = string.Empty;

                    // Show Form1 again when MemberLogin is closed
                    this.Show();
                }
                else
                {
                    // Show a message if the Member ID is not found
                    MessageBox.Show("Invalid Member ID. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Show a message to the user if the input is not a number
                MessageBox.Show("Please enter a valid numeric Member ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void memberSubmitButton3_Click(object sender, EventArgs e)
        {
            ViewProfile viewProfile = new ViewProfile();

            // Get the Member ID from the textbox
            if (int.TryParse(memberIdTB3.Text, out int memberId))
            {
                // Get the member data using the GetMemberById method
                string memberData = FileSystemAPI.GetMemberById(memberId);

                // Check if member data is found
                if (memberData != null)
                {
                    // Split the member data into parts
                    string[] memberDetails = memberData.Split(',');

                    // Display member details in labels (update Label text values)
                    viewProfile.firstNameResultsLabel.Text = memberDetails[1]; // First Name
                    viewProfile.lastNameResultsLabel.Text = memberDetails[2];  // Last Name
                    viewProfile.streetNumResultsLabel.Text = memberDetails[4]; // Street Number
                    viewProfile.streetNameResultsLabel.Text = memberDetails[5]; // Street Name
                    viewProfile.cityResultsLabel.Text = memberDetails[6]; // City
                    viewProfile.provinceResultsLabel.Text = memberDetails[7]; // Province
                    viewProfile.zipcodeResultsLabel.Text = memberDetails[8]; // Zip Code
                    viewProfile.phoneNumResultsLabel.Text = memberDetails[3]; // Phone Number
                    viewProfile.membershipTypeResultsLabel.Text = memberDetails[9]; // Membership Type
                    viewProfile.balanceResultsLabel.Text = $"${memberDetails[10]}"; // Balance (formatted as currency)
                    viewProfile.memberIdResultsLabel.Text = memberDetails[0]; // Member ID

                    this.Hide();

                    viewProfile.ShowDialog();

                    this.Show();
                }
                else
                {
                    // If the member is not found, show an error message
                    MessageBox.Show("Member not found.");
                }
            }
            else
            {
                // Show error if the Member ID is not valid
                MessageBox.Show("Please enter a valid Member ID to view.");
            }
        }

    }
}
