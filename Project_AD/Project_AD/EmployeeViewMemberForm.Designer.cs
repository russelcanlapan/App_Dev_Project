using System.Resources;

namespace Project_AD
{
    partial class EmployeeViewMemberForm
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
            ViewMemberLabel = new Label();
            MemberIdTB = new TextBox();
            MemberIdLabel = new Label();
            FNameLabel = new Label();
            StreetNumLabel = new Label();
            StreetNameLabel = new Label();
            LNameLabel = new Label();
            cityLabel = new Label();
            provinceLabel = new Label();
            zipcodeLabel = new Label();
            phoneNumLabel = new Label();
            membershipTypeLabel = new Label();
            QueryBtn = new Button();
            FNameTB = new TextBox();
            LNameTB = new TextBox();
            StreetNumTB = new TextBox();
            StreetNameTB = new TextBox();
            CityTB = new TextBox();
            ProvinceTB = new TextBox();
            ZipcodeTB = new TextBox();
            PhoneTB = new TextBox();
            MembershipTypeTB = new TextBox();
            backButton = new Button();
            SuspendLayout();
            // 
            // ViewMemberLabel
            // 
            ViewMemberLabel.AutoSize = true;
            ViewMemberLabel.Location = new Point(441, 45);
            ViewMemberLabel.Name = "ViewMemberLabel";
            ViewMemberLabel.Size = new Size(101, 20);
            ViewMemberLabel.TabIndex = 0;
            ViewMemberLabel.Text = "View Member";
            // 
            // MemberIdTB
            // 
            MemberIdTB.Location = new Point(430, 104);
            MemberIdTB.Margin = new Padding(3, 4, 3, 4);
            MemberIdTB.Name = "MemberIdTB";
            MemberIdTB.Size = new Size(114, 27);
            MemberIdTB.TabIndex = 1;
            // 
            // MemberIdLabel
            // 
            MemberIdLabel.AutoSize = true;
            MemberIdLabel.Location = new Point(345, 108);
            MemberIdLabel.Name = "MemberIdLabel";
            MemberIdLabel.Size = new Size(85, 20);
            MemberIdLabel.TabIndex = 2;
            MemberIdLabel.Text = "Member Id:";
            // 
            // FNameLabel
            // 
            FNameLabel.AutoSize = true;
            FNameLabel.Location = new Point(225, 178);
            FNameLabel.Name = "FNameLabel";
            FNameLabel.Size = new Size(83, 20);
            FNameLabel.TabIndex = 3;
            FNameLabel.Text = "First Name:";
            // 
            // StreetNumLabel
            // 
            StreetNumLabel.AutoSize = true;
            StreetNumLabel.Location = new Point(224, 255);
            StreetNumLabel.Name = "StreetNumLabel";
            StreetNumLabel.Size = new Size(109, 20);
            StreetNumLabel.TabIndex = 4;
            StreetNumLabel.Text = "Street Number:";
            // 
            // StreetNameLabel
            // 
            StreetNameLabel.AutoSize = true;
            StreetNameLabel.Location = new Point(224, 302);
            StreetNameLabel.Name = "StreetNameLabel";
            StreetNameLabel.Size = new Size(95, 20);
            StreetNameLabel.TabIndex = 5;
            StreetNameLabel.Text = "Street Name:";
            // 
            // LNameLabel
            // 
            LNameLabel.AutoSize = true;
            LNameLabel.Location = new Point(225, 210);
            LNameLabel.Name = "LNameLabel";
            LNameLabel.Size = new Size(82, 20);
            LNameLabel.TabIndex = 6;
            LNameLabel.Text = "Last Name:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(225, 347);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(37, 20);
            cityLabel.TabIndex = 7;
            cityLabel.Text = "City:";
            // 
            // provinceLabel
            // 
            provinceLabel.AutoSize = true;
            provinceLabel.Location = new Point(224, 389);
            provinceLabel.Name = "provinceLabel";
            provinceLabel.Size = new Size(68, 20);
            provinceLabel.TabIndex = 8;
            provinceLabel.Text = "Province:";
            // 
            // zipcodeLabel
            // 
            zipcodeLabel.AutoSize = true;
            zipcodeLabel.Location = new Point(224, 431);
            zipcodeLabel.Name = "zipcodeLabel";
            zipcodeLabel.Size = new Size(67, 20);
            zipcodeLabel.TabIndex = 9;
            zipcodeLabel.Text = "Zipcode:";
            // 
            // phoneNumLabel
            // 
            phoneNumLabel.AutoSize = true;
            phoneNumLabel.Location = new Point(224, 470);
            phoneNumLabel.Name = "phoneNumLabel";
            phoneNumLabel.Size = new Size(111, 20);
            phoneNumLabel.TabIndex = 10;
            phoneNumLabel.Text = "Phone Number:";
            // 
            // membershipTypeLabel
            // 
            membershipTypeLabel.AutoSize = true;
            membershipTypeLabel.Location = new Point(224, 509);
            membershipTypeLabel.Name = "membershipTypeLabel";
            membershipTypeLabel.Size = new Size(130, 20);
            membershipTypeLabel.TabIndex = 11;
            membershipTypeLabel.Text = "Membership Type:";
            // 
            // QueryBtn
            // 
            QueryBtn.Location = new Point(563, 103);
            QueryBtn.Margin = new Padding(3, 4, 3, 4);
            QueryBtn.Name = "QueryBtn";
            QueryBtn.Size = new Size(86, 31);
            QueryBtn.TabIndex = 12;
            QueryBtn.Text = "Query";
            QueryBtn.UseVisualStyleBackColor = true;
            QueryBtn.Click += QueryBtn_Click;
            // 
            // FNameTB
            // 
            FNameTB.Location = new Point(411, 167);
            FNameTB.Margin = new Padding(3, 4, 3, 4);
            FNameTB.Name = "FNameTB";
            FNameTB.Size = new Size(238, 27);
            FNameTB.TabIndex = 13;
            // 
            // LNameTB
            // 
            LNameTB.Location = new Point(411, 206);
            LNameTB.Margin = new Padding(3, 4, 3, 4);
            LNameTB.Name = "LNameTB";
            LNameTB.Size = new Size(238, 27);
            LNameTB.TabIndex = 14;
            // 
            // StreetNumTB
            // 
            StreetNumTB.Location = new Point(411, 251);
            StreetNumTB.Margin = new Padding(3, 4, 3, 4);
            StreetNumTB.Name = "StreetNumTB";
            StreetNumTB.Size = new Size(238, 27);
            StreetNumTB.TabIndex = 15;
            // 
            // StreetNameTB
            // 
            StreetNameTB.Location = new Point(411, 291);
            StreetNameTB.Margin = new Padding(3, 4, 3, 4);
            StreetNameTB.Name = "StreetNameTB";
            StreetNameTB.Size = new Size(238, 27);
            StreetNameTB.TabIndex = 16;
            // 
            // CityTB
            // 
            CityTB.Location = new Point(411, 337);
            CityTB.Margin = new Padding(3, 4, 3, 4);
            CityTB.Name = "CityTB";
            CityTB.Size = new Size(238, 27);
            CityTB.TabIndex = 17;
            // 
            // ProvinceTB
            // 
            ProvinceTB.Location = new Point(411, 385);
            ProvinceTB.Margin = new Padding(3, 4, 3, 4);
            ProvinceTB.Name = "ProvinceTB";
            ProvinceTB.Size = new Size(238, 27);
            ProvinceTB.TabIndex = 18;
            // 
            // ZipcodeTB
            // 
            ZipcodeTB.Location = new Point(411, 427);
            ZipcodeTB.Margin = new Padding(3, 4, 3, 4);
            ZipcodeTB.Name = "ZipcodeTB";
            ZipcodeTB.Size = new Size(238, 27);
            ZipcodeTB.TabIndex = 19;
            // 
            // PhoneTB
            // 
            PhoneTB.Location = new Point(411, 466);
            PhoneTB.Margin = new Padding(3, 4, 3, 4);
            PhoneTB.Name = "PhoneTB";
            PhoneTB.Size = new Size(238, 27);
            PhoneTB.TabIndex = 20;
            // 
            // MembershipTypeTB
            // 
            MembershipTypeTB.Location = new Point(411, 505);
            MembershipTypeTB.Margin = new Padding(3, 4, 3, 4);
            MembershipTypeTB.Name = "MembershipTypeTB";
            MembershipTypeTB.Size = new Size(238, 27);
            MembershipTypeTB.TabIndex = 21;
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 559);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 22;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // EmployeeViewMemberForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(backButton);
            Controls.Add(MembershipTypeTB);
            Controls.Add(PhoneTB);
            Controls.Add(ZipcodeTB);
            Controls.Add(ProvinceTB);
            Controls.Add(CityTB);
            Controls.Add(StreetNameTB);
            Controls.Add(StreetNumTB);
            Controls.Add(LNameTB);
            Controls.Add(FNameTB);
            Controls.Add(QueryBtn);
            Controls.Add(membershipTypeLabel);
            Controls.Add(phoneNumLabel);
            Controls.Add(zipcodeLabel);
            Controls.Add(provinceLabel);
            Controls.Add(cityLabel);
            Controls.Add(LNameLabel);
            Controls.Add(StreetNameLabel);
            Controls.Add(StreetNumLabel);
            Controls.Add(FNameLabel);
            Controls.Add(MemberIdLabel);
            Controls.Add(MemberIdTB);
            Controls.Add(ViewMemberLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmployeeViewMemberForm";
            Text = "EmployeeViewMember";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public void UpdateComponent()
        {
            ResourceManager rm = new ResourceManager("Project_AD.Resources.Resources", typeof(Program).Assembly);

            ViewMemberLabel.Text = rm.GetString("viewMemberButton");
            MemberIdLabel.Text = rm.GetString("memberIdLabel");
            FNameLabel.Text = rm.GetString("firstNameLabel");
            LNameLabel.Text = rm.GetString("lastNameLabel");
            StreetNumLabel.Text = rm.GetString("streetNumberLabel");
            StreetNameLabel.Text = rm.GetString("streetNameLabel");
            cityLabel.Text = rm.GetString("cityLabel");
            provinceLabel.Text = rm.GetString("provinceLabel");
            zipcodeLabel.Text = rm.GetString("zipCodeLabel");
            phoneNumLabel.Text = rm.GetString("phoneNumberLabel");
            membershipTypeLabel.Text = rm.GetString("membershipTypeGB");
            backButton.Text = rm.GetString("backButton");

        }

        private Label ViewMemberLabel;
        private TextBox MemberIdTB;
        private Label MemberIdLabel;
        private Label FNameLabel;
        private Label StreetNumLabel;
        private Label StreetNameLabel;
        private Label LNameLabel;
        private Label cityLabel;
        private Label provinceLabel;
        private Label zipcodeLabel;
        private Label phoneNumLabel;
        private Label membershipTypeLabel;
        private Button QueryBtn;
        private TextBox FNameTB;
        private TextBox LNameTB;
        private TextBox StreetNumTB;
        private TextBox StreetNameTB;
        private TextBox CityTB;
        private TextBox ProvinceTB;
        private TextBox ZipcodeTB;
        private TextBox PhoneTB;
        private TextBox MembershipTypeTB;
        private Button backButton;
    }
}