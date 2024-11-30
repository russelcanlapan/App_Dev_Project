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
            this.Hide();

            EmployeeViewMemberForm emp = new EmployeeViewMemberForm();
            emp.ShowDialog();

            this.Show();
        }

        private void UpdateMemberBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            UpdateProfile updateProfile = new UpdateProfile();
            updateProfile.ShowDialog();

            this.Show();
        }

        private void RemoveMemberBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            EmployeeRemoveMemberForm employeeRemoveMemberForm = new EmployeeRemoveMemberForm();
            employeeRemoveMemberForm.ShowDialog();

            this.Show();
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
    }
}
