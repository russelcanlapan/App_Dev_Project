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
            cancelLabel = new Label();
            cancelButton = new Button();
            submitButton = new Button();
            membershipGB.SuspendLayout();
            frequencyGB.SuspendLayout();
            SuspendLayout();
            // 
            // manageLabel
            // 
            manageLabel.AutoSize = true;
            manageLabel.Location = new Point(348, 67);
            manageLabel.Name = "manageLabel";
            manageLabel.Size = new Size(120, 15);
            manageLabel.TabIndex = 0;
            manageLabel.Text = "Manage Membership";
            // 
            // membershipGB
            // 
            membershipGB.Controls.Add(premiumRB);
            membershipGB.Controls.Add(regularRB);
            membershipGB.Location = new Point(185, 116);
            membershipGB.Name = "membershipGB";
            membershipGB.Size = new Size(200, 100);
            membershipGB.TabIndex = 1;
            membershipGB.TabStop = false;
            membershipGB.Text = "Membership Type";
            // 
            // premiumRB
            // 
            premiumRB.AutoSize = true;
            premiumRB.Location = new Point(6, 56);
            premiumRB.Name = "premiumRB";
            premiumRB.Size = new Size(74, 19);
            premiumRB.TabIndex = 3;
            premiumRB.TabStop = true;
            premiumRB.Text = "Premium";
            premiumRB.UseVisualStyleBackColor = true;
            // 
            // regularRB
            // 
            regularRB.AutoSize = true;
            regularRB.Location = new Point(6, 22);
            regularRB.Name = "regularRB";
            regularRB.Size = new Size(65, 19);
            regularRB.TabIndex = 3;
            regularRB.TabStop = true;
            regularRB.Text = "Regular";
            regularRB.UseVisualStyleBackColor = true;
            // 
            // frequencyGB
            // 
            frequencyGB.Controls.Add(yearlyRB);
            frequencyGB.Controls.Add(monthlyRB);
            frequencyGB.Location = new Point(445, 116);
            frequencyGB.Name = "frequencyGB";
            frequencyGB.Size = new Size(200, 100);
            frequencyGB.TabIndex = 2;
            frequencyGB.TabStop = false;
            frequencyGB.Text = "Frequency Type";
            // 
            // yearlyRB
            // 
            yearlyRB.AutoSize = true;
            yearlyRB.Location = new Point(6, 56);
            yearlyRB.Name = "yearlyRB";
            yearlyRB.Size = new Size(56, 19);
            yearlyRB.TabIndex = 1;
            yearlyRB.TabStop = true;
            yearlyRB.Text = "Yearly";
            yearlyRB.UseVisualStyleBackColor = true;
            // 
            // monthlyRB
            // 
            monthlyRB.AutoSize = true;
            monthlyRB.Location = new Point(6, 22);
            monthlyRB.Name = "monthlyRB";
            monthlyRB.Size = new Size(70, 19);
            monthlyRB.TabIndex = 0;
            monthlyRB.TabStop = true;
            monthlyRB.Text = "Monthly";
            monthlyRB.UseVisualStyleBackColor = true;
            // 
            // cancelLabel
            // 
            cancelLabel.AutoSize = true;
            cancelLabel.Location = new Point(355, 339);
            cancelLabel.Name = "cancelLabel";
            cancelLabel.Size = new Size(113, 15);
            cancelLabel.TabIndex = 3;
            cancelLabel.Text = "Cancel Membership";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(335, 366);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(162, 23);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Cancel Membership";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(370, 222);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(86, 23);
            submitButton.TabIndex = 5;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // MemberManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(submitButton);
            Controls.Add(cancelButton);
            Controls.Add(cancelLabel);
            Controls.Add(frequencyGB);
            Controls.Add(membershipGB);
            Controls.Add(manageLabel);
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

        private Label manageLabel;
        private GroupBox membershipGB;
        private RadioButton premiumRB;
        private RadioButton regularRB;
        private GroupBox frequencyGB;
        private RadioButton yearlyRB;
        private RadioButton monthlyRB;
        private Label cancelLabel;
        private Button cancelButton;
        private Button submitButton;
    }
}