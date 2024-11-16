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
            SuspendLayout();
            // 
            // ViewMemberLabel
            // 
            ViewMemberLabel.AutoSize = true;
            ViewMemberLabel.Location = new Point(386, 34);
            ViewMemberLabel.Name = "ViewMemberLabel";
            ViewMemberLabel.Size = new Size(80, 15);
            ViewMemberLabel.TabIndex = 0;
            ViewMemberLabel.Text = "View Member";
            // 
            // MemberIdTB
            // 
            MemberIdTB.Location = new Point(376, 78);
            MemberIdTB.Name = "MemberIdTB";
            MemberIdTB.Size = new Size(100, 23);
            MemberIdTB.TabIndex = 1;
            // 
            // MemberIdLabel
            // 
            MemberIdLabel.AutoSize = true;
            MemberIdLabel.Location = new Point(302, 81);
            MemberIdLabel.Name = "MemberIdLabel";
            MemberIdLabel.Size = new Size(68, 15);
            MemberIdLabel.TabIndex = 2;
            MemberIdLabel.Text = "Member Id:";
            // 
            // FNameLabel
            // 
            FNameLabel.AutoSize = true;
            FNameLabel.Location = new Point(76, 132);
            FNameLabel.Name = "FNameLabel";
            FNameLabel.Size = new Size(67, 15);
            FNameLabel.TabIndex = 3;
            FNameLabel.Text = "First Name:";
            // 
            // StreetNumLabel
            // 
            StreetNumLabel.AutoSize = true;
            StreetNumLabel.Location = new Point(75, 190);
            StreetNumLabel.Name = "StreetNumLabel";
            StreetNumLabel.Size = new Size(87, 15);
            StreetNumLabel.TabIndex = 4;
            StreetNumLabel.Text = "Street Number:";
            // 
            // StreetNameLabel
            // 
            StreetNameLabel.AutoSize = true;
            StreetNameLabel.Location = new Point(75, 225);
            StreetNameLabel.Name = "StreetNameLabel";
            StreetNameLabel.Size = new Size(75, 15);
            StreetNameLabel.TabIndex = 5;
            StreetNameLabel.Text = "Street Name:";
            // 
            // LNameLabel
            // 
            LNameLabel.AutoSize = true;
            LNameLabel.Location = new Point(76, 156);
            LNameLabel.Name = "LNameLabel";
            LNameLabel.Size = new Size(66, 15);
            LNameLabel.TabIndex = 6;
            LNameLabel.Text = "Last Name:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(76, 259);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(31, 15);
            cityLabel.TabIndex = 7;
            cityLabel.Text = "City:";
            // 
            // provinceLabel
            // 
            provinceLabel.AutoSize = true;
            provinceLabel.Location = new Point(75, 290);
            provinceLabel.Name = "provinceLabel";
            provinceLabel.Size = new Size(56, 15);
            provinceLabel.TabIndex = 8;
            provinceLabel.Text = "Province:";
            // 
            // zipcodeLabel
            // 
            zipcodeLabel.AutoSize = true;
            zipcodeLabel.Location = new Point(75, 322);
            zipcodeLabel.Name = "zipcodeLabel";
            zipcodeLabel.Size = new Size(53, 15);
            zipcodeLabel.TabIndex = 9;
            zipcodeLabel.Text = "Zipcode:";
            // 
            // phoneNumLabel
            // 
            phoneNumLabel.AutoSize = true;
            phoneNumLabel.Location = new Point(75, 351);
            phoneNumLabel.Name = "phoneNumLabel";
            phoneNumLabel.Size = new Size(91, 15);
            phoneNumLabel.TabIndex = 10;
            phoneNumLabel.Text = "Phone Number:";
            // 
            // membershipTypeLabel
            // 
            membershipTypeLabel.AutoSize = true;
            membershipTypeLabel.Location = new Point(75, 380);
            membershipTypeLabel.Name = "membershipTypeLabel";
            membershipTypeLabel.Size = new Size(104, 15);
            membershipTypeLabel.TabIndex = 11;
            membershipTypeLabel.Text = "Membership Type:";
            // 
            // QueryBtn
            // 
            QueryBtn.Location = new Point(493, 77);
            QueryBtn.Name = "QueryBtn";
            QueryBtn.Size = new Size(75, 23);
            QueryBtn.TabIndex = 12;
            QueryBtn.Text = "Query";
            QueryBtn.UseVisualStyleBackColor = true;
            QueryBtn.Click += QueryBtn_Click;
            // 
            // FNameTB
            // 
            FNameTB.Location = new Point(239, 124);
            FNameTB.Name = "FNameTB";
            FNameTB.Size = new Size(131, 23);
            FNameTB.TabIndex = 13;
            // 
            // LNameTB
            // 
            LNameTB.Location = new Point(239, 153);
            LNameTB.Name = "LNameTB";
            LNameTB.Size = new Size(131, 23);
            LNameTB.TabIndex = 14;
            // 
            // StreetNumTB
            // 
            StreetNumTB.Location = new Point(239, 187);
            StreetNumTB.Name = "StreetNumTB";
            StreetNumTB.Size = new Size(131, 23);
            StreetNumTB.TabIndex = 15;
            // 
            // StreetNameTB
            // 
            StreetNameTB.Location = new Point(239, 217);
            StreetNameTB.Name = "StreetNameTB";
            StreetNameTB.Size = new Size(131, 23);
            StreetNameTB.TabIndex = 16;
            // 
            // CityTB
            // 
            CityTB.Location = new Point(239, 251);
            CityTB.Name = "CityTB";
            CityTB.Size = new Size(131, 23);
            CityTB.TabIndex = 17;
            // 
            // ProvinceTB
            // 
            ProvinceTB.Location = new Point(239, 287);
            ProvinceTB.Name = "ProvinceTB";
            ProvinceTB.Size = new Size(131, 23);
            ProvinceTB.TabIndex = 18;
            // 
            // ZipcodeTB
            // 
            ZipcodeTB.Location = new Point(239, 319);
            ZipcodeTB.Name = "ZipcodeTB";
            ZipcodeTB.Size = new Size(131, 23);
            ZipcodeTB.TabIndex = 19;
            // 
            // PhoneTB
            // 
            PhoneTB.Location = new Point(239, 348);
            PhoneTB.Name = "PhoneTB";
            PhoneTB.Size = new Size(131, 23);
            PhoneTB.TabIndex = 20;
            // 
            // MembershipTypeTB
            // 
            MembershipTypeTB.Location = new Point(239, 377);
            MembershipTypeTB.Name = "MembershipTypeTB";
            MembershipTypeTB.Size = new Size(131, 23);
            MembershipTypeTB.TabIndex = 21;
            // 
            // EmployeeViewMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "EmployeeViewMember";
            Text = "EmployeeViewMember";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
    }
}