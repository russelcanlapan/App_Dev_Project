using System.Resources;

namespace Project_AD
{
    partial class MemberManage
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
            manageLabel = new Label();
            membershipGB = new GroupBox();
            premiumRB = new RadioButton();
            regularRB = new RadioButton();
            frequencyGB = new GroupBox();
            yearlyRB = new RadioButton();
            monthlyRB = new RadioButton();
            submitButton = new Button();
            backButton = new Button();
            membershipGB.SuspendLayout();
            frequencyGB.SuspendLayout();
            SuspendLayout();
            // 
            // manageLabel
            // 
            manageLabel.AutoSize = true;
            manageLabel.Location = new Point(398, 89);
            manageLabel.Name = "manageLabel";
            manageLabel.Size = new Size(150, 20);
            manageLabel.TabIndex = 0;
            manageLabel.Text = "Manage Membership";
            // 
            // membershipGB
            // 
            membershipGB.Controls.Add(premiumRB);
            membershipGB.Controls.Add(regularRB);
            membershipGB.Location = new Point(211, 155);
            membershipGB.Margin = new Padding(3, 4, 3, 4);
            membershipGB.Name = "membershipGB";
            membershipGB.Padding = new Padding(3, 4, 3, 4);
            membershipGB.Size = new Size(229, 133);
            membershipGB.TabIndex = 1;
            membershipGB.TabStop = false;
            membershipGB.Text = "Membership Type";
            // 
            // premiumRB
            // 
            premiumRB.AutoSize = true;
            premiumRB.Location = new Point(7, 75);
            premiumRB.Margin = new Padding(3, 4, 3, 4);
            premiumRB.Name = "premiumRB";
            premiumRB.Size = new Size(89, 24);
            premiumRB.TabIndex = 3;
            premiumRB.TabStop = true;
            premiumRB.Text = "Premium";
            premiumRB.UseVisualStyleBackColor = true;
            // 
            // regularRB
            // 
            regularRB.AutoSize = true;
            regularRB.Location = new Point(7, 29);
            regularRB.Margin = new Padding(3, 4, 3, 4);
            regularRB.Name = "regularRB";
            regularRB.Size = new Size(81, 24);
            regularRB.TabIndex = 3;
            regularRB.TabStop = true;
            regularRB.Text = "Regular";
            regularRB.UseVisualStyleBackColor = true;
            // 
            // frequencyGB
            // 
            frequencyGB.Controls.Add(yearlyRB);
            frequencyGB.Controls.Add(monthlyRB);
            frequencyGB.Location = new Point(509, 155);
            frequencyGB.Margin = new Padding(3, 4, 3, 4);
            frequencyGB.Name = "frequencyGB";
            frequencyGB.Padding = new Padding(3, 4, 3, 4);
            frequencyGB.Size = new Size(229, 133);
            frequencyGB.TabIndex = 2;
            frequencyGB.TabStop = false;
            frequencyGB.Text = "Frequency Type";
            // 
            // yearlyRB
            // 
            yearlyRB.AutoSize = true;
            yearlyRB.Location = new Point(7, 75);
            yearlyRB.Margin = new Padding(3, 4, 3, 4);
            yearlyRB.Name = "yearlyRB";
            yearlyRB.Size = new Size(69, 24);
            yearlyRB.TabIndex = 1;
            yearlyRB.TabStop = true;
            yearlyRB.Text = "Yearly";
            yearlyRB.UseVisualStyleBackColor = true;
            // 
            // monthlyRB
            // 
            monthlyRB.AutoSize = true;
            monthlyRB.Location = new Point(7, 29);
            monthlyRB.Margin = new Padding(3, 4, 3, 4);
            monthlyRB.Name = "monthlyRB";
            monthlyRB.Size = new Size(84, 24);
            monthlyRB.TabIndex = 0;
            monthlyRB.TabStop = true;
            monthlyRB.Text = "Monthly";
            monthlyRB.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(423, 317);
            submitButton.Margin = new Padding(3, 4, 3, 4);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(98, 31);
            submitButton.TabIndex = 5;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 559);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 6;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // MemberManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(backButton);
            Controls.Add(submitButton);
            Controls.Add(frequencyGB);
            Controls.Add(membershipGB);
            Controls.Add(manageLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MemberManage";
            Text = "ManageMembership";
            membershipGB.ResumeLayout(false);
            membershipGB.PerformLayout();
            frequencyGB.ResumeLayout(false);
            frequencyGB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public void UpdateComponent()
        {
            ResourceManager rm = new ResourceManager("Project_AD.Resources.Resources", typeof(Program).Assembly);

            manageLabel.Text = rm.GetString("manageLabel");
            premiumRB.Text = rm.GetString("premiumRB");
            regularRB.Text = rm.GetString("regularRB");
            yearlyRB.Text = rm.GetString("yearlyRB");
            monthlyRB.Text = rm.GetString("monthlyRB");
            backButton.Text = rm.GetString("backButton");
            submitButton.Text = rm.GetString("submitButton");
            membershipGB.Text = rm.GetString("membershipTypeGB");
            frequencyGB.Text = rm.GetString("frequencyTypeGB");
        }

        private Label manageLabel;
        private GroupBox membershipGB;
        private RadioButton premiumRB;
        private RadioButton regularRB;
        private GroupBox frequencyGB;
        private RadioButton yearlyRB;
        private RadioButton monthlyRB;
        private Button submitButton;
        private Button backButton;
    }
}