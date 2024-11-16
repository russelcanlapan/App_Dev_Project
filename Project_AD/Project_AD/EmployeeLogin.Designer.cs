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
            SuspendLayout();
            // 
            // AddMemberBtn
            // 
            AddMemberBtn.Location = new Point(331, 122);
            AddMemberBtn.Name = "AddMemberBtn";
            AddMemberBtn.Size = new Size(122, 23);
            AddMemberBtn.TabIndex = 0;
            AddMemberBtn.Text = "Add Member";
            AddMemberBtn.UseVisualStyleBackColor = true;
            AddMemberBtn.Click += AddMemberBtn_Click;
            // 
            // RemoveMemberBtn
            // 
            RemoveMemberBtn.Location = new Point(331, 172);
            RemoveMemberBtn.Name = "RemoveMemberBtn";
            RemoveMemberBtn.Size = new Size(122, 23);
            RemoveMemberBtn.TabIndex = 1;
            RemoveMemberBtn.Text = "Remove Member";
            RemoveMemberBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateMemberBtn
            // 
            UpdateMemberBtn.Location = new Point(331, 221);
            UpdateMemberBtn.Name = "UpdateMemberBtn";
            UpdateMemberBtn.Size = new Size(122, 23);
            UpdateMemberBtn.TabIndex = 2;
            UpdateMemberBtn.Text = "Update Member";
            UpdateMemberBtn.UseVisualStyleBackColor = true;
            // 
            // ViewMemberBtn
            // 
            ViewMemberBtn.Location = new Point(331, 267);
            ViewMemberBtn.Name = "ViewMemberBtn";
            ViewMemberBtn.Size = new Size(122, 23);
            ViewMemberBtn.TabIndex = 3;
            ViewMemberBtn.Text = "View Member";
            ViewMemberBtn.UseVisualStyleBackColor = true;
            ViewMemberBtn.Click += ViewMemberBtn_Click;
            // 
            // EmployeeLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ViewMemberBtn);
            Controls.Add(UpdateMemberBtn);
            Controls.Add(RemoveMemberBtn);
            Controls.Add(AddMemberBtn);
            Name = "EmployeeLogin";
            Text = "EmployeeLogin";
            ResumeLayout(false);
        }

        #endregion

        private Button AddMemberBtn;
        private Button RemoveMemberBtn;
        private Button UpdateMemberBtn;
        private Button ViewMemberBtn;
    }
}