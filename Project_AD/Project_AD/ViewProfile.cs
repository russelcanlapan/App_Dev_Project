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
        public static bool IsOpenedFromEmployeeLogin = false;
        public static bool IsOpenedFromMemberLogin = false;

        public ViewProfile()
        {
            InitializeComponent();
            UpdateComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (ViewProfile.IsOpenedFromEmployeeLogin)
            {
                // If opened from Employee Login, go back to Employee Login
                if (EmployeeLogin.ActiveForm != null)
                {
                    this.Hide();

                    EmployeeLogin employeeLogin = new EmployeeLogin();
                    employeeLogin.memberLoginGB3.Visible = false;

                    employeeLogin.Show();
                    
                }
            }
            else if (ViewProfile.IsOpenedFromMemberLogin)
            {
                // If opened from Form1, go back to Form1
                if (MemberLogin.ActiveForm != null)
                {
                    this.Hide();

                    MemberLogin memberLogin = (MemberLogin)Application.OpenForms["MemberLogin"];

                    memberLogin.Show();
                }
            }

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
