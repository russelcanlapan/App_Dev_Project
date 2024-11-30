using System.Resources;

namespace Project_AD
{
    partial class MemberMakePayment
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
            makePaymentLabel = new Label();
            creditCardButton = new Button();
            debitCardButton = new Button();
            cashButton = new Button();
            backButton = new Button();
            submitButton = new Button();
            debitCardGB = new GroupBox();
            debitCardPinNumberTB = new TextBox();
            debitCardExpirationDateTB = new TextBox();
            debitCardCardHolderNameTB = new TextBox();
            debitCardNumberTB = new TextBox();
            debitCardPinNumberLabel = new Label();
            debitCardExpirationDateLabel = new Label();
            debitCardCardHolderNameLabel = new Label();
            debitCardNumberLabel = new Label();
            cashGB = new GroupBox();
            cashAmountTB = new TextBox();
            cashAmountLabel = new Label();
            creditCardGB = new GroupBox();
            creditCardCvvTB = new TextBox();
            creditCardExpirationDateTB = new TextBox();
            creditCardCardHolderNameTB = new TextBox();
            creditCardNumberTB = new TextBox();
            creditCardCVVLabel = new Label();
            creditCardExpirationDateLabel = new Label();
            creditCardCardHolderNameLabel = new Label();
            creditCardNumberLabel = new Label();
            debitCardGB.SuspendLayout();
            cashGB.SuspendLayout();
            creditCardGB.SuspendLayout();
            SuspendLayout();
            // 
            // makePaymentLabel
            // 
            makePaymentLabel.AutoSize = true;
            makePaymentLabel.Location = new Point(373, 24);
            makePaymentLabel.Name = "makePaymentLabel";
            makePaymentLabel.Size = new Size(86, 15);
            makePaymentLabel.TabIndex = 0;
            makePaymentLabel.Text = "Make Payment";
            // 
            // creditCardButton
            // 
            creditCardButton.Location = new Point(349, 118);
            creditCardButton.Name = "creditCardButton";
            creditCardButton.Size = new Size(135, 23);
            creditCardButton.TabIndex = 2;
            creditCardButton.Text = "Credit Card";
            creditCardButton.UseVisualStyleBackColor = true;
            creditCardButton.Click += creditCardButton_Click;
            // 
            // debitCardButton
            // 
            debitCardButton.Location = new Point(349, 166);
            debitCardButton.Name = "debitCardButton";
            debitCardButton.Size = new Size(135, 23);
            debitCardButton.TabIndex = 3;
            debitCardButton.Text = "Debit Card";
            debitCardButton.UseVisualStyleBackColor = true;
            debitCardButton.Click += debitCardButton_Click;
            // 
            // cashButton
            // 
            cashButton.Location = new Point(349, 70);
            cashButton.Name = "cashButton";
            cashButton.Size = new Size(135, 23);
            cashButton.TabIndex = 1;
            cashButton.Text = "Cash";
            cashButton.UseVisualStyleBackColor = true;
            cashButton.Click += cashButton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 418);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 6;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(714, 418);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(75, 23);
            submitButton.TabIndex = 7;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // debitCardGB
            // 
            debitCardGB.Controls.Add(debitCardPinNumberTB);
            debitCardGB.Controls.Add(debitCardExpirationDateTB);
            debitCardGB.Controls.Add(debitCardCardHolderNameTB);
            debitCardGB.Controls.Add(debitCardNumberTB);
            debitCardGB.Controls.Add(debitCardPinNumberLabel);
            debitCardGB.Controls.Add(debitCardExpirationDateLabel);
            debitCardGB.Controls.Add(debitCardCardHolderNameLabel);
            debitCardGB.Controls.Add(debitCardNumberLabel);
            debitCardGB.Location = new Point(204, 249);
            debitCardGB.Name = "debitCardGB";
            debitCardGB.Size = new Size(429, 188);
            debitCardGB.TabIndex = 5;
            debitCardGB.TabStop = false;
            // 
            // debitCardPinNumberTB
            // 
            debitCardPinNumberTB.Location = new Point(189, 138);
            debitCardPinNumberTB.Name = "debitCardPinNumberTB";
            debitCardPinNumberTB.Size = new Size(213, 23);
            debitCardPinNumberTB.TabIndex = 7;
            // 
            // debitCardExpirationDateTB
            // 
            debitCardExpirationDateTB.Location = new Point(189, 99);
            debitCardExpirationDateTB.Name = "debitCardExpirationDateTB";
            debitCardExpirationDateTB.Size = new Size(213, 23);
            debitCardExpirationDateTB.TabIndex = 6;
            // 
            // debitCardCardHolderNameTB
            // 
            debitCardCardHolderNameTB.Location = new Point(189, 63);
            debitCardCardHolderNameTB.Name = "debitCardCardHolderNameTB";
            debitCardCardHolderNameTB.Size = new Size(213, 23);
            debitCardCardHolderNameTB.TabIndex = 5;
            // 
            // debitCardNumberTB
            // 
            debitCardNumberTB.Location = new Point(189, 27);
            debitCardNumberTB.Name = "debitCardNumberTB";
            debitCardNumberTB.Size = new Size(213, 23);
            debitCardNumberTB.TabIndex = 4;
            // 
            // debitCardPinNumberLabel
            // 
            debitCardPinNumberLabel.AutoSize = true;
            debitCardPinNumberLabel.Location = new Point(6, 146);
            debitCardPinNumberLabel.Name = "debitCardPinNumberLabel";
            debitCardPinNumberLabel.Size = new Size(74, 15);
            debitCardPinNumberLabel.TabIndex = 3;
            debitCardPinNumberLabel.Text = "Pin Number:";
            // 
            // debitCardExpirationDateLabel
            // 
            debitCardExpirationDateLabel.AutoSize = true;
            debitCardExpirationDateLabel.Location = new Point(6, 110);
            debitCardExpirationDateLabel.Name = "debitCardExpirationDateLabel";
            debitCardExpirationDateLabel.Size = new Size(89, 15);
            debitCardExpirationDateLabel.TabIndex = 2;
            debitCardExpirationDateLabel.Text = "Expiration date:";
            // 
            // debitCardCardHolderNameLabel
            // 
            debitCardCardHolderNameLabel.AutoSize = true;
            debitCardCardHolderNameLabel.Location = new Point(6, 74);
            debitCardCardHolderNameLabel.Name = "debitCardCardHolderNameLabel";
            debitCardCardHolderNameLabel.Size = new Size(102, 15);
            debitCardCardHolderNameLabel.TabIndex = 1;
            debitCardCardHolderNameLabel.Text = "Cardholder name:";
            // 
            // debitCardNumberLabel
            // 
            debitCardNumberLabel.AutoSize = true;
            debitCardNumberLabel.Location = new Point(6, 38);
            debitCardNumberLabel.Name = "debitCardNumberLabel";
            debitCardNumberLabel.Size = new Size(80, 15);
            debitCardNumberLabel.TabIndex = 0;
            debitCardNumberLabel.Text = "Card number:";
            // 
            // cashGB
            // 
            cashGB.Controls.Add(cashAmountTB);
            cashGB.Controls.Add(cashAmountLabel);
            cashGB.Location = new Point(277, 219);
            cashGB.Name = "cashGB";
            cashGB.Size = new Size(262, 68);
            cashGB.TabIndex = 8;
            cashGB.TabStop = false;
            // 
            // cashAmountTB
            // 
            cashAmountTB.Location = new Point(118, 27);
            cashAmountTB.Name = "cashAmountTB";
            cashAmountTB.Size = new Size(125, 23);
            cashAmountTB.TabIndex = 1;
            // 
            // cashAmountLabel
            // 
            cashAmountLabel.AutoSize = true;
            cashAmountLabel.Location = new Point(15, 30);
            cashAmountLabel.Name = "cashAmountLabel";
            cashAmountLabel.Size = new Size(82, 15);
            cashAmountLabel.TabIndex = 0;
            cashAmountLabel.Text = "Enter amount:";
            // 
            // creditCardGB
            // 
            creditCardGB.Controls.Add(creditCardCvvTB);
            creditCardGB.Controls.Add(creditCardExpirationDateTB);
            creditCardGB.Controls.Add(creditCardCardHolderNameTB);
            creditCardGB.Controls.Add(creditCardNumberTB);
            creditCardGB.Controls.Add(creditCardCVVLabel);
            creditCardGB.Controls.Add(creditCardExpirationDateLabel);
            creditCardGB.Controls.Add(creditCardCardHolderNameLabel);
            creditCardGB.Controls.Add(creditCardNumberLabel);
            creditCardGB.Location = new Point(204, 260);
            creditCardGB.Name = "creditCardGB";
            creditCardGB.Size = new Size(429, 177);
            creditCardGB.TabIndex = 4;
            creditCardGB.TabStop = false;
            // 
            // creditCardCvvTB
            // 
            creditCardCvvTB.Location = new Point(189, 135);
            creditCardCvvTB.Name = "creditCardCvvTB";
            creditCardCvvTB.Size = new Size(213, 23);
            creditCardCvvTB.TabIndex = 8;
            // 
            // creditCardExpirationDateTB
            // 
            creditCardExpirationDateTB.Location = new Point(189, 99);
            creditCardExpirationDateTB.Name = "creditCardExpirationDateTB";
            creditCardExpirationDateTB.Size = new Size(213, 23);
            creditCardExpirationDateTB.TabIndex = 7;
            // 
            // creditCardCardHolderNameTB
            // 
            creditCardCardHolderNameTB.Location = new Point(189, 63);
            creditCardCardHolderNameTB.Name = "creditCardCardHolderNameTB";
            creditCardCardHolderNameTB.Size = new Size(213, 23);
            creditCardCardHolderNameTB.TabIndex = 6;
            // 
            // creditCardNumberTB
            // 
            creditCardNumberTB.Location = new Point(189, 27);
            creditCardNumberTB.Name = "creditCardNumberTB";
            creditCardNumberTB.Size = new Size(213, 23);
            creditCardNumberTB.TabIndex = 5;
            // 
            // creditCardCVVLabel
            // 
            creditCardCVVLabel.AutoSize = true;
            creditCardCVVLabel.Location = new Point(6, 138);
            creditCardCVVLabel.Name = "creditCardCVVLabel";
            creditCardCVVLabel.Size = new Size(32, 15);
            creditCardCVVLabel.TabIndex = 3;
            creditCardCVVLabel.Text = "CVV:";
            // 
            // creditCardExpirationDateLabel
            // 
            creditCardExpirationDateLabel.AutoSize = true;
            creditCardExpirationDateLabel.Location = new Point(6, 102);
            creditCardExpirationDateLabel.Name = "creditCardExpirationDateLabel";
            creditCardExpirationDateLabel.Size = new Size(89, 15);
            creditCardExpirationDateLabel.TabIndex = 2;
            creditCardExpirationDateLabel.Text = "Expiration date:";
            // 
            // creditCardCardHolderNameLabel
            // 
            creditCardCardHolderNameLabel.AutoSize = true;
            creditCardCardHolderNameLabel.Location = new Point(6, 66);
            creditCardCardHolderNameLabel.Name = "creditCardCardHolderNameLabel";
            creditCardCardHolderNameLabel.Size = new Size(102, 15);
            creditCardCardHolderNameLabel.TabIndex = 1;
            creditCardCardHolderNameLabel.Text = "Cardholder name:";
            // 
            // creditCardNumberLabel
            // 
            creditCardNumberLabel.AutoSize = true;
            creditCardNumberLabel.Location = new Point(6, 30);
            creditCardNumberLabel.Name = "creditCardNumberLabel";
            creditCardNumberLabel.Size = new Size(80, 15);
            creditCardNumberLabel.TabIndex = 0;
            creditCardNumberLabel.Text = "Card number:";
            // 
            // MemberMakePayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 453);
            Controls.Add(cashGB);
            Controls.Add(debitCardGB);
            Controls.Add(submitButton);
            Controls.Add(backButton);
            Controls.Add(creditCardGB);
            Controls.Add(debitCardButton);
            Controls.Add(creditCardButton);
            Controls.Add(cashButton);
            Controls.Add(makePaymentLabel);
            Name = "MemberMakePayment";
            Text = "MemberMakePayment";
            debitCardGB.ResumeLayout(false);
            debitCardGB.PerformLayout();
            cashGB.ResumeLayout(false);
            cashGB.PerformLayout();
            creditCardGB.ResumeLayout(false);
            creditCardGB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public void UpdateComponent()
        {
            ResourceManager rm = new ResourceManager("Project_AD.Resources.Resources", typeof(Program).Assembly);

            backButton.Text = rm.GetString("backButton");

            creditCardNumberLabel.Text = rm.GetString("cardNumber");
            creditCardCardHolderNameLabel.Text = rm.GetString("cardHolderName");
            creditCardExpirationDateLabel.Text = rm.GetString("cardExpirationDate");
            creditCardCVVLabel.Text = rm.GetString("cardCVV");
            creditCardButton.Text = rm.GetString("creditCardButton");

            debitCardNumberLabel.Text = rm.GetString("cardNumber");
            debitCardCardHolderNameLabel.Text = rm.GetString("cardHolderName");
            debitCardExpirationDateLabel.Text = rm.GetString("cardExpirationDate");
            debitCardPinNumberLabel.Text = rm.GetString("cardPinNumber");
            debitCardButton.Text = rm.GetString("debitCardButton");

            cashAmountLabel.Text = rm.GetString("cashAmount");
            cashButton.Text = rm.GetString("cashButton");

            submitButton.Text = rm.GetString("submitButton");
        }

        private Label makePaymentLabel;
        private Button creditCardButton;
        private Button debitCardButton;

        private Button cashButton;

        private Button backButton;
        private Button submitButton;
        private GroupBox debitCardGB;
        private TextBox debitCardPinNumberTB;
        private TextBox debitCardExpirationDateTB;
        private TextBox debitCardCardHolderNameTB;
        private TextBox debitCardNumberTB;
        private Label debitCardPinNumberLabel;
        private Label debitCardExpirationDateLabel;
        private Label debitCardCardHolderNameLabel;
        private Label debitCardNumberLabel;
        private GroupBox creditCardGB;
        private TextBox creditCardCvvTB;
        private TextBox creditCardExpirationDateTB;
        private TextBox creditCardCardHolderNameTB;
        private TextBox creditCardNumberTB;
        private Label creditCardCVVLabel;
        private Label creditCardExpirationDateLabel;
        private Label creditCardCardHolderNameLabel;
        private Label creditCardNumberLabel;

        private GroupBox cashGB;
        private TextBox cashAmountTB;
        private Label cashAmountLabel;
    }
}