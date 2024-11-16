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
            memberLoginGB.Visible = true;
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            // Hide Form1
            this.Hide();

            // Open SignUp form
            SignUp signUpForm = new SignUp();
            signUpForm.ShowDialog();

            // Show Form1 again when MemberLogin is closed
            this.Show();
        }

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
                    MemberLogin memberLogin = new MemberLogin();
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
    }
}
