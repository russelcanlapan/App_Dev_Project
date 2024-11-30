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
            EmployeeName = new Label();
            memberLoginGB1 = new GroupBox();
            memberSubmitButton1 = new Button();
            memberIdTB1 = new TextBox();
            memberIdLabel1 = new Label();
            memberLoginGB2 = new GroupBox();
            memberSubmitButton2 = new Button();
            memberIdTB2 = new TextBox();
            memberIdLabel2 = new Label();
            memberLoginGB3 = new GroupBox();
            memberSubmitButton3 = new Button();
            memberIdTB3 = new TextBox();
            memberIdLabel3 = new Label();
            memberLoginGB1.SuspendLayout();
            memberLoginGB2.SuspendLayout();
            memberLoginGB3.SuspendLayout();
            SuspendLayout();
            // 
            // AddMemberBtn
            // 
            AddMemberBtn.Location = new Point(364, 152);
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
            RemoveMemberBtn.Location = new Point(364, 225);
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
            UpdateMemberBtn.Location = new Point(364, 294);
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
            ViewMemberBtn.Location = new Point(364, 367);
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
            logoutButton.Location = new Point(364, 440);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(185, 29);
            logoutButton.TabIndex = 4;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // EmployeeName
            // 
            EmployeeName.AutoSize = true;
            EmployeeName.Location = new Point(23, 21);
            EmployeeName.Name = "EmployeeName";
            EmployeeName.Size = new Size(0, 20);
            EmployeeName.TabIndex = 4;
            // 
            // memberLoginGB1
            // 
            memberLoginGB1.Controls.Add(memberSubmitButton1);
            memberLoginGB1.Controls.Add(memberIdTB1);
            memberLoginGB1.Controls.Add(memberIdLabel1);
            memberLoginGB1.Location = new Point(567, 204);
            memberLoginGB1.Margin = new Padding(3, 4, 3, 4);
            memberLoginGB1.Name = "memberLoginGB1";
            memberLoginGB1.Padding = new Padding(3, 4, 3, 4);
            memberLoginGB1.Size = new Size(335, 63);
            memberLoginGB1.TabIndex = 8;
            memberLoginGB1.TabStop = false;
            // 
            // memberSubmitButton1
            // 
            memberSubmitButton1.Location = new Point(230, 21);
            memberSubmitButton1.Margin = new Padding(3, 4, 3, 4);
            memberSubmitButton1.Name = "memberSubmitButton1";
            memberSubmitButton1.Size = new Size(85, 31);
            memberSubmitButton1.TabIndex = 2;
            memberSubmitButton1.Text = "Submit";
            memberSubmitButton1.UseVisualStyleBackColor = true;
            memberSubmitButton1.Click += memberSubmitButton1_Click;
            // 
            // memberIdTB1
            // 
            memberIdTB1.Location = new Point(109, 21);
            memberIdTB1.Margin = new Padding(3, 4, 3, 4);
            memberIdTB1.Name = "memberIdTB1";
            memberIdTB1.Size = new Size(114, 27);
            memberIdTB1.TabIndex = 1;
            // 
            // memberIdLabel1
            // 
            memberIdLabel1.AutoSize = true;
            memberIdLabel1.Location = new Point(7, 26);
            memberIdLabel1.Name = "memberIdLabel1";
            memberIdLabel1.Size = new Size(87, 20);
            memberIdLabel1.TabIndex = 0;
            memberIdLabel1.Text = "Member ID:";
            // 
            // memberLoginGB2
            // 
            memberLoginGB2.Controls.Add(memberSubmitButton2);
            memberLoginGB2.Controls.Add(memberIdTB2);
            memberLoginGB2.Controls.Add(memberIdLabel2);
            memberLoginGB2.Location = new Point(567, 275);
            memberLoginGB2.Margin = new Padding(3, 4, 3, 4);
            memberLoginGB2.Name = "memberLoginGB2";
            memberLoginGB2.Padding = new Padding(3, 4, 3, 4);
            memberLoginGB2.Size = new Size(335, 63);
            memberLoginGB2.TabIndex = 8;
            memberLoginGB2.TabStop = false;
            // 
            // memberSubmitButton2
            // 
            memberSubmitButton2.Location = new Point(230, 21);
            memberSubmitButton2.Margin = new Padding(3, 4, 3, 4);
            memberSubmitButton2.Name = "memberSubmitButton2";
            memberSubmitButton2.Size = new Size(85, 31);
            memberSubmitButton2.TabIndex = 2;
            memberSubmitButton2.Text = "Submit";
            memberSubmitButton2.UseVisualStyleBackColor = true;
            memberSubmitButton2.Click += memberSubmitButton2_Click;
            // 
            // memberIdTB2
            // 
            memberIdTB2.Location = new Point(109, 21);
            memberIdTB2.Margin = new Padding(3, 4, 3, 4);
            memberIdTB2.Name = "memberIdTB2";
            memberIdTB2.Size = new Size(114, 27);
            memberIdTB2.TabIndex = 1;
            // 
            // memberIdLabel2
            // 
            memberIdLabel2.AutoSize = true;
            memberIdLabel2.Location = new Point(7, 26);
            memberIdLabel2.Name = "memberIdLabel2";
            memberIdLabel2.Size = new Size(87, 20);
            memberIdLabel2.TabIndex = 0;
            memberIdLabel2.Text = "Member ID:";
            // 
            // memberLoginGB3
            // 
            memberLoginGB3.Controls.Add(memberSubmitButton3);
            memberLoginGB3.Controls.Add(memberIdTB3);
            memberLoginGB3.Controls.Add(memberIdLabel3);
            memberLoginGB3.Location = new Point(567, 346);
            memberLoginGB3.Margin = new Padding(3, 4, 3, 4);
            memberLoginGB3.Name = "memberLoginGB3";
            memberLoginGB3.Padding = new Padding(3, 4, 3, 4);
            memberLoginGB3.Size = new Size(335, 63);
            memberLoginGB3.TabIndex = 8;
            memberLoginGB3.TabStop = false;
            // 
            // memberSubmitButton3
            // 
            memberSubmitButton3.Location = new Point(230, 21);
            memberSubmitButton3.Margin = new Padding(3, 4, 3, 4);
            memberSubmitButton3.Name = "memberSubmitButton3";
            memberSubmitButton3.Size = new Size(85, 31);
            memberSubmitButton3.TabIndex = 2;
            memberSubmitButton3.Text = "Submit";
            memberSubmitButton3.UseVisualStyleBackColor = true;
            memberSubmitButton3.Click += memberSubmitButton3_Click;
            // 
            // memberIdTB3
            // 
            memberIdTB3.Location = new Point(109, 21);
            memberIdTB3.Margin = new Padding(3, 4, 3, 4);
            memberIdTB3.Name = "memberIdTB3";
            memberIdTB3.Size = new Size(114, 27);
            memberIdTB3.TabIndex = 1;
            // 
            // memberIdLabel3
            // 
            memberIdLabel3.AutoSize = true;
            memberIdLabel3.Location = new Point(7, 26);
            memberIdLabel3.Name = "memberIdLabel3";
            memberIdLabel3.Size = new Size(87, 20);
            memberIdLabel3.TabIndex = 0;
            memberIdLabel3.Text = "Member ID:";
            // 
            // EmployeeLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(memberLoginGB3);
            Controls.Add(memberLoginGB2);
            Controls.Add(memberLoginGB1);
            Controls.Add(logoutButton);
            Controls.Add(EmployeeName);
            Controls.Add(ViewMemberBtn);
            Controls.Add(UpdateMemberBtn);
            Controls.Add(RemoveMemberBtn);
            Controls.Add(AddMemberBtn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmployeeLogin";
            Text = "EmployeeLogin";
            memberLoginGB1.ResumeLayout(false);
            memberLoginGB1.PerformLayout();
            memberLoginGB2.ResumeLayout(false);
            memberLoginGB2.PerformLayout();
            memberLoginGB3.ResumeLayout(false);
            memberLoginGB3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
            memberIdLabel1.Text = rm.GetString("memberIdLabel");
            memberIdLabel2.Text = rm.GetString("memberIdLabel");
            memberIdLabel3.Text = rm.GetString("memberIdLabel");
            memberSubmitButton1.Text = rm.GetString("submitButton");
            memberSubmitButton2.Text = rm.GetString("submitButton");
            memberSubmitButton3.Text = rm.GetString("submitButton");
        }

        private Button AddMemberBtn;
        private Button RemoveMemberBtn;
        private Button UpdateMemberBtn;
        private Button ViewMemberBtn;
        private Button logoutButton;
        private Label EmployeeName;
        public GroupBox memberLoginGB1;
        private Button memberSubmitButton1;
        private TextBox memberIdTB1;
        private Label memberIdLabel1;
        public GroupBox memberLoginGB2;
        private Button memberSubmitButton2;
        private TextBox memberIdTB2;
        private Label memberIdLabel2;
        public GroupBox memberLoginGB3;
        private Button memberSubmitButton3;
        private TextBox memberIdTB3;
        private Label memberIdLabel3;
    }
}