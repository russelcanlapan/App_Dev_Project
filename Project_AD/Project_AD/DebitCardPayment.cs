using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_AD
{
    public class DebitCardPayment : Payment
    {
        public string DebitCardNumber { get; set; }

        public DebitCardPayment(User member, double amount, string debitCardNumber)
            : base(member, amount, PaymentType.DebitCard)
        {
            DebitCardNumber = debitCardNumber;
        }


 /*
 * This method processes a payment and displays a message indicating the amount
 * and the member's full name.
 * param: N/A
 * return: N/A (overridden method providing specific implementation for cash payment)
 */

        public override void ProcessPayment()
        {
      
            Console.WriteLine($"Processing debit card payment of {Amount:C} for {Member.FName} {Member.LName} using card {DebitCardNumber}");
        }
    }
}