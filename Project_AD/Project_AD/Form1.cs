using System.Globalization;
using System.Resources;

namespace Project_AD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            memberLoginGB.Visible = false;
            employeeLoginGB.Visible = false;
        }

        private void languageButton_Click(object sender, EventArgs e)
        {
            ResourceManager rm = new ResourceManager("Project_AD.Resources.Resources", typeof(Program).Assembly);

            if (Thread.CurrentThread.CurrentUICulture.Name == "en-US")
            {
                CultureInfo culture = new CultureInfo("fr-FR");
                Thread.CurrentThread.CurrentCulture = culture;
                Thread.CurrentThread.CurrentUICulture = culture;
            }
            else
            {
                CultureInfo culture = new CultureInfo("en-US");
                Thread.CurrentThread.CurrentCulture = culture;
                Thread.CurrentThread.CurrentUICulture = culture;
            }
            UpdateComponent();
        }

        /// <summary>
        /// Program close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginMemberButton_Click(object sender, EventArgs e)
        {
            // Hide the employee login group box if it's visible
            employeeLoginGB.Visible = false;

            // Show the member login group box
            memberLoginGB.Visible = true;
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            SignUp.IsOpenedFromEmployeeLogin = false;
            // Hide Form1
            this.Hide();

            // Open SignUp form
            SignUp signUpForm = new SignUp();
            signUpForm.ShowDialog();

            // Show Form1 again when MemberLogin is closed
            this.Show();
        }

        private void loginEmployeeButton_Click(object sender, EventArgs e)
        {
            // Hide the member login group box if it's visible
            memberLoginGB.Visible = false;

            // Show the employee login group box
            employeeLoginGB.Visible = true;

            // You can also create and show the EmployeeLogin form here if needed
            EmployeeLogin employeeForm = new EmployeeLogin();
        }

        /*
 * This method checks if the entered Member ID is valid and attempts to retrieve the member's data.
 * If the member is found, the MemberLogin form is opened with the member's ID.
 * param: sender, e
 * return: N/A
 */

        private void submitButton_Click(object sender, EventArgs e)
        {
            int memberId;

            // Check if the input is a valid integer
            if (int.TryParse(memberIdTB.Text, out memberId))
            {
                // Retrieve the member data from the file
                string memberData = FileSystemAPI.GetMemberById(memberId);

                if (memberData != null)
                {
                    // Hide Form1
                    this.Hide();

                    // Open MemberLogin form
                    MemberLogin memberLogin = new MemberLogin(int.Parse(memberIdTB.Text));
                    memberLogin.ShowDialog();

                    // Clear the TextBox after submit
                    memberIdTB.Text = string.Empty;

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
        /*
 * This method checks if the entered Employee ID is valid and attempts to retrieve the employee's data.
 * If the employee is found, the EmployeeLogin form is opened with the employee's information.
 * param: sender, e
 * return: N/A
 */
        private void employeeSubmitButton_Click(object sender, EventArgs e)
        {
            int employeeId;

            // Check if the input is a valid integer
            if (int.TryParse(employeeIdTB.Text, out employeeId))
            {
                // Retrieve the employee data from the file or database
                Employee employee = FileSystemAPI.GetEmployeeById(employeeId);

                if (employee != null)
                {
                    // Hide Form1
                    this.Hide();

                    // Open EmployeeLogin form
                    EmployeeLogin employeeLogin = new EmployeeLogin();

                    employeeLogin.SetEmployee(employee);

                    employeeLogin.ShowDialog();

                    // Clear the TextBox after submit
                    employeeIdTB.Text = string.Empty;

                    // Show Form1 again when EmployeeLogin is closed
                    this.Show();
                }
                else
                {
                    // Show a message if the Employee ID is not found
                    MessageBox.Show("Invalid Employee ID. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Show a message to the user if the input is not a number
                MessageBox.Show("Please enter a valid numeric Employee ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
