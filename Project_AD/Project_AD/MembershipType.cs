﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_AD
{
    public enum MembershipType
    {
        Regular,
        Premium
    }

    public static class MembershipTypeExtensions
    {
        public static double MonthlyPrice(this MembershipType type)
        {
            return type switch
            {
                MembershipType.Regular => 19.99,
                MembershipType.Premium => 29.99,
                _ => throw new System.ArgumentOutOfRangeException(nameof(type), "Invalid membership type")
            };
        }

        public static double YearlyPrice(this MembershipType type)
        {
            return type switch
            {
                MembershipType.Regular => 259.75,
                MembershipType.Premium => 389.75,
                _ => throw new System.ArgumentOutOfRangeException(nameof(type), "Invalid membership type")
            };
        }
    }
}
