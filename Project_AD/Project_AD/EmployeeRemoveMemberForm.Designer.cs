using System.Resources;

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
            backButton = new Button();
            SuspendLayout();
            // 
            // RemoveLabel
            // 
            RemoveLabel.AutoSize = true;
            RemoveLabel.Location = new Point(397, 88);
            RemoveLabel.Name = "RemoveLabel";
            RemoveLabel.Size = new Size(123, 20);
            RemoveLabel.TabIndex = 0;
            RemoveLabel.Text = "Remove Member";
            // 
            // MemberIdLabel
            // 
            MemberIdLabel.AutoSize = true;
            MemberIdLabel.Location = new Point(307, 155);
            MemberIdLabel.Name = "MemberIdLabel";
            MemberIdLabel.Size = new Size(87, 20);
            MemberIdLabel.TabIndex = 1;
            MemberIdLabel.Text = "Member ID:";
            // 
            // MemberIdTB
            // 
            MemberIdTB.Location = new Point(397, 144);
            MemberIdTB.Margin = new Padding(3, 4, 3, 4);
            MemberIdTB.Name = "MemberIdTB";
            MemberIdTB.Size = new Size(114, 27);
            MemberIdTB.TabIndex = 2;
            // 
            // RemoveBtn
            // 
            RemoveBtn.Location = new Point(551, 144);
            RemoveBtn.Margin = new Padding(3, 4, 3, 4);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(86, 31);
            RemoveBtn.TabIndex = 3;
            RemoveBtn.Text = "Remove";
            RemoveBtn.UseVisualStyleBackColor = true;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 559);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 4;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // EmployeeRemoveMemberForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(backButton);
            Controls.Add(RemoveBtn);
            Controls.Add(MemberIdTB);
            Controls.Add(MemberIdLabel);
            Controls.Add(RemoveLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmployeeRemoveMemberForm";
            Text = "EmployeeRemoveMemberForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public void UpdateComponent()
        {
            ResourceManager rm = new ResourceManager("Project_AD.Resources.Resources", typeof(Program).Assembly);

            RemoveLabel.Text = rm.GetString("removeMemberButton");
            MemberIdLabel.Text = rm.GetString("memberIdLabel");
            RemoveBtn.Text = rm.GetString("removeMemberButton");
            backButton.Text = rm.GetString("backButton");
        }

        private Label RemoveLabel;
        private Label MemberIdLabel;
        private TextBox MemberIdTB;
        private Button RemoveBtn;
        private Button backButton;
    }
}