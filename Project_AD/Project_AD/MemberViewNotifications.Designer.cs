using System.Resources;

namespace Project_AD
{
    partial class MemberViewNotifications
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
            components = new System.ComponentModel.Container();
            notificationLabel = new Label();
            notificationTimer = new System.Windows.Forms.Timer(components);
            backButton = new Button();
            SuspendLayout();
            // 
            // notificationLabel
            // 
            notificationLabel.AutoSize = true;
            notificationLabel.Location = new Point(128, 149);
            notificationLabel.Name = "notificationLabel";
            notificationLabel.Size = new Size(0, 20);
            notificationLabel.TabIndex = 0;
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 409);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 1;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // MemberViewNotifications
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backButton);
            Controls.Add(notificationLabel);
            Name = "MemberViewNotifications";
            Text = "MemberViewNotifications";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public void UpdateComponent()
        {
            ResourceManager rm = new ResourceManager("Project_AD.Resources.Resources", typeof(Program).Assembly);

            backButton.Text = rm.GetString("backButton");
            
        }

        private Label notificationLabel;
        private System.Windows.Forms.Timer notificationTimer;
        private Button backButton;
    }
}