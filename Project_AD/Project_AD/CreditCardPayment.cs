using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_AD
{
    public class CreditCardPayment : Payment
    {
        public string CreditCardNumber { get; set; }

        public CreditCardPayment(User member, double amount, string creditCardNumber)
            : base(member, amount, PaymentType.CreditCard)
        {
            CreditCardNumber = creditCardNumber;
        }

      
        public override void ProcessPayment()
        {
        
            Console.WriteLine($"Processing credit card payment of {Amount:C} for {Member.FName} {Member.LName} using card {CreditCardNumber}");
        }
    }
}