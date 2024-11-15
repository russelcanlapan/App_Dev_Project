namespace Project_AD
{
    partial class EmployeeLogin
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
            AddMemberBtn = new Button();
            RemoveMemberBtn = new Button();
            UpdateMemberBtn = new Button();
            ViewMemberBtn = new Button();
            FNameTB = new TextBox();
            LNameTB = new TextBox();
            FNameLabel = new Label();
            LNameLabel = new Label();
            AddressGB = new GroupBox();
            ZipcodeTB = new TextBox();
            ZipcodeLabel = new Label();
            ProvinceLabel = new Label();
            ProvinceTB = new TextBox();
            StreetNumberLabel = new Label();
            StreetNumberTB = new TextBox();
            CityLabel = new Label();
            CityTB = new TextBox();
            StreetNameLabel = new Label();
            StreetNameTB = new TextBox();
            PhoneTB = new TextBox();
            PhoneLabel = new Label();
            BalanceTB = new TextBox();
            BalanceLabel = new Label();
            groupBox1 = new GroupBox();
            RegularRB = new RadioButton();
            PremiumRB = new RadioButton();
            FrequencyRB = new GroupBox();
            MonthlyRB = new RadioButton();
            YearlyRB = new RadioButton();
            AddressGB.SuspendLayout();
            groupBox1.SuspendLayout();
            FrequencyRB.SuspendLayout();
            SuspendLayout();
            // 
            // AddMemberBtn
            // 
            AddMemberBtn.Location = new Point(80, 123);
            AddMemberBtn.Name = "AddMemberBtn";
            AddMemberBtn.Size = new Size(122, 23);
            AddMemberBtn.TabIndex = 0;
            AddMemberBtn.Text = "Add Member";
            AddMemberBtn.UseVisualStyleBackColor = true;
            AddMemberBtn.Click += AddMemberBtn_Click;
            // 
            // RemoveMemberBtn
            // 
            RemoveMemberBtn.Location = new Point(80, 163);
            RemoveMemberBtn.Name = "RemoveMemberBtn";
            RemoveMemberBtn.Size = new Size(122, 23);
            RemoveMemberBtn.TabIndex = 1;
            RemoveMemberBtn.Text = "Remove Member";
            RemoveMemberBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateMemberBtn
            // 
            UpdateMemberBtn.Location = new Point(80, 203);
            UpdateMemberBtn.Name = "UpdateMemberBtn";
            UpdateMemberBtn.Size = new Size(122, 23);
            UpdateMemberBtn.TabIndex = 2;
            UpdateMemberBtn.Text = "Update Member";
            UpdateMemberBtn.UseVisualStyleBackColor = true;
            // 
            // ViewMemberBtn
            // 
            ViewMemberBtn.Location = new Point(80, 247);
            ViewMemberBtn.Name = "ViewMemberBtn";
            ViewMemberBtn.Size = new Size(122, 23);
            ViewMemberBtn.TabIndex = 3;
            ViewMemberBtn.Text = "View Member";
            ViewMemberBtn.UseVisualStyleBackColor = true;
            // 
            // FNameTB
            // 
            FNameTB.Location = new Point(404, 54);
            FNameTB.Name = "FNameTB";
            FNameTB.Size = new Size(100, 23);
            FNameTB.TabIndex = 6;
            // 
            // LNameTB
            // 
            LNameTB.Location = new Point(544, 54);
            LNameTB.Name = "LNameTB";
            LNameTB.Size = new Size(100, 23);
            LNameTB.TabIndex = 7;
            // 
            // FNameLabel
            // 
            FNameLabel.AutoSize = true;
            FNameLabel.Location = new Point(404, 36);
            FNameLabel.Name = "FNameLabel";
            FNameLabel.Size = new Size(64, 15);
            FNameLabel.TabIndex = 8;
            FNameLabel.Text = "First Name";
            // 
            // LNameLabel
            // 
            LNameLabel.AutoSize = true;
            LNameLabel.Location = new Point(544, 36);
            LNameLabel.Name = "LNameLabel";
            LNameLabel.Size = new Size(63, 15);
            LNameLabel.TabIndex = 9;
            LNameLabel.Text = "Last Name";
            // 
            // AddressGB
            // 
            AddressGB.Controls.Add(ZipcodeTB);
            AddressGB.Controls.Add(ZipcodeLabel);
            AddressGB.Controls.Add(ProvinceLabel);
            AddressGB.Controls.Add(ProvinceTB);
            AddressGB.Controls.Add(StreetNumberLabel);
            AddressGB.Controls.Add(StreetNumberTB);
            AddressGB.Controls.Add(CityLabel);
            AddressGB.Controls.Add(CityTB);
            AddressGB.Controls.Add(StreetNameLabel);
            AddressGB.Controls.Add(StreetNameTB);
            AddressGB.Location = new Point(394, 83);
            AddressGB.Name = "AddressGB";
            AddressGB.Size = new Size(286, 189);
            AddressGB.TabIndex = 10;
            AddressGB.TabStop = false;
            AddressGB.Text = "Address";
            // 
            // ZipcodeTB
            // 
            ZipcodeTB.Location = new Point(6, 158);
            ZipcodeTB.Name = "ZipcodeTB";
            ZipcodeTB.Size = new Size(100, 23);
            ZipcodeTB.TabIndex = 22;
            // 
            // ZipcodeLabel
            // 
            ZipcodeLabel.AutoSize = true;
            ZipcodeLabel.Location = new Point(10, 140);
            ZipcodeLabel.Name = "ZipcodeLabel";
            ZipcodeLabel.Size = new Size(50, 15);
            ZipcodeLabel.TabIndex = 21;
            ZipcodeLabel.Text = "Zipcode";
            // 
            // ProvinceLabel
            // 
            ProvinceLabel.AutoSize = true;
            ProvinceLabel.Location = new Point(10, 83);
            ProvinceLabel.Name = "ProvinceLabel";
            ProvinceLabel.Size = new Size(53, 15);
            ProvinceLabel.TabIndex = 20;
            ProvinceLabel.Text = "Province";
            // 
            // ProvinceTB
            // 
            ProvinceTB.Location = new Point(6, 101);
            ProvinceTB.Name = "ProvinceTB";
            ProvinceTB.Size = new Size(100, 23);
            ProvinceTB.TabIndex = 19;
            // 
            // StreetNumberLabel
            // 
            StreetNumberLabel.AutoSize = true;
            StreetNumberLabel.Location = new Point(150, 20);
            StreetNumberLabel.Name = "StreetNumberLabel";
            StreetNumberLabel.Size = new Size(84, 15);
            StreetNumberLabel.TabIndex = 18;
            StreetNumberLabel.Text = "Street Number";
            // 
            // StreetNumberTB
            // 
            StreetNumberTB.Location = new Point(150, 40);
            StreetNumberTB.Name = "StreetNumberTB";
            StreetNumberTB.Size = new Size(100, 23);
            StreetNumberTB.TabIndex = 17;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(150, 83);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(28, 15);
            CityLabel.TabIndex = 16;
            CityLabel.Text = "City";
            // 
            // CityTB
            // 
            CityTB.Location = new Point(150, 101);
            CityTB.Name = "CityTB";
            CityTB.Size = new Size(100, 23);
            CityTB.TabIndex = 15;
            // 
            // StreetNameLabel
            // 
            StreetNameLabel.AutoSize = true;
            StreetNameLabel.Location = new Point(6, 22);
            StreetNameLabel.Name = "StreetNameLabel";
            StreetNameLabel.Size = new Size(72, 15);
            StreetNameLabel.TabIndex = 14;
            StreetNameLabel.Text = "Street Name";
            // 
            // StreetNameTB
            // 
            StreetNameTB.Location = new Point(6, 40);
            StreetNameTB.Name = "StreetNameTB";
            StreetNameTB.Size = new Size(100, 23);
            StreetNameTB.TabIndex = 13;
            // 
            // PhoneTB
            // 
            PhoneTB.Location = new Point(400, 388);
            PhoneTB.Name = "PhoneTB";
            PhoneTB.Size = new Size(155, 23);
            PhoneTB.TabIndex = 11;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Location = new Point(404, 368);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(88, 15);
            PhoneLabel.TabIndex = 12;
            PhoneLabel.Text = "Phone Number";
            // 
            // BalanceTB
            // 
            BalanceTB.Location = new Point(581, 388);
            BalanceTB.Name = "BalanceTB";
            BalanceTB.Size = new Size(100, 23);
            BalanceTB.TabIndex = 13;
            // 
            // BalanceLabel
            // 
            BalanceLabel.AutoSize = true;
            BalanceLabel.Location = new Point(580, 368);
            BalanceLabel.Name = "BalanceLabel";
            BalanceLabel.Size = new Size(48, 15);
            BalanceLabel.TabIndex = 14;
            BalanceLabel.Text = "Balance";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(PremiumRB);
            groupBox1.Controls.Add(RegularRB);
            groupBox1.Location = new Point(394, 278);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(128, 87);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Membership Type";
            // 
            // RegularRB
            // 
            RegularRB.AutoSize = true;
            RegularRB.Location = new Point(6, 22);
            RegularRB.Name = "RegularRB";
            RegularRB.Size = new Size(65, 19);
            RegularRB.TabIndex = 0;
            RegularRB.TabStop = true;
            RegularRB.Text = "Regular";
            RegularRB.UseVisualStyleBackColor = true;
            // 
            // PremiumRB
            // 
            PremiumRB.AutoSize = true;
            PremiumRB.Location = new Point(6, 47);
            PremiumRB.Name = "PremiumRB";
            PremiumRB.Size = new Size(74, 19);
            PremiumRB.TabIndex = 1;
            PremiumRB.TabStop = true;
            PremiumRB.Text = "Premium";
            PremiumRB.UseVisualStyleBackColor = true;
            // 
            // FrequencyRB
            // 
            FrequencyRB.Controls.Add(YearlyRB);
            FrequencyRB.Controls.Add(MonthlyRB);
            FrequencyRB.Location = new Point(545, 278);
            FrequencyRB.Name = "FrequencyRB";
            FrequencyRB.Size = new Size(135, 87);
            FrequencyRB.TabIndex = 16;
            FrequencyRB.TabStop = false;
            FrequencyRB.Text = "Frequency";
            // 
            // MonthlyRB
            // 
            MonthlyRB.AutoSize = true;
            MonthlyRB.Location = new Point(6, 22);
            MonthlyRB.Name = "MonthlyRB";
            MonthlyRB.Size = new Size(70, 19);
            MonthlyRB.TabIndex = 0;
            MonthlyRB.TabStop = true;
            MonthlyRB.Text = "Monthly";
            MonthlyRB.UseVisualStyleBackColor = true;
            // 
            // YearlyRB
            // 
            YearlyRB.AutoSize = true;
            YearlyRB.Location = new Point(5, 47);
            YearlyRB.Name = "YearlyRB";
            YearlyRB.Size = new Size(56, 19);
            YearlyRB.TabIndex = 1;
            YearlyRB.TabStop = true;
            YearlyRB.Text = "Yearly";
            YearlyRB.UseVisualStyleBackColor = true;
            // 
            // EmployeeLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FrequencyRB);
            Controls.Add(groupBox1);
            Controls.Add(BalanceLabel);
            Controls.Add(BalanceTB);
            Controls.Add(PhoneLabel);
            Controls.Add(PhoneTB);
            Controls.Add(AddressGB);
            Controls.Add(LNameLabel);
            Controls.Add(FNameLabel);
            Controls.Add(LNameTB);
            Controls.Add(FNameTB);
            Controls.Add(ViewMemberBtn);
            Controls.Add(UpdateMemberBtn);
            Controls.Add(RemoveMemberBtn);
            Controls.Add(AddMemberBtn);
            Name = "EmployeeLogin";
            Text = "EmployeeLogin";
            AddressGB.ResumeLayout(false);
            AddressGB.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            FrequencyRB.ResumeLayout(false);
            FrequencyRB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddMemberBtn;
        private Button RemoveMemberBtn;
        private Button UpdateMemberBtn;
        private Button ViewMemberBtn;
        private TextBox FNameTB;
        private TextBox LNameTB;
        private Label FNameLabel;
        private Label LNameLabel;
        private GroupBox AddressGB;
        private TextBox PhoneTB;
        private Label PhoneLabel;
        private TextBox CityTB;
        private Label StreetNameLabel;
        private TextBox StreetNameTB;
        private TextBox StreetNumberTB;
        private Label CityLabel;
        private Label StreetNumberLabel;
        private Label ProvinceLabel;
        private TextBox ProvinceTB;
        private TextBox ZipcodeTB;
        private Label ZipcodeLabel;
        private TextBox BalanceTB;
        private Label BalanceLabel;
        private GroupBox groupBox1;
        private RadioButton PremiumRB;
        private RadioButton RegularRB;
        private GroupBox FrequencyRB;
        private RadioButton YearlyRB;
        private RadioButton MonthlyRB;
    }
}