using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_AD
{
    public class Membership
    {
        public MembershipType Type { get; set; }

        public Membership(MembershipType type)
        {
            Type = type;
        }

        /// <summary>
        /// Gets the price based on the payment frequency.
        /// </summary>
        /// <param name="frequencyType">Frequency of the payment, either "monthly" or "yearly".</param>
        /// <returns>The price for the given frequency.</returns>
        public double GetPrice(string frequencyType)
        {
            if (frequencyType.Equals("monthly", System.StringComparison.OrdinalIgnoreCase))
            {
                return Type.MonthlyPrice;
            }
            else if (frequencyType.Equals("yearly", System.StringComparison.OrdinalIgnoreCase))
            {
                return Type.YearlyPrice;
            }
            throw new System.ArgumentException("Invalid frequency: " + frequencyType);
        }
    }
}
