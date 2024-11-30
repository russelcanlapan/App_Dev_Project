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
            creditCardGB = new GroupBox();
            creditCardCvvTB = new TextBox();
            creditCardExpirationDateTB = new TextBox();
            creditCardCardHolderNameTB = new TextBox();
            creditCardNumberTB = new TextBox();
            creditCardCVVLabel = new Label();
            creditCardExpirationDateLabel = new Label();
            creditCardCardHolderNameLabel = new Label();
            creditCardNumberLabel = new Label();
            debitCardGB = new GroupBox();
            debitCardPinNumberTB = new TextBox();
            debitCardExpirationDateTB = new TextBox();
            debitCardCardHolderNameTB = new TextBox();
            debitCardNumberTB = new TextBox();
            debitCardPinNumberLabel = new Label();
            debitCardExpirationDateLabel = new Label();
            debitCardCardHolderNameLabel = new Label();
            debitCardNumberLabel = new Label();
            cashButton = new Button();
            creditCardGB.SuspendLayout();
            debitCardGB.SuspendLayout();
            SuspendLayout();
            // 
            // makePaymentLabel
            // 
            makePaymentLabel.AutoSize = true;
            makePaymentLabel.Location = new Point(575, 33);
            makePaymentLabel.Name = "makePaymentLabel";
            makePaymentLabel.Size = new Size(86, 15);
            makePaymentLabel.TabIndex = 0;
            makePaymentLabel.Text = "Make Payment";
            // 
            // creditCardButton
            // 
            creditCardButton.Location = new Point(391, 125);
            creditCardButton.Name = "creditCardButton";
            creditCardButton.Size = new Size(75, 23);
            creditCardButton.TabIndex = 2;
            creditCardButton.Text = "Credit Card";
            creditCardButton.UseVisualStyleBackColor = true;
            // 
            // debitCardButton
            // 
            debitCardButton.Location = new Point(848, 125);
            debitCardButton.Name = "debitCardButton";
            debitCardButton.Size = new Size(75, 23);
            debitCardButton.TabIndex = 3;
            debitCardButton.Text = "Debit Card";
            debitCardButton.UseVisualStyleBackColor = true;
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
            creditCardGB.Location = new Point(254, 204);
            creditCardGB.Name = "creditCardGB";
            creditCardGB.Size = new Size(356, 177);
            creditCardGB.TabIndex = 4;
            creditCardGB.TabStop = false;
            // 
            // creditCardCvvTB
            // 
            creditCardCvvTB.Location = new Point(156, 135);
            creditCardCvvTB.Name = "creditCardCvvTB";
            creditCardCvvTB.Size = new Size(174, 23);
            creditCardCvvTB.TabIndex = 8;
            // 
            // creditCardExpirationDateTB
            // 
            creditCardExpirationDateTB.Location = new Point(156, 99);
            creditCardExpirationDateTB.Name = "creditCardExpirationDateTB";
            creditCardExpirationDateTB.Size = new Size(174, 23);
            creditCardExpirationDateTB.TabIndex = 7;
            // 
            // creditCardCardHolderNameTB
            // 
            creditCardCardHolderNameTB.Location = new Point(156, 63);
            creditCardCardHolderNameTB.Name = "creditCardCardHolderNameTB";
            creditCardCardHolderNameTB.Size = new Size(174, 23);
            creditCardCardHolderNameTB.TabIndex = 6;
            // 
            // creditCardNumberTB
            // 
            creditCardNumberTB.Location = new Point(156, 27);
            creditCardNumberTB.Name = "creditCardNumberTB";
            creditCardNumberTB.Size = new Size(174, 23);
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
            debitCardGB.Location = new Point(726, 204);
            debitCardGB.Name = "debitCardGB";
            debitCardGB.Size = new Size(353, 177);
            debitCardGB.TabIndex = 5;
            debitCardGB.TabStop = false;
            // 
            // debitCardPinNumberTB
            // 
            debitCardPinNumberTB.Location = new Point(147, 135);
            debitCardPinNumberTB.Name = "debitCardPinNumberTB";
            debitCardPinNumberTB.Size = new Size(174, 23);
            debitCardPinNumberTB.TabIndex = 7;
            // 
            // debitCardExpirationDateTB
            // 
            debitCardExpirationDateTB.Location = new Point(147, 99);
            debitCardExpirationDateTB.Name = "debitCardExpirationDateTB";
            debitCardExpirationDateTB.Size = new Size(174, 23);
            debitCardExpirationDateTB.TabIndex = 6;
            // 
            // debitCardCardHolderNameTB
            // 
            debitCardCardHolderNameTB.Location = new Point(147, 63);
            debitCardCardHolderNameTB.Name = "debitCardCardHolderNameTB";
            debitCardCardHolderNameTB.Size = new Size(174, 23);
            debitCardCardHolderNameTB.TabIndex = 5;
            // 
            // debitCardNumberTB
            // 
            debitCardNumberTB.Location = new Point(147, 27);
            debitCardNumberTB.Name = "debitCardNumberTB";
            debitCardNumberTB.Size = new Size(174, 23);
            debitCardNumberTB.TabIndex = 4;
            // 
            // debitCardPinNumberLabel
            // 
            debitCardPinNumberLabel.AutoSize = true;
            debitCardPinNumberLabel.Location = new Point(6, 138);
            debitCardPinNumberLabel.Name = "debitCardPinNumberLabel";
            debitCardPinNumberLabel.Size = new Size(74, 15);
            debitCardPinNumberLabel.TabIndex = 3;
            debitCardPinNumberLabel.Text = "Pin Number:";
            // 
            // debitCardExpirationDateLabel
            // 
            debitCardExpirationDateLabel.AutoSize = true;
            debitCardExpirationDateLabel.Location = new Point(6, 102);
            debitCardExpirationDateLabel.Name = "debitCardExpirationDateLabel";
            debitCardExpirationDateLabel.Size = new Size(89, 15);
            debitCardExpirationDateLabel.TabIndex = 2;
            debitCardExpirationDateLabel.Text = "Expiration date:";
            // 
            // debitCardCardHolderNameLabel
            // 
            debitCardCardHolderNameLabel.AutoSize = true;
            debitCardCardHolderNameLabel.Location = new Point(6, 66);
            debitCardCardHolderNameLabel.Name = "debitCardCardHolderNameLabel";
            debitCardCardHolderNameLabel.Size = new Size(102, 15);
            debitCardCardHolderNameLabel.TabIndex = 1;
            debitCardCardHolderNameLabel.Text = "Cardholder name:";
            // 
            // debitCardNumberLabel
            // 
            debitCardNumberLabel.AutoSize = true;
            debitCardNumberLabel.Location = new Point(6, 30);
            debitCardNumberLabel.Name = "debitCardNumberLabel";
            debitCardNumberLabel.Size = new Size(80, 15);
            debitCardNumberLabel.TabIndex = 0;
            debitCardNumberLabel.Text = "Card number:";
            // 
            // cashButton
            // 
            cashButton.Location = new Point(32, 125);
            cashButton.Name = "cashButton";
            cashButton.Size = new Size(85, 23);
            cashButton.TabIndex = 1;
            cashButton.Text = "Cash";
            cashButton.UseVisualStyleBackColor = true;
            // 
            // MemberMakePayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 478);
            Controls.Add(debitCardGB);
            Controls.Add(creditCardGB);
            Controls.Add(debitCardButton);
            Controls.Add(creditCardButton);
            Controls.Add(cashButton);
            Controls.Add(makePaymentLabel);
            Name = "MemberMakePayment";
            Text = "MemberMakePayment";
            creditCardGB.ResumeLayout(false);
            creditCardGB.PerformLayout();
            debitCardGB.ResumeLayout(false);
            debitCardGB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label makePaymentLabel;
        private Button creditCardButton;
        private Button debitCardButton;

        //Credit card
        private GroupBox creditCardGB;
        private Label creditCardNumberLabel;
        private Label creditCardCardHolderNameLabel;
        private Label creditCardExpirationDateLabel;
        private Label creditCardCVVLabel;
        private TextBox creditCardNumberTB;
        private TextBox creditCardCardHolderNameTB;
        private TextBox creditCardExpirationDateTB;
        private TextBox creditCardCvvTB;

        //Debit card
        private GroupBox debitCardGB;
        private TextBox debitCardNumberTB;
        private TextBox debitCardCardHolderNameTB;
        private TextBox debitCardExpirationDateTB;
        private TextBox debitCardPinNumberTB;
        private Label debitCardNumberLabel;
        private Label debitCardCardHolderNameLabel;
        private Label debitCardExpirationDateLabel;
        private Label debitCardPinNumberLabel;

        private Button cashButton;
    }
}