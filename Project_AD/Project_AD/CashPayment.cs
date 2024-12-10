using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_AD
{
    public class CashPayment : Payment
    {
        public CashPayment(User member, double amount)
            : base(member, amount, PaymentType.Cash)
        {
        }

 /*
 * This method processes a payment and displays a message indicating the amount
 * and the member's full name.
 * param: N/A
 * return: N/A (overridden method providing specific implementation for cash payment)
 */

        public override void ProcessPayment()
        {
          
            Console.WriteLine($"Processing cash payment of {Amount:C} for {Member.FName} {Member.LName}");
        }
    }
}