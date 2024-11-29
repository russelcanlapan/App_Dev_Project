namespace Project_AD
{
    partial class EmployeeRemoveMemberForm
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
            RemoveLabel = new Label();
            MemberIdLabel = new Label();
            MemberIdTB = new TextBox();
            RemoveBtn = new Button();
            SuspendLayout();
            // 
            // RemoveLabel
            // 
            RemoveLabel.AutoSize = true;
            RemoveLabel.Location = new Point(347, 66);
            RemoveLabel.Name = "RemoveLabel";
            RemoveLabel.Size = new Size(98, 15);
            RemoveLabel.TabIndex = 0;
            RemoveLabel.Text = "Remove Member";
            // 
            // MemberIdLabel
            // 
            MemberIdLabel.AutoSize = true;
            MemberIdLabel.Location = new Point(269, 116);
            MemberIdLabel.Name = "MemberIdLabel";
            MemberIdLabel.Size = new Size(69, 15);
            MemberIdLabel.TabIndex = 1;
            MemberIdLabel.Text = "Member ID:";
            // 
            // MemberIdTB
            // 
            MemberIdTB.Location = new Point(347, 108);
            MemberIdTB.Name = "MemberIdTB";
            MemberIdTB.Size = new Size(100, 23);
            MemberIdTB.TabIndex = 2;
            // 
            // RemoveBtn
            // 
            RemoveBtn.Location = new Point(482, 108);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(75, 23);
            RemoveBtn.TabIndex = 3;
            RemoveBtn.Text = "Remove";
            RemoveBtn.UseVisualStyleBackColor = true;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // EmployeeRemoveMemberForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RemoveBtn);
            Controls.Add(MemberIdTB);
            Controls.Add(MemberIdLabel);
            Controls.Add(RemoveLabel);
            Name = "EmployeeRemoveMemberForm";
            Text = "EmployeeRemoveMemberForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RemoveLabel;
        private Label MemberIdLabel;
        private TextBox MemberIdTB;
        private Button RemoveBtn;
    }
}