using System.Resources;

namespace Project_AD
{
    partial class UpdateProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProfile));
            backButton = new Button();
            frequencyTypeGB = new GroupBox();
            yearlyRB = new RadioButton();
            monthlyRB = new RadioButton();
            membershipTypeGB = new GroupBox();
            premiumRB = new RadioButton();
            regularRB = new RadioButton();
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
            updateLabel = new Label();
            frequencyTypeGB.SuspendLayout();
            membershipTypeGB.SuspendLayout();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new Point(4, 409);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 41;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // frequencyTypeGB
            // 
            frequencyTypeGB.Controls.Add(yearlyRB);
            frequencyTypeGB.Controls.Add(monthlyRB);
            frequencyTypeGB.Location = new Point(607, 158);
            frequencyTypeGB.Name = "frequencyTypeGB";
            frequencyTypeGB.Size = new Size(169, 123);
            frequencyTypeGB.TabIndex = 40;
            frequencyTypeGB.TabStop = false;
            frequencyTypeGB.Text = "Frequency Type";
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
            // membershipTypeGB
            // 
            membershipTypeGB.Controls.Add(premiumRB);
            membershipTypeGB.Controls.Add(regularRB);
            membershipTypeGB.Location = new Point(422, 158);
            membershipTypeGB.Name = "membershipTypeGB";
            membershipTypeGB.Size = new Size(164, 123);
            membershipTypeGB.TabIndex = 39;
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
            // submitButton
            // 
            submitButton.Location = new Point(694, 409);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(94, 29);
            submitButton.TabIndex = 38;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Location = new Point(64, 294);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new Size(70, 20);
            zipCodeLabel.TabIndex = 37;
            zipCodeLabel.Text = "Zip Code";
            // 
            // provinceLabel
            // 
            provinceLabel.AutoSize = true;
            provinceLabel.Location = new Point(64, 261);
            provinceLabel.Name = "provinceLabel";
            provinceLabel.Size = new Size(65, 20);
            provinceLabel.TabIndex = 36;
            provinceLabel.Text = "Province";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(64, 228);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(34, 20);
            cityLabel.TabIndex = 35;
            cityLabel.Text = "City";
            // 
            // streetNameLabel
            // 
            streetNameLabel.AutoSize = true;
            streetNameLabel.Location = new Point(64, 195);
            streetNameLabel.Name = "streetNameLabel";
            streetNameLabel.Size = new Size(92, 20);
            streetNameLabel.TabIndex = 34;
            streetNameLabel.Text = "Street Name";
            // 
            // streetNumberLabel
            // 
            streetNumberLabel.AutoSize = true;
            streetNumberLabel.Location = new Point(64, 161);
            streetNumberLabel.Name = "streetNumberLabel";
            streetNumberLabel.Size = new Size(106, 20);
            streetNumberLabel.TabIndex = 33;
            streetNumberLabel.Text = "Street Number";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(64, 327);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(108, 20);
            phoneNumberLabel.TabIndex = 32;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(64, 128);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(79, 20);
            lastNameLabel.TabIndex = 31;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(64, 95);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(80, 20);
            firstNameLabel.TabIndex = 30;
            firstNameLabel.Text = "First Name";
            // 
            // phoneNumberTB
            // 
            phoneNumberTB.Location = new Point(224, 324);
            phoneNumberTB.Name = "phoneNumberTB";
            phoneNumberTB.Size = new Size(170, 27);
            phoneNumberTB.TabIndex = 29;
            // 
            // zipcodeTB
            // 
            zipcodeTB.Location = new Point(224, 291);
            zipcodeTB.Name = "zipcodeTB";
            zipcodeTB.Size = new Size(170, 27);
            zipcodeTB.TabIndex = 28;
            // 
            // provinceTB
            // 
            provinceTB.Location = new Point(224, 258);
            provinceTB.Name = "provinceTB";
            provinceTB.Size = new Size(170, 27);
            provinceTB.TabIndex = 27;
            // 
            // cityTB
            // 
            cityTB.Location = new Point(224, 225);
            cityTB.Name = "cityTB";
            cityTB.Size = new Size(170, 27);
            cityTB.TabIndex = 26;
            // 
            // streetNameTB
            // 
            streetNameTB.Location = new Point(224, 192);
            streetNameTB.Name = "streetNameTB";
            streetNameTB.Size = new Size(170, 27);
            streetNameTB.TabIndex = 25;
            // 
            // streetNumberTB
            // 
            streetNumberTB.Location = new Point(224, 158);
            streetNumberTB.Name = "streetNumberTB";
            streetNumberTB.Size = new Size(170, 27);
            streetNumberTB.TabIndex = 24;
            // 
            // lastNameTB
            // 
            lastNameTB.Location = new Point(224, 125);
            lastNameTB.Name = "lastNameTB";
            lastNameTB.Size = new Size(168, 27);
            lastNameTB.TabIndex = 23;
            // 
            // firstNameTB
            // 
            firstNameTB.Location = new Point(224, 92);
            firstNameTB.Name = "firstNameTB";
            firstNameTB.Size = new Size(168, 27);
            firstNameTB.TabIndex = 22;
            // 
            // updateLabel
            // 
            updateLabel.AutoSize = true;
            updateLabel.Location = new Point(373, 24);
            updateLabel.Name = "updateLabel";
            updateLabel.Size = new Size(58, 20);
            updateLabel.TabIndex = 21;
            updateLabel.Text = "Update";
            // 
            // UpdateProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(backButton);
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
            Controls.Add(updateLabel);
            Name = "UpdateProfile";
            Text = "UpdateProfile";
            frequencyTypeGB.ResumeLayout(false);
            frequencyTypeGB.PerformLayout();
            membershipTypeGB.ResumeLayout(false);
            membershipTypeGB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public void UpdateComponent()
        {
            ResourceManager rm = new ResourceManager("Project_AD.Resources.Resources", typeof(Program).Assembly);

            updateLabel.Text = rm.GetString("updateProfileButton");
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
            backButton.Text = rm.GetString("backButton");
        }

        private Button backButton;
        private GroupBox frequencyTypeGB;
        private RadioButton yearlyRB;
        private RadioButton monthlyRB;
        private GroupBox membershipTypeGB;
        private RadioButton premiumRB;
        private RadioButton regularRB;
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
        private Label updateLabel;
    }
}