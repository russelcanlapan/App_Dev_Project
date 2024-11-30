using System.Resources;

namespace Project_AD
{
    partial class MemberCheckPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberCheckPrice));
            checkPricesLabel = new Label();
            regularMonthlyLabel = new Label();
            premiumMonthlyLabel = new Label();
            promotionLabel = new Label();
            regularYearlyLabel = new Label();
            premiumYearlyLabel = new Label();
            monthlyLabel = new Label();
            yearlyLabel = new Label();
            backButton = new Button();
            SuspendLayout();
            // 
            // checkPricesLabel
            // 
            checkPricesLabel.AutoSize = true;
            checkPricesLabel.BackColor = Color.White;
            checkPricesLabel.ForeColor = SystemColors.ActiveCaptionText;
            checkPricesLabel.Location = new Point(298, 56);
            checkPricesLabel.Name = "checkPricesLabel";
            checkPricesLabel.Size = new Size(74, 15);
            checkPricesLabel.TabIndex = 0;
            checkPricesLabel.Text = "Check Prices";
            // 
            // regularMonthlyLabel
            // 
            regularMonthlyLabel.AutoSize = true;
            regularMonthlyLabel.Location = new Point(49, 110);
            regularMonthlyLabel.Name = "regularMonthlyLabel";
            regularMonthlyLabel.Size = new Size(86, 15);
            regularMonthlyLabel.TabIndex = 2;
            regularMonthlyLabel.Text = "Regular: 19.99$";
            // 
            // premiumMonthlyLabel
            // 
            premiumMonthlyLabel.AutoSize = true;
            premiumMonthlyLabel.Location = new Point(49, 124);
            premiumMonthlyLabel.Name = "premiumMonthlyLabel";
            premiumMonthlyLabel.Size = new Size(95, 15);
            premiumMonthlyLabel.TabIndex = 3;
            premiumMonthlyLabel.Text = "Premium: 29.99$";
            // 
            // promotionLabel
            // 
            promotionLabel.AutoSize = true;
            promotionLabel.BackColor = Color.ForestGreen;
            promotionLabel.Location = new Point(2, 182);
            promotionLabel.Name = "promotionLabel";
            promotionLabel.Size = new Size(588, 15);
            promotionLabel.TabIndex = 4;
            promotionLabel.Text = "Black Friday! Achieve your fitness goals with our best deals of the year. Join now and save big on memberships";
            // 
            // regularYearlyLabel
            // 
            regularYearlyLabel.AutoSize = true;
            regularYearlyLabel.Location = new Point(479, 110);
            regularYearlyLabel.Name = "regularYearlyLabel";
            regularYearlyLabel.Size = new Size(95, 15);
            regularYearlyLabel.TabIndex = 5;
            regularYearlyLabel.Text = "Regular:  259.75$";
            // 
            // premiumYearlyLabel
            // 
            premiumYearlyLabel.AutoSize = true;
            premiumYearlyLabel.Location = new Point(479, 124);
            premiumYearlyLabel.Name = "premiumYearlyLabel";
            premiumYearlyLabel.Size = new Size(101, 15);
            premiumYearlyLabel.TabIndex = 6;
            premiumYearlyLabel.Text = "Premium: 389.75$";
            // 
            // monthlyLabel
            // 
            monthlyLabel.AutoSize = true;
            monthlyLabel.Location = new Point(49, 87);
            monthlyLabel.Name = "monthlyLabel";
            monthlyLabel.Size = new Size(92, 15);
            monthlyLabel.TabIndex = 7;
            monthlyLabel.Text = "Monthly Prices: ";
            // 
            // yearlyLabel
            // 
            yearlyLabel.AutoSize = true;
            yearlyLabel.Location = new Point(479, 87);
            yearlyLabel.Name = "yearlyLabel";
            yearlyLabel.Size = new Size(75, 15);
            yearlyLabel.TabIndex = 8;
            yearlyLabel.Text = "Yearly Prices:";
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 303);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 9;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // MemberCheckPrice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(backButton);
            Controls.Add(yearlyLabel);
            Controls.Add(monthlyLabel);
            Controls.Add(premiumYearlyLabel);
            Controls.Add(regularYearlyLabel);
            Controls.Add(promotionLabel);
            Controls.Add(premiumMonthlyLabel);
            Controls.Add(regularMonthlyLabel);
            Controls.Add(checkPricesLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MemberCheckPrice";
            Text = "MemberCheckPrice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public void UpdateComponent()
        {
            ResourceManager rm = new ResourceManager("Project_AD.Resources.Resources", typeof(Program).Assembly);

            checkPricesLabel.Text = rm.GetString("checkPricesLabel");
            monthlyLabel.Text = rm.GetString("monthlyLabel");
            yearlyLabel.Text = rm.GetString("yearlyLabel");
            premiumMonthlyLabel.Text = rm.GetString("premiumMonthlyLabel");
            premiumYearlyLabel.Text = rm.GetString("premiumYearlyLabel");
            regularMonthlyLabel.Text = rm.GetString("regularMonthlyLabel");
            regularYearlyLabel.Text = rm.GetString("regularYearlyLabel");
            promotionLabel.Text = rm.GetString("promotionLabel");
            backButton.Text = rm.GetString("backButton");
        }

        private Label checkPricesLabel;
        private Label regularMonthlyLabel;
        private Label premiumMonthlyLabel;
        private Label promotionLabel;
        private Label regularYearlyLabel;
        private Label premiumYearlyLabel;
        private Label monthlyLabel;
        private Label yearlyLabel;
        private Button backButton;
    }

}