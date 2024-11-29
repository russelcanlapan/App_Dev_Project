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
        }

        public void SetEmployee(Employee employee)
        {
            _employee = employee;
            // Set the EmployeeName label to the employee's full name
            EmployeeName.Text = $"{_employee.FName} {_employee.LName}";
        }

        private void AddMemberBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            EmployeeAddMemberForm employeeAddMemberForm = new EmployeeAddMemberForm();
            employeeAddMemberForm.ShowDialog();

            this.Show();           
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

        private void ViewMemberBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            EmployeeViewMemberForm emp = new EmployeeViewMemberForm();
            emp.ShowDialog();

            this.Show();
        }
    }
}
