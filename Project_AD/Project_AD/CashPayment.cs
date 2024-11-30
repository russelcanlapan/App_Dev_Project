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

        public override void ProcessPayment()
        {
          
            Console.WriteLine($"Processing cash payment of {Amount:C} for {Member.FName} {Member.LName}");
        }
    }
}