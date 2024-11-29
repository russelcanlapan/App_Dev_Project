using System;
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
    public partial class EmployeeRemoveMemberForm : Form
    {
        public EmployeeRemoveMemberForm()
        {
            InitializeComponent();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            FileSystemAPI.RemoveMember(int.Parse(MemberIdTB.Text));
        }
    }
}
