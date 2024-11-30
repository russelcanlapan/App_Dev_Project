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
    public partial class MemberManage : Form
    {
        public int MemberId { get; set; }
        public MemberManage(int memberId)
        {
            InitializeComponent();
            MemberId = memberId;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

            MembershipType selectedMembershipType = regularRB.Checked ? MembershipType.Regular : MembershipType.Premium;

            string selectedFrequencyType = monthlyRB.Checked ? "Monthly" : "Yearly";
            string memberFilePath = "members.txt"; 
            string memberData = FileSystemAPI.GetMemberById(MemberId);


            if (memberData == null)
            {
                MessageBox.Show("Member not found.");
                return;
            }

            string[] memberDataArray = memberData.Split(',');
            memberDataArray[9] = selectedMembershipType.ToString();
            string updatedMemberData = string.Join(",", memberDataArray);

            string tempFilePath = "tempFile.txt";
            bool memberFound = false;

            using (StreamReader reader = new StreamReader(memberFilePath))
            using (StreamWriter writer = new StreamWriter(tempFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line == memberData)
                    {
                        writer.WriteLine(updatedMemberData);
                        memberFound = true;
                    }
                    else
                    {
                        writer.WriteLine(line);
                    }
                }
            }

            if (memberFound)
            {
                File.Delete(memberFilePath);
                File.Move(tempFilePath, memberFilePath);
                MessageBox.Show("Member's membership type and frequency updated.");
            }
            else
            {
                MessageBox.Show("Member not found.");
            }
        }
    private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you would like to cancel your membership?", "Cancel?", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    FileSystemAPI.RemoveMember(MemberId);
                    break;
                case DialogResult.No:
                    break;
            }
        }
    }
}
