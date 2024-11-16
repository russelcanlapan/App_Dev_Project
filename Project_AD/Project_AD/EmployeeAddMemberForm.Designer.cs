namespace Project_AD
{
    partial class EmployeeAddMemberForm
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
            cancelButton = new Button();
            frequencyTypeGB = new GroupBox();
            yearlyButton = new RadioButton();
            monthlyButton = new RadioButton();
            membershipTypeGB = new GroupBox();
            premiumButton = new RadioButton();
            regularButton = new RadioButton();
            submitButton = new Button();
            zipCodeLabel = new Label();
            provinceLabel = new Label();
            cityLabel = new Label();
            streetNameLabel = new Label();
            streetNumberLabel = new Label();
            phoneNumberLabel = new Label();
            lastNameLabel = new Label();
            firstNameLabel = new Label();
            phoneNumberTB = new TextBox();
            zipcodeTB = new TextBox();
            provinceTB = new TextBox();
            cityTB = new TextBox();
            streetNameTB = new TextBox();
            streetNumberTB = new TextBox();
            lastNameTB = new TextBox();
            firstNameTB = new TextBox();
            signUpLabel = new Label();
            frequencyTypeGB.SuspendLayout();
            membershipTypeGB.SuspendLayout();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(61, 354);
            cancelButton.Margin = new Padding(3, 2, 3, 2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(82, 22);
            cancelButton.TabIndex = 41;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // frequencyTypeGB
            // 
            frequencyTypeGB.Controls.Add(yearlyButton);
            frequencyTypeGB.Controls.Add(monthlyButton);
            frequencyTypeGB.Location = new Point(582, 175);
            frequencyTypeGB.Margin = new Padding(3, 2, 3, 2);
            frequencyTypeGB.Name = "frequencyTypeGB";
            frequencyTypeGB.Padding = new Padding(3, 2, 3, 2);
            frequencyTypeGB.Size = new Size(148, 95);
            frequencyTypeGB.TabIndex = 40;
            frequencyTypeGB.TabStop = false;
            frequencyTypeGB.Text = "Frequency Type";
            // 
            // yearlyButton
            // 
            yearlyButton.AutoSize = true;
            yearlyButton.Location = new Point(5, 49);
            yearlyButton.Margin = new Padding(3, 2, 3, 2);
            yearlyButton.Name = "yearlyButton";
            yearlyButton.Size = new Size(56, 19);
            yearlyButton.TabIndex = 3;
            yearlyButton.TabStop = true;
            yearlyButton.Text = "Yearly";
            yearlyButton.UseVisualStyleBackColor = true;
            // 
            // monthlyButton
            // 
            monthlyButton.AutoSize = true;
            monthlyButton.Location = new Point(5, 23);
            monthlyButton.Margin = new Padding(3, 2, 3, 2);
            monthlyButton.Name = "monthlyButton";
            monthlyButton.Size = new Size(70, 19);
            monthlyButton.TabIndex = 2;
            monthlyButton.TabStop = true;
            monthlyButton.Text = "Monthly";
            monthlyButton.UseVisualStyleBackColor = true;
            // 
            // membershipTypeGB
            // 
            membershipTypeGB.Controls.Add(premiumButton);
            membershipTypeGB.Controls.Add(regularButton);
            membershipTypeGB.Location = new Point(420, 175);
            membershipTypeGB.Margin = new Padding(3, 2, 3, 2);
            membershipTypeGB.Name = "membershipTypeGB";
            membershipTypeGB.Padding = new Padding(3, 2, 3, 2);
            membershipTypeGB.Size = new Size(144, 95);
            membershipTypeGB.TabIndex = 39;
            membershipTypeGB.TabStop = false;
            membershipTypeGB.Text = "Membership Type";
            // 
            // premiumButton
            // 
            premiumButton.AutoSize = true;
            premiumButton.Location = new Point(5, 51);
            premiumButton.Margin = new Padding(3, 2, 3, 2);
            premiumButton.Name = "premiumButton";
            premiumButton.Size = new Size(74, 19);
            premiumButton.TabIndex = 1;
            premiumButton.TabStop = true;
            premiumButton.Text = "Premium";
            premiumButton.UseVisualStyleBackColor = true;
            // 
            // regularButton
            // 
            regularButton.AutoSize = true;
            regularButton.Location = new Point(5, 25);
            regularButton.Margin = new Padding(3, 2, 3, 2);
            regularButton.Name = "regularButton";
            regularButton.Size = new Size(65, 19);
            regularButton.TabIndex = 0;
            regularButton.TabStop = true;
            regularButton.Text = "Regular";
            regularButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(658, 354);
            submitButton.Margin = new Padding(3, 2, 3, 2);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(82, 22);
            submitButton.TabIndex = 38;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Location = new Point(107, 277);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new Size(55, 15);
            zipCodeLabel.TabIndex = 37;
            zipCodeLabel.Text = "Zip Code";
            // 
            // provinceLabel
            // 
            provinceLabel.AutoSize = true;
            provinceLabel.Location = new Point(107, 252);
            provinceLabel.Name = "provinceLabel";
            provinceLabel.Size = new Size(53, 15);
            provinceLabel.TabIndex = 36;
            provinceLabel.Text = "Province";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(107, 227);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(28, 15);
            cityLabel.TabIndex = 35;
            cityLabel.Text = "City";
            // 
            // streetNameLabel
            // 
            streetNameLabel.AutoSize = true;
            streetNameLabel.Location = new Point(107, 202);
            streetNameLabel.Name = "streetNameLabel";
            streetNameLabel.Size = new Size(72, 15);
            streetNameLabel.TabIndex = 34;
            streetNameLabel.Text = "Street Name";
            // 
            // streetNumberLabel
            // 
            streetNumberLabel.AutoSize = true;
            streetNumberLabel.Location = new Point(107, 177);
            streetNumberLabel.Name = "streetNumberLabel";
            streetNumberLabel.Size = new Size(84, 15);
            streetNumberLabel.TabIndex = 33;
            streetNumberLabel.Text = "Street Number";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(107, 301);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(88, 15);
            phoneNumberLabel.TabIndex = 32;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(107, 152);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(63, 15);
            lastNameLabel.TabIndex = 31;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(107, 127);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(64, 15);
            firstNameLabel.TabIndex = 30;
            firstNameLabel.Text = "First Name";
            // 
            // phoneNumberTB
            // 
            phoneNumberTB.Location = new Point(247, 299);
            phoneNumberTB.Margin = new Padding(3, 2, 3, 2);
            phoneNumberTB.Name = "phoneNumberTB";
            phoneNumberTB.Size = new Size(149, 23);
            phoneNumberTB.TabIndex = 29;
            // 
            // zipcodeTB
            // 
            zipcodeTB.Location = new Point(247, 274);
            zipcodeTB.Margin = new Padding(3, 2, 3, 2);
            zipcodeTB.Name = "zipcodeTB";
            zipcodeTB.Size = new Size(149, 23);
            zipcodeTB.TabIndex = 28;
            // 
            // provinceTB
            // 
            provinceTB.Location = new Point(247, 249);
            provinceTB.Margin = new Padding(3, 2, 3, 2);
            provinceTB.Name = "provinceTB";
            provinceTB.Size = new Size(149, 23);
            provinceTB.TabIndex = 27;
            // 
            // cityTB
            // 
            cityTB.Location = new Point(247, 225);
            cityTB.Margin = new Padding(3, 2, 3, 2);
            cityTB.Name = "cityTB";
            cityTB.Size = new Size(149, 23);
            cityTB.TabIndex = 26;
            // 
            // streetNameTB
            // 
            streetNameTB.Location = new Point(247, 200);
            streetNameTB.Margin = new Padding(3, 2, 3, 2);
            streetNameTB.Name = "streetNameTB";
            streetNameTB.Size = new Size(149, 23);
            streetNameTB.TabIndex = 25;
            // 
            // streetNumberTB
            // 
            streetNumberTB.Location = new Point(247, 175);
            streetNumberTB.Margin = new Padding(3, 2, 3, 2);
            streetNumberTB.Name = "streetNumberTB";
            streetNumberTB.Size = new Size(149, 23);
            streetNumberTB.TabIndex = 24;
            // 
            // lastNameTB
            // 
            lastNameTB.Location = new Point(247, 150);
            lastNameTB.Margin = new Padding(3, 2, 3, 2);
            lastNameTB.Name = "lastNameTB";
            lastNameTB.Size = new Size(148, 23);
            lastNameTB.TabIndex = 23;
            // 
            // firstNameTB
            // 
            firstNameTB.Location = new Point(247, 125);
            firstNameTB.Margin = new Padding(3, 2, 3, 2);
            firstNameTB.Name = "firstNameTB";
            firstNameTB.Size = new Size(148, 23);
            firstNameTB.TabIndex = 22;
            // 
            // signUpLabel
            // 
            signUpLabel.AutoSize = true;
            signUpLabel.Location = new Point(377, 74);
            signUpLabel.Name = "signUpLabel";
            signUpLabel.Size = new Size(48, 15);
            signUpLabel.TabIndex = 21;
            signUpLabel.Text = "Sign Up";
            // 
            // EmployeeAddMemberForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
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
            Name = "EmployeeAddMemberForm";
            Text = "EmployeeAddMember";
            frequencyTypeGB.ResumeLayout(false);
            frequencyTypeGB.PerformLayout();
            membershipTypeGB.ResumeLayout(false);
            membershipTypeGB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private GroupBox frequencyTypeGB;
        private RadioButton yearlyButton;
        private RadioButton monthlyButton;
        private GroupBox membershipTypeGB;
        private RadioButton premiumButton;
        private RadioButton regularButton;
        private Button submitButton;
        private Label zipCodeLabel;
        private Label provinceLabel;
        private Label cityLabel;
        private Label streetNameLabel;
        private Label streetNumberLabel;
        private Label phoneNumberLabel;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private TextBox phoneNumberTB;
        private TextBox zipcodeTB;
        private TextBox provinceTB;
        private TextBox cityTB;
        private TextBox streetNameTB;
        private TextBox streetNumberTB;
        private TextBox lastNameTB;
        private TextBox firstNameTB;
        private Label signUpLabel;
    }
}