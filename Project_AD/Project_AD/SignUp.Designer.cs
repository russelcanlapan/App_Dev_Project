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
            streetNumberTB = new TextBox();
            streetNameTB = new TextBox();
            cityTB = new TextBox();
            provinceTB = new TextBox();
            zipcodeTB = new TextBox();
            phoneNumberTB = new TextBox();
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            phoneNumberLabel = new Label();
            streetNumberLabel = new Label();
            streetNameLabel = new Label();
            cityLabel = new Label();
            provinceLabel = new Label();
            zipCodeLabel = new Label();
            submitButton = new Button();
            membershipTypeGB = new GroupBox();
            premiumRB = new RadioButton();
            regularRB = new RadioButton();
            yearlyRB = new RadioButton();
            monthlyRB = new RadioButton();
            frequencyTypeGB = new GroupBox();
            cancelButton = new Button();
            membershipTypeGB.SuspendLayout();
            frequencyTypeGB.SuspendLayout();
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
            firstNameTB.Location = new Point(224, 104);
            firstNameTB.Name = "firstNameTB";
            firstNameTB.Size = new Size(168, 27);
            firstNameTB.TabIndex = 1;
            // 
            // lastNameTB
            // 
            lastNameTB.Location = new Point(224, 137);
            lastNameTB.Name = "lastNameTB";
            lastNameTB.Size = new Size(168, 27);
            lastNameTB.TabIndex = 2;
            // 
            // streetNumberTB
            // 
            streetNumberTB.Location = new Point(224, 170);
            streetNumberTB.Name = "streetNumberTB";
            streetNumberTB.Size = new Size(170, 27);
            streetNumberTB.TabIndex = 3;
            // 
            // streetNameTB
            // 
            streetNameTB.Location = new Point(224, 204);
            streetNameTB.Name = "streetNameTB";
            streetNameTB.Size = new Size(170, 27);
            streetNameTB.TabIndex = 4;
            // 
            // cityTB
            // 
            cityTB.Location = new Point(224, 237);
            cityTB.Name = "cityTB";
            cityTB.Size = new Size(170, 27);
            cityTB.TabIndex = 5;
            // 
            // provinceTB
            // 
            provinceTB.Location = new Point(224, 270);
            provinceTB.Name = "provinceTB";
            provinceTB.Size = new Size(170, 27);
            provinceTB.TabIndex = 6;
            // 
            // zipcodeTB
            // 
            zipcodeTB.Location = new Point(224, 303);
            zipcodeTB.Name = "zipcodeTB";
            zipcodeTB.Size = new Size(170, 27);
            zipcodeTB.TabIndex = 7;
            // 
            // phoneNumberTB
            // 
            phoneNumberTB.Location = new Point(224, 336);
            phoneNumberTB.Name = "phoneNumberTB";
            phoneNumberTB.Size = new Size(170, 27);
            phoneNumberTB.TabIndex = 8;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(64, 107);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(80, 20);
            firstNameLabel.TabIndex = 9;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(64, 140);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(79, 20);
            lastNameLabel.TabIndex = 10;
            lastNameLabel.Text = "Last Name";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(64, 339);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(108, 20);
            phoneNumberLabel.TabIndex = 11;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // streetNumberLabel
            // 
            streetNumberLabel.AutoSize = true;
            streetNumberLabel.Location = new Point(64, 173);
            streetNumberLabel.Name = "streetNumberLabel";
            streetNumberLabel.Size = new Size(106, 20);
            streetNumberLabel.TabIndex = 12;
            streetNumberLabel.Text = "Street Number";
            // 
            // streetNameLabel
            // 
            streetNameLabel.AutoSize = true;
            streetNameLabel.Location = new Point(64, 207);
            streetNameLabel.Name = "streetNameLabel";
            streetNameLabel.Size = new Size(92, 20);
            streetNameLabel.TabIndex = 13;
            streetNameLabel.Text = "Street Name";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(64, 240);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(34, 20);
            cityLabel.TabIndex = 14;
            cityLabel.Text = "City";
            // 
            // provinceLabel
            // 
            provinceLabel.AutoSize = true;
            provinceLabel.Location = new Point(64, 273);
            provinceLabel.Name = "provinceLabel";
            provinceLabel.Size = new Size(65, 20);
            provinceLabel.TabIndex = 15;
            provinceLabel.Text = "Province";
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Location = new Point(64, 306);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new Size(70, 20);
            zipCodeLabel.TabIndex = 16;
            zipCodeLabel.Text = "Zip Code";
            // 
            // submitButton
            // 
            submitButton.Location = new Point(694, 409);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(94, 29);
            submitButton.TabIndex = 17;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // membershipTypeGB
            // 
            membershipTypeGB.Controls.Add(premiumRB);
            membershipTypeGB.Controls.Add(regularRB);
            membershipTypeGB.Location = new Point(422, 170);
            membershipTypeGB.Name = "membershipTypeGB";
            membershipTypeGB.Size = new Size(164, 127);
            membershipTypeGB.TabIndex = 18;
            membershipTypeGB.TabStop = false;
            membershipTypeGB.Text = "Membership Type";
            // 
            // premiumRB
            // 
            premiumRB.AutoSize = true;
            premiumRB.Location = new Point(6, 70);
            premiumRB.Name = "premiumRB";
            premiumRB.Size = new Size(89, 24);
            premiumRB.TabIndex = 1;
            premiumRB.TabStop = true;
            premiumRB.Text = "Premium";
            premiumRB.UseVisualStyleBackColor = true;
            // 
            // regularRB
            // 
            regularRB.AutoSize = true;
            regularRB.Location = new Point(6, 35);
            regularRB.Name = "regularRB";
            regularRB.Size = new Size(81, 24);
            regularRB.TabIndex = 0;
            regularRB.TabStop = true;
            regularRB.Text = "Regular";
            regularRB.UseVisualStyleBackColor = true;
            // 
            // yearlyRB
            // 
            yearlyRB.AutoSize = true;
            yearlyRB.Location = new Point(6, 67);
            yearlyRB.Name = "yearlyRB";
            yearlyRB.Size = new Size(69, 24);
            yearlyRB.TabIndex = 3;
            yearlyRB.TabStop = true;
            yearlyRB.Text = "Yearly";
            yearlyRB.UseVisualStyleBackColor = true;
            // 
            // monthlyRB
            // 
            monthlyRB.AutoSize = true;
            monthlyRB.Location = new Point(6, 32);
            monthlyRB.Name = "monthlyRB";
            monthlyRB.Size = new Size(84, 24);
            monthlyRB.TabIndex = 2;
            monthlyRB.TabStop = true;
            monthlyRB.Text = "Monthly";
            monthlyRB.UseVisualStyleBackColor = true;
            // 
            // frequencyTypeGB
            // 
            frequencyTypeGB.Controls.Add(yearlyRB);
            frequencyTypeGB.Controls.Add(monthlyRB);
            frequencyTypeGB.Location = new Point(607, 170);
            frequencyTypeGB.Name = "frequencyTypeGB";
            frequencyTypeGB.Size = new Size(169, 127);
            frequencyTypeGB.TabIndex = 19;
            frequencyTypeGB.TabStop = false;
            frequencyTypeGB.Text = "Frequency Type";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(12, 409);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 20;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cancelButton);
            Controls.Add(frequencyTypeGB);
            Controls.Add(membershipTypeGB);
            Controls.Add(submitButton);
            Controls.Add(zipCodeLabel);
            Controls.Add(provinceLabel);
            Controls.Add(cityLabel);
            Controls.Add(streetNameLabel);
            Controls.Add(streetNumberLabel);
            Controls.Add(phoneNumberLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(phoneNumberTB);
            Controls.Add(zipcodeTB);
            Controls.Add(provinceTB);
            Controls.Add(cityTB);
            Controls.Add(streetNameTB);
            Controls.Add(streetNumberTB);
            Controls.Add(lastNameTB);
            Controls.Add(firstNameTB);
            Controls.Add(signUpLabel);
            Name = "SignUp";
            Text = "SignUp";
            membershipTypeGB.ResumeLayout(false);
            membershipTypeGB.PerformLayout();
            frequencyTypeGB.ResumeLayout(false);
            frequencyTypeGB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public void UpdateComponent()
        {
            ResourceManager rm = new ResourceManager("Project_AD.Resources.Resources", typeof(Program).Assembly);

            signUpLabel.Text = rm.GetString("signupButton");
            firstNameLabel.Text = rm.GetString("firstNameLabel");
            lastNameLabel.Text = rm.GetString("lastNameLabel");
            phoneNumberLabel.Text = rm.GetString("phoneNumberLabel");
            streetNumberLabel.Text = rm.GetString("streetNumberLabel");
            streetNameLabel.Text = rm.GetString("streetNameLabel");
            cityLabel.Text = rm.GetString("cityLabel");
            provinceLabel.Text = rm.GetString("provinceLabel");
            zipCodeLabel.Text = rm.GetString("zipCodeLabel");
            submitButton.Text = rm.GetString("submitButton");
            membershipTypeGB.Text = rm.GetString("membershipTypeGB");
            regularRB.Text = rm.GetString("regularRB");
            premiumRB.Text = rm.GetString("premiumRB");
            frequencyTypeGB.Text = rm.GetString("frequencyTypeGB");
            monthlyRB.Text = rm.GetString("monthlyRB");
            yearlyRB.Text = rm.GetString("yearlyRB");
            cancelButton.Text = rm.GetString("cancelButton");
        }

        private Label signUpLabel;
        private TextBox firstNameTB;
        private TextBox lastNameTB;
        private TextBox streetNumberTB;
        private TextBox streetNameTB;
        private TextBox cityTB;
        private TextBox provinceTB;
        private TextBox zipcodeTB;
        private TextBox phoneNumberTB;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label phoneNumberLabel;
        private Label streetNumberLabel;
        private Label streetNameLabel;
        private Label cityLabel;
        private Label provinceLabel;
        private Label zipCodeLabel;
        private Button submitButton;
        private GroupBox membershipTypeGB;
        private RadioButton yearlyRB;
        private RadioButton monthlyRB;
        private RadioButton premiumRB;
        private RadioButton regularRB;
        private GroupBox frequencyTypeGB;
        private Button cancelButton;
    }
}