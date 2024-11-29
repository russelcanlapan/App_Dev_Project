﻿using System;
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
            this.Hide();

            EmployeeAddMemberForm employeeAddMemberForm = new EmployeeAddMemberForm();
            employeeAddMemberForm.ShowDialog();

            this.Show();
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

        private void ViewMemberBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            EmployeeViewMemberForm emp = new EmployeeViewMemberForm();
            emp.ShowDialog();

            this.Show();
        }

        private void RemoveMemberBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            EmployeeRemoveMemberForm emp = new EmployeeRemoveMemberForm();
            emp.ShowDialog();

            this.Show();
        }
    }
}
