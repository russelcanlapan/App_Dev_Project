using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_AD
{
    public interface IPayment
    {
        PaymentType GetPaymentType();
    }

    public enum PaymentType
    {
        Cash,
        CreditCard,
        DebitCard
    }
}
