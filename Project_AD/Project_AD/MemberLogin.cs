﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_AD
{
    public partial class MemberLogin : Form
    {
        public MemberLogin()
        {
            InitializeComponent();
            UpdateComponent();
        }

        private void viewProfileButton_Click(object sender, EventArgs e)
        {
            ViewProfile viewProfile = new ViewProfile();
            viewProfile.ShowDialog();
        }
    }
}
