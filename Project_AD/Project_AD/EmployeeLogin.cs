using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_AD
{
    public partial class EmployeeLogin : Form
    {
        Member member;
        Address address;
        List<Member> members;
        Membership membership;
        public EmployeeLogin()
        {
            InitializeComponent();
        }

        private void AddMemberBtn_Click(object sender, EventArgs e)
        {
            if (isValidName(FNameTB.Text) && isValidName(LNameTB.Text) && isValidName(StreetNameTB.Text)
                && isValidName(ProvinceTB.Text) && isValidName(CityTB.Text) && isValidNumber(StreetNumberTB.Text)
                && isValidNumber(PhoneTB.Text) && isValidNumber(BalanceTB.Text))
            {
                address = new Address(int.Parse(StreetNumberTB.Text), StreetNameTB.Text, CityTB.Text, ProvinceTB.Text, ZipcodeTB.Text);
                if (RegularRB.Checked) 
                {
                    membership = new Membership(MembershipType.Regular);
                    member = new Member(FNameTB.Text, LNameTB.Text, address, PhoneTB.Text, membership, double.Parse(BalanceTB.Text));
                } else
                {
                    membership = new Membership(MembershipType.Premium);
                    member = new Member(FNameTB.Text, LNameTB.Text, address, PhoneTB.Text, membership, double.Parse(BalanceTB.Text));
                }
            }
        }

        private static bool isValidName(string Name)
        {
            foreach (char c in Name)
            {
                if (!char.IsLetter(c) && c != ' ' && c != '-')
                {
                    return false;
                }
            }
            return true;
        }

        private static bool isValidNumber(string Num)
        {
            foreach (char c in Num)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
