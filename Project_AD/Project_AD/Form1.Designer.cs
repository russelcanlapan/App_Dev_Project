using System.Resources;

namespace Project_AD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            languageButton = new Button();
            SuspendLayout();
            // 
            // languageButton
            // 
            languageButton.Location = new Point(682, 12);
            languageButton.Name = "languageButton";
            languageButton.Size = new Size(106, 41);
            languageButton.TabIndex = 0;
            languageButton.Text = "French";
            languageButton.UseVisualStyleBackColor = true;
            languageButton.Click += languageButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(languageButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        public void UpdateComponent()
        {
            ResourceManager rm = new ResourceManager("Project_AD.Resources.Resources", typeof(Program).Assembly);

            languageButton.Text = rm.GetString("languageButton");
        }

        private Button languageButton;
    }
}
