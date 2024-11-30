using System.Resources;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberLogin));
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
            // memberOptionsLabel
            // 
            memberOptionsLabel.AutoSize = true;
            memberOptionsLabel.Location = new Point(354, 136);
            memberOptionsLabel.Name = "memberOptionsLabel";
            memberOptionsLabel.Size = new Size(64, 20);
            memberOptionsLabel.TabIndex = 0;
            memberOptionsLabel.Text = "Options:";
            // 
            // viewProfileButton
            // 
            viewProfileButton.Location = new Point(354, 193);
            viewProfileButton.Margin = new Padding(3, 4, 3, 4);
            viewProfileButton.Name = "viewProfileButton";
            viewProfileButton.Size = new Size(153, 31);
            viewProfileButton.TabIndex = 1;
            viewProfileButton.Text = "View Profile";
            viewProfileButton.UseVisualStyleBackColor = true;
            viewProfileButton.Click += viewProfileButton_Click;
            // 
            // updateProfileButton
            // 
            updateProfileButton.Location = new Point(354, 232);
            updateProfileButton.Margin = new Padding(3, 4, 3, 4);
            updateProfileButton.Name = "updateProfileButton";
            updateProfileButton.Size = new Size(153, 31);
            updateProfileButton.TabIndex = 2;
            updateProfileButton.Text = "Update Profile";
            updateProfileButton.UseVisualStyleBackColor = true;
            updateProfileButton.Click += updateProfileButton_Click;
            // 
            // manageMembershipButton
            // 
            manageMembershipButton.Location = new Point(354, 271);
            manageMembershipButton.Margin = new Padding(3, 4, 3, 4);
            manageMembershipButton.Name = "manageMembershipButton";
            manageMembershipButton.Size = new Size(153, 31);
            manageMembershipButton.TabIndex = 3;
            manageMembershipButton.Text = "Manage Membership";
            manageMembershipButton.UseVisualStyleBackColor = true;
            // 
            // checkPricesButton
            // 
            checkPricesButton.Location = new Point(354, 309);
            checkPricesButton.Margin = new Padding(3, 4, 3, 4);
            checkPricesButton.Name = "checkPricesButton";
            checkPricesButton.Size = new Size(153, 31);
            checkPricesButton.TabIndex = 4;
            checkPricesButton.Text = "Check Prices";
            checkPricesButton.UseVisualStyleBackColor = true;
            checkPricesButton.Click += checkPricesButton_Click;
            // 
            // makePaymentButton
            // 
            makePaymentButton.Location = new Point(354, 348);
            makePaymentButton.Margin = new Padding(3, 4, 3, 4);
            makePaymentButton.Name = "makePaymentButton";
            makePaymentButton.Size = new Size(153, 31);
            makePaymentButton.TabIndex = 5;
            makePaymentButton.Text = "Make Payment";
            makePaymentButton.UseVisualStyleBackColor = true;
            // 
            // viewNotificationsButton
            // 
            viewNotificationsButton.Location = new Point(354, 387);
            viewNotificationsButton.Margin = new Padding(3, 4, 3, 4);
            viewNotificationsButton.Name = "viewNotificationsButton";
            viewNotificationsButton.Size = new Size(153, 31);
            viewNotificationsButton.TabIndex = 6;
            viewNotificationsButton.Text = "View Notifications";
            viewNotificationsButton.UseVisualStyleBackColor = true;
            viewNotificationsButton.Click += viewNotificationsButton_Click;
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(354, 425);
            logoutButton.Margin = new Padding(3, 4, 3, 4);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(153, 31);
            logoutButton.TabIndex = 7;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // MemberLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(914, 600);
            Controls.Add(logoutButton);
            Controls.Add(viewNotificationsButton);
            Controls.Add(makePaymentButton);
            Controls.Add(checkPricesButton);
            Controls.Add(manageMembershipButton);
            Controls.Add(updateProfileButton);
            Controls.Add(viewProfileButton);
            Controls.Add(memberOptionsLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MemberLogin";
            Text = "MemberLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public void UpdateComponent()
        {
            ResourceManager rm = new ResourceManager("Project_AD.Resources.Resources", typeof(Program).Assembly);

            viewProfileButton.Text = rm.GetString("viewProfileButton");
            updateProfileButton.Text = rm.GetString("updateProfileButton");
            manageMembershipButton.Text = rm.GetString("manageMembershipButton");
            makePaymentButton.Text = rm.GetString("makePaymentButton");
            checkPricesButton.Text = rm.GetString("checkPricesButton");
            viewNotificationsButton.Text = rm.GetString("viewNotificationsButton");
            logoutButton.Text = rm.GetString("logoutButton");
        }

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