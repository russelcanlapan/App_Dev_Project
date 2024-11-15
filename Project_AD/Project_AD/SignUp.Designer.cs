using System.Resources;

namespace Project_AD
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            signUpLabel = new Label();
            firstNameTB = new TextBox();
            lastNameTB = new TextBox();
            phoneNumberTB = new TextBox();
            streetNumberTB = new TextBox();
            streetNameTB = new TextBox();
            cityTB = new TextBox();
            provinceTB = new TextBox();
            zipCodeTB = new TextBox();
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            phoneNumberLabel = new Label();
            streetNumberLabel = new Label();
            streetNameLabel = new Label();
            cityLabel = new Label();
            provinceLabel = new Label();
            zipCodeLabel = new Label();
            SuspendLayout();
            // 
            // signUpLabel
            // 
            signUpLabel.AutoSize = true;
            signUpLabel.Location = new Point(373, 36);
            signUpLabel.Name = "signUpLabel";
            signUpLabel.Size = new Size(61, 20);
            signUpLabel.TabIndex = 0;
            signUpLabel.Text = "Sign Up";
            // 
            // firstNameTB
            // 
            firstNameTB.Location = new Point(418, 98);
            firstNameTB.Name = "firstNameTB";
            firstNameTB.Size = new Size(168, 27);
            firstNameTB.TabIndex = 1;
            // 
            // lastNameTB
            // 
            lastNameTB.Location = new Point(418, 131);
            lastNameTB.Name = "lastNameTB";
            lastNameTB.Size = new Size(168, 27);
            lastNameTB.TabIndex = 2;
            // 
            // phoneNumberTB
            // 
            phoneNumberTB.Location = new Point(418, 164);
            phoneNumberTB.Name = "phoneNumberTB";
            phoneNumberTB.Size = new Size(170, 27);
            phoneNumberTB.TabIndex = 3;
            // 
            // streetNumberTB
            // 
            streetNumberTB.Location = new Point(418, 197);
            streetNumberTB.Name = "streetNumberTB";
            streetNumberTB.Size = new Size(170, 27);
            streetNumberTB.TabIndex = 4;
            // 
            // streetNameTB
            // 
            streetNameTB.Location = new Point(418, 264);
            streetNameTB.Name = "streetNameTB";
            streetNameTB.Size = new Size(168, 27);
            streetNameTB.TabIndex = 5;
            // 
            // cityTB
            // 
            cityTB.Location = new Point(418, 297);
            cityTB.Name = "cityTB";
            cityTB.Size = new Size(170, 27);
            cityTB.TabIndex = 6;
            // 
            // provinceTB
            // 
            provinceTB.Location = new Point(418, 231);
            provinceTB.Name = "provinceTB";
            provinceTB.Size = new Size(170, 27);
            provinceTB.TabIndex = 7;
            // 
            // zipCodeTB
            // 
            zipCodeTB.Location = new Point(418, 330);
            zipCodeTB.Name = "zipCodeTB";
            zipCodeTB.Size = new Size(168, 27);
            zipCodeTB.TabIndex = 8;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(258, 101);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(80, 20);
            firstNameLabel.TabIndex = 9;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(258, 134);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(79, 20);
            lastNameLabel.TabIndex = 10;
            lastNameLabel.Text = "Last Name";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(258, 167);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(108, 20);
            phoneNumberLabel.TabIndex = 11;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // streetNumberLabel
            // 
            streetNumberLabel.AutoSize = true;
            streetNumberLabel.Location = new Point(258, 200);
            streetNumberLabel.Name = "streetNumberLabel";
            streetNumberLabel.Size = new Size(106, 20);
            streetNumberLabel.TabIndex = 12;
            streetNumberLabel.Text = "Street Number";
            // 
            // streetNameLabel
            // 
            streetNameLabel.AutoSize = true;
            streetNameLabel.Location = new Point(258, 234);
            streetNameLabel.Name = "streetNameLabel";
            streetNameLabel.Size = new Size(92, 20);
            streetNameLabel.TabIndex = 13;
            streetNameLabel.Text = "Street Name";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(258, 267);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(34, 20);
            cityLabel.TabIndex = 14;
            cityLabel.Text = "City";
            // 
            // provinceLabel
            // 
            provinceLabel.AutoSize = true;
            provinceLabel.Location = new Point(258, 300);
            provinceLabel.Name = "provinceLabel";
            provinceLabel.Size = new Size(65, 20);
            provinceLabel.TabIndex = 15;
            provinceLabel.Text = "Province";
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Location = new Point(258, 333);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new Size(70, 20);
            zipCodeLabel.TabIndex = 16;
            zipCodeLabel.Text = "Zip Code";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(zipCodeLabel);
            Controls.Add(provinceLabel);
            Controls.Add(cityLabel);
            Controls.Add(streetNameLabel);
            Controls.Add(streetNumberLabel);
            Controls.Add(phoneNumberLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(zipCodeTB);
            Controls.Add(provinceTB);
            Controls.Add(cityTB);
            Controls.Add(streetNameTB);
            Controls.Add(streetNumberTB);
            Controls.Add(phoneNumberTB);
            Controls.Add(lastNameTB);
            Controls.Add(firstNameTB);
            Controls.Add(signUpLabel);
            Name = "SignUp";
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public void UpdateComponent()
        {
            ResourceManager rm = new ResourceManager("Project_AD.Resources.Resources", typeof(Program).Assembly);

            signUpLabel.Text = rm.GetString("signUpLabel");
            firstNameLabel.Text = rm.GetString("firstNameLabel");
            lastNameLabel.Text = rm.GetString("lastNameLabel");
            phoneNumberLabel.Text = rm.GetString("phoneNumberLabel");
            streetNumberLabel.Text = rm.GetString("streetNumberLabel");
            streetNameLabel.Text = rm.GetString("streetNameLabel");
            cityLabel.Text = rm.GetString("cityLabel");
            provinceLabel.Text = rm.GetString("provinceLabel");
            zipCodeLabel.Text = rm.GetString("zipCodeLabel");
        }

        private Label signUpLabel;
        private TextBox firstNameTB;
        private TextBox lastNameTB;
        private TextBox phoneNumberTB;
        private TextBox streetNumberTB;
        private TextBox streetNameTB;
        private TextBox cityTB;
        private TextBox provinceTB;
        private TextBox zipCodeTB;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label phoneNumberLabel;
        private Label streetNumberLabel;
        private Label streetNameLabel;
        private Label cityLabel;
        private Label provinceLabel;
        private Label zipCodeLabel;
    }
}