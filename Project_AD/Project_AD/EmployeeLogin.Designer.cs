using System.Resources;

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
            logoutButton = new Button();
            SuspendLayout();
            // 
            // AddMemberBtn
            // 
            AddMemberBtn.Location = new Point(381, 163);
            AddMemberBtn.Margin = new Padding(3, 4, 3, 4);
            AddMemberBtn.Name = "AddMemberBtn";
            AddMemberBtn.Size = new Size(185, 31);
            AddMemberBtn.TabIndex = 0;
            AddMemberBtn.Text = "Add Member";
            AddMemberBtn.UseVisualStyleBackColor = true;
            AddMemberBtn.Click += AddMemberBtn_Click;
            // 
            // RemoveMemberBtn
            // 
            RemoveMemberBtn.Location = new Point(381, 225);
            RemoveMemberBtn.Margin = new Padding(3, 4, 3, 4);
            RemoveMemberBtn.Name = "RemoveMemberBtn";
            RemoveMemberBtn.Size = new Size(185, 31);
            RemoveMemberBtn.TabIndex = 1;
            RemoveMemberBtn.Text = "Remove Member";
            RemoveMemberBtn.UseVisualStyleBackColor = true;
            RemoveMemberBtn.Click += RemoveMemberBtn_Click;
            // 
            // UpdateMemberBtn
            // 
            UpdateMemberBtn.Location = new Point(381, 292);
            UpdateMemberBtn.Margin = new Padding(3, 4, 3, 4);
            UpdateMemberBtn.Name = "UpdateMemberBtn";
            UpdateMemberBtn.Size = new Size(185, 31);
            UpdateMemberBtn.TabIndex = 2;
            UpdateMemberBtn.Text = "Update Member";
            UpdateMemberBtn.UseVisualStyleBackColor = true;
            UpdateMemberBtn.Click += UpdateMemberBtn_Click;
            // 
            // ViewMemberBtn
            // 
            ViewMemberBtn.Location = new Point(381, 359);
            ViewMemberBtn.Margin = new Padding(3, 4, 3, 4);
            ViewMemberBtn.Name = "ViewMemberBtn";
            ViewMemberBtn.Size = new Size(185, 31);
            ViewMemberBtn.TabIndex = 3;
            ViewMemberBtn.Text = "View Member";
            ViewMemberBtn.UseVisualStyleBackColor = true;
            ViewMemberBtn.Click += ViewMemberBtn_Click;
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(381, 421);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(185, 29);
            logoutButton.TabIndex = 4;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // EmployeeLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(logoutButton);
            Controls.Add(ViewMemberBtn);
            Controls.Add(UpdateMemberBtn);
            Controls.Add(RemoveMemberBtn);
            Controls.Add(AddMemberBtn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmployeeLogin";
            Text = "EmployeeLogin";
            ResumeLayout(false);
        }

        #endregion

        public void UpdateComponent()
        {
            ResourceManager rm = new ResourceManager("Project_AD.Resources.Resources", typeof(Program).Assembly);

            AddMemberBtn.Text = rm.GetString("addMemberButton");
            RemoveMemberBtn.Text = rm.GetString("removeMemberButton");
            UpdateMemberBtn.Text = rm.GetString("updateMemberButton");
            ViewMemberBtn.Text = rm.GetString("viewMemberButton");
            logoutButton.Text = rm.GetString("logoutButton");
        }

        private Button AddMemberBtn;
        private Button RemoveMemberBtn;
        private Button UpdateMemberBtn;
        private Button ViewMemberBtn;
        private Button logoutButton;
    }
}