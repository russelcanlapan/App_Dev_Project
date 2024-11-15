using System.Globalization;
using System.Resources;

namespace Project_AD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            MemberLogin memberLoginForm = new MemberLogin();
            memberLoginForm.Show(); // This opens the form in a non-blocking way
        }
    }
}
