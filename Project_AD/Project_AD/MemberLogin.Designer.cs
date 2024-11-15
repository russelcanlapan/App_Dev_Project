namespace Project_AD
{
    partial class MemberLogin
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
            memberOptionsLabel = new Label();
            viewProfileButton = new Button();
            updateProfileButton = new Button();
            manageMembershipButton = new Button();
            checkPricesButton = new Button();
            makePaymentButton = new Button();
            viewNotificationsButton = new Button();
            logoutButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            memberOptionsLabel.AutoSize = true;
            memberOptionsLabel.Location = new Point(196, 87);
            memberOptionsLabel.Name = "memberOptionsLabel";
            memberOptionsLabel.Size = new Size(38, 15);
            memberOptionsLabel.TabIndex = 0;
            memberOptionsLabel.Text = "Options:";
            // 
            // button1
            // 
            viewProfileButton.Location = new Point(196, 130);
            viewProfileButton.Name = "viewProfileButton";
            viewProfileButton.Size = new Size(75, 23);
            viewProfileButton.TabIndex = 1;
            viewProfileButton.Text = "View Profile";
            viewProfileButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            updateProfileButton.Location = new Point(196, 159);
            updateProfileButton.Name = "updateProfileButton";
            updateProfileButton.Size = new Size(75, 23);
            updateProfileButton.TabIndex = 2;
            updateProfileButton.Text = "Update Profile";
            updateProfileButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            manageMembershipButton.Location = new Point(196, 188);
            manageMembershipButton.Name = "manageMembershipButton";
            manageMembershipButton.Size = new Size(75, 23);
            manageMembershipButton.TabIndex = 3;
            manageMembershipButton.Text = "Manage Membership";
            manageMembershipButton.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            checkPricesButton.Location = new Point(196, 217);
            checkPricesButton.Name = "checkPricesButton";
            checkPricesButton.Size = new Size(75, 23);
            checkPricesButton.TabIndex = 4;
            checkPricesButton.Text = "Check Prices";
            checkPricesButton.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            makePaymentButton.Location = new Point(196, 246);
            makePaymentButton.Name = "makePaymentButton";
            makePaymentButton.Size = new Size(75, 23);
            makePaymentButton.TabIndex = 5;
            makePaymentButton.Text = "Make Payment";
            makePaymentButton.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            viewNotificationsButton.Location = new Point(196, 275);
            viewNotificationsButton.Name = "viewNotificationsButton";
            viewNotificationsButton.Size = new Size(75, 23);
            viewNotificationsButton.TabIndex = 6;
            viewNotificationsButton.Text = "View Notifications";
            viewNotificationsButton.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            logoutButton.Location = new Point(196, 304);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(75, 23);
            logoutButton.TabIndex = 7;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            // 
            // MemberLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logoutButton);
            Controls.Add(viewNotificationsButton);
            Controls.Add(makePaymentButton);
            Controls.Add(checkPricesButton);
            Controls.Add(manageMembershipButton);
            Controls.Add(updateProfileButton);
            Controls.Add(viewProfileButton);
            Controls.Add(memberOptionsLabel);
            Name = "MemberLogin";
            Text = "MemberLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label memberOptionsLabel;
        private Button viewProfileButton;
        private Button updateProfileButton;
        private Button manageMembershipButton;
        private Button checkPricesButton;
        private Button makePaymentButton;
        private Button viewNotificationsButton;
        private Button logoutButton;
    }
}