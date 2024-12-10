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
        /*
 * This method handles the back button click event. It determines where to navigate based on the origin of the form (EmployeeLogin or MemberLogin).
 * If the form was opened from Employee Login, it hides the current form and navigates to EmployeeLogin.
 * If the form was opened from MemberLogin, it hides the current form and navigates to MemberLogin.
 * param: sender, e
 * return: N/A
 */
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
        /*
 * This method sets the member data on the ViewProfile form by assigning the provided values to corresponding labels on the form.
 * It updates the member's information including ID, name, contact details, address, membership type, and balance.
 * param: memberId, firstName, lastName, phoneNumber, streetNumber, streetName, city, province, zipCode, membershipType, balance
 * return: N/A
 */
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
