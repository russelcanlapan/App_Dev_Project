using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_AD
{

    public abstract class Payment
    {
        public double Amount { get; set; }
        public PaymentType PaymentMethod { get; set; }
        public DateTime PaymentDate { get; set; }
        public User Member { get; set; } // Reference to the member making the payment

        // Constructor for creating a payment
        protected Payment(User member, double amount, PaymentType paymentMethod)
        {
            Member = member;
            PaymentMethod = paymentMethod;
            PaymentDate = DateTime.Now; // Set the payment date to now
            Amount = amount;
        }

        // Abstract method for processing payment
        public abstract void ProcessPayment();
    }
    public enum PaymentType
    {
        Cash,
        CreditCard,
        DebitCard
    }
}