using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_AD
{
    public partial class MemberLogin : Form
    {
        public int MemberId { get; set; }
        public MemberLogin(int memberId)
        {
            InitializeComponent();
            UpdateComponent();
            MemberId = memberId;
        }

        /*
 * This method retrieves the Member ID from the main form and opens the ViewProfile form with the member's data.
 * If the Member ID is valid, the member's data is fetched from the file, parsed, and displayed in the ViewProfile form.
 * param: sender, e
 * return: N/A
 */

        private void viewProfileButton_Click(object sender, EventArgs e)
        {
            // Reference to the main form (Form1) to get the Member ID TextBox
            Form1 mainForm = Application.OpenForms["Form1"] as Form1;

            if (mainForm != null)
            {
                // Get the Member ID text from the main form's TextBox
                string memberIdText = mainForm.GetMemberIdText(); // Ensure this method is implemented in Form1

                int memberId;

                // Check if the input is a valid integer
                if (int.TryParse(memberIdText, out memberId))
                {
                    string memberLine = FileSystemAPI.GetMemberById(memberId);

                    if (memberLine != null)
                    {
                        // Parse the member's data
                        string[] memberData = memberLine.Split(',');

                        // Create the ViewProfile form
                        ViewProfile viewProfileForm = new ViewProfile();

                        // Use SetMemberData to populate the labels in the correct order
                        viewProfileForm.SetMemberData(
                            memberData[0], // Member ID
                            memberData[1], // First Name
                            memberData[2], // Last Name
                            memberData[3], // Phone Number
                            memberData[4], // Street Number
                            memberData[5], // Street Name
                            memberData[6], // City
                            memberData[7], // Province
                            memberData[8], // Zip Code
                            memberData[9], // Membership Type
                            double.Parse(memberData[10], CultureInfo.InvariantCulture) // Balance
                        );

                        // Show the ViewProfile form
                        this.Hide();
                        viewProfileForm.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Member not found. Please check the Member ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric Member ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Main form not found. Unable to retrieve Member ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            // Hide the MemberLogin form
            this.Hide();

            // Access the main form (Form1)
            Form1 form1 = (Form1)Application.OpenForms["Form1"];

            // Hide the GroupBox in Form1
            form1.memberLoginGB.Visible = false;

            // Show Form1 again
            form1.Show();

            // Close the MemberLogin form
            this.Close();
        }

        private void updateProfileButton_Click(object sender, EventArgs e)
        {
            // Hide the MemberLogin form
            this.Hide();

            // Open the ViewProfile form as a modal dialog
            UpdateProfile updateProfileForm = new UpdateProfile();
            updateProfileForm.ShowDialog();

            // Show MemberLogin again when ViewProfile is closed
            this.Show();
        }

        private void checkPricesButton_Click(object sender, EventArgs e)
        {
            // Hide the MemberLogin form
            this.Hide();

            MemberCheckPrice memberCheckPriceForm = new MemberCheckPrice();

            memberCheckPriceForm.ShowDialog();

            this.Show();
        }

        private void manageMembershipButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            MemberManage memberManageMembershipForm = new MemberManage(MemberId);
            memberManageMembershipForm.ShowDialog();
            
            this.Show();
        }
        
        private void viewNotificationsButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            MemberViewNotifications memberViewNotificationsForm = new MemberViewNotifications();

            memberViewNotificationsForm.ShowDialog();

            this.Show();
        }

        private void makePaymentButton_Click(object sender, EventArgs e)
        {
            // Hide the MemberLogin form
            this.Hide();

            MemberMakePayment memberMakePayment = new MemberMakePayment();

            memberMakePayment.ShowDialog();

            this.Show();

        }
    }
}
