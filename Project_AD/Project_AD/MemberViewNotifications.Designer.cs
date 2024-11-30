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
            SuspendLayout();
            // 
            // label1
            // 
            notificationLabel.AutoSize = true;
            notificationLabel.Location = new Point(128, 149);
            notificationLabel.Name = "label1";
            notificationLabel.Size = new Size(50, 20);
            notificationLabel.TabIndex = 0;
            notificationLabel.Text = "label1";
            // 
            // MemberViewNotifications
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(notificationLabel);
            Name = "MemberViewNotifications";
            Text = "MemberViewNotifications";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label notificationLabel;
        private System.Windows.Forms.Timer notificationTimer;
    }
}