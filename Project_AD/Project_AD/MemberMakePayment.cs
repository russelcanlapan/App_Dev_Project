using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_AD
{
    public partial class MemberMakePayment : Form
    {
        private string selectedPaymentMethod = "";

        public MemberMakePayment()
        {
            InitializeComponent();
            UpdateComponent();
            creditCardGB.Visible = false;
            debitCardGB.Visible = false;
            cashGB.Visible = false;
        }

        private void creditCardButton_Click(object sender, EventArgs e)
        {
            // Hide other groupboxes and reset fields for Credit Card
            creditCardGB.Visible = true;
            debitCardGB.Visible = false;
            cashGB.Visible = false;
            selectedPaymentMethod = "Credit";
            ResetFields();
        }

        private void debitCardButton_Click(object sender, EventArgs e)
        {
            // Hide other groupboxes and reset fields for Debit Card
            creditCardGB.Visible = false;
            debitCardGB.Visible = true;
            cashGB.Visible = false;
            selectedPaymentMethod = "Debit";
            ResetFields();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Hide the current form (MemberMakePayment)
            this.Hide();

            // Show the main form (MemberLogin)
            Application.OpenForms["MemberLogin"].Show();

            // Close the current form
            this.Close();
        }

        private void cashButton_Click(object sender, EventArgs e)
        {
            // Hide other groupboxes and reset fields for Cash
            creditCardGB.Visible = false;
            debitCardGB.Visible = false;
            cashGB.Visible = true;
            selectedPaymentMethod = "Cash";
            ResetFields();
        }
        /*
 * This method handles the submission of payment based on the selected payment method.
 * It checks if the required fields for the selected payment method (Credit, Debit, or Cash) are filled in.
 * If all fields are filled, a success message is displayed; otherwise, a prompt is shown to fill in the required fields.
 * param: sender, e
 * return: N/A
 */
        private void submitButton_Click(object sender, EventArgs e)
        {
            if (selectedPaymentMethod == "Credit" && AreCreditCardFieldsFilled())
            {
                MessageBox.Show("Payment Submitted");
            }
            else if (selectedPaymentMethod == "Debit" && AreDebitCardFieldsFilled())
            {
                MessageBox.Show("Payment Submitted");
            }
            else if (selectedPaymentMethod == "Cash" && AreCashFieldsFilled())
            {
                MessageBox.Show("Payment Submitted");
            }
            else
            {
                MessageBox.Show("Please fill in all the required fields for the selected payment method.");
            }
        }

        /*
 * This method checks if all required Credit Card fields are filled.
 * param: N/A
 * return: bool - true if all Credit Card fields are filled, otherwise false
 */
        private bool AreCreditCardFieldsFilled()
        {
            return !string.IsNullOrWhiteSpace(creditCardNumberTB.Text) &&
                   !string.IsNullOrWhiteSpace(creditCardExpirationDateTB.Text) &&
                   !string.IsNullOrWhiteSpace(creditCardCardHolderNameTB.Text) &&
                   !string.IsNullOrWhiteSpace(creditCardCvvTB.Text);
        }

        /*
  * This method checks if all required Debit Card fields are filled.
  * param: N/A
  * return: bool - true if all Debit Card fields are filled, otherwise false
  */
        private bool AreDebitCardFieldsFilled()
        {
            return !string.IsNullOrWhiteSpace(debitCardNumberTB.Text) &&
                   !string.IsNullOrWhiteSpace(debitCardExpirationDateTB.Text) &&
                   !string.IsNullOrWhiteSpace(debitCardCardHolderNameTB.Text) &&
                   !string.IsNullOrWhiteSpace(debitCardPinNumberTB.Text);
        }

        /*
 * This method checks if Cash fields are filled.
 * param: N/A
 * return: bool - true if the Cash field is filled, otherwise false
 */
        private bool AreCashFieldsFilled()
        {
            return !string.IsNullOrWhiteSpace(cashAmountTB.Text);
        }

        // Method to reset all fields based on the selected payment method
        private void ResetFields()
        {
            // Reset fields when switching to Credit Card
            if (selectedPaymentMethod == "Credit")
            {
                creditCardNumberTB.Clear();
                creditCardExpirationDateTB.Clear();
                creditCardCardHolderNameTB.Clear();
                creditCardCvvTB.Clear();
            }
            // Reset fields when switching to Debit Card
            else if (selectedPaymentMethod == "Debit")
            {
                debitCardNumberTB.Clear();
                debitCardExpirationDateTB.Clear();
                debitCardCardHolderNameTB.Clear();
                debitCardPinNumberTB.Clear();
            }
            // Reset fields when switching to Cash
            else if (selectedPaymentMethod == "Cash")
            {
                cashAmountTB.Clear();
            }
        }
    }
}

