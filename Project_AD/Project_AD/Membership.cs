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

        /*
   * This method retrieves the price based on the frequency type.
   * It returns the monthly price if the frequency is "monthly", 
   * or the yearly price if the frequency is "yearly". 
   * If the frequency is invalid, it throws an ArgumentException.
   * param: frequencyType
   * return: double
   */
        public double GetPrice(string frequencyType)
        {
            if (frequencyType.Equals("monthly", System.StringComparison.OrdinalIgnoreCase))
            {
                return Type.MonthlyPrice();
            }
            else if (frequencyType.Equals("yearly", System.StringComparison.OrdinalIgnoreCase))
            {
                return Type.YearlyPrice();
            }
            throw new System.ArgumentException("Invalid frequency: " + frequencyType);
        }
    }
}
