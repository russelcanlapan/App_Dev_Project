using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_AD
{
    public class Member : User
    {
        private static int memberIdCounter = 1;
        public string MemberId { get; private set; }
        public Membership MembershipType { get; set; }
        public double Balance { get; set; }
        public static List<Notification> Notifications { get; private set; } = new List<Notification>();

        public Member(string fname, string lname, Address address, string phoneNumber, Membership membershipType, double balance)
            : base(fname, lname, address, phoneNumber)
        {
            MemberId = memberIdCounter++.ToString();
            MembershipType = membershipType;
            Balance = balance;
        }

        public static void AddNotification(Notification notification)
        {
            Notifications.Add(notification);
        }
    }
}
