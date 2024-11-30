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
    public partial class MemberViewNotifications : Form
    {
        public MemberViewNotifications()
        {
            InitializeComponent();
            notificationTimer.Interval = 5000; 
            notificationTimer.Tick += NotificationTimer_Tick;
        }

        public void ShowNotification(string message)
        {
            
            notificationLabel.Text = message;
            notificationLabel.Visible = true;
            notificationTimer.Start();
        }

        private void NotificationTimer_Tick(object sender, EventArgs e)
        {
            
            notificationLabel.Visible = false;
            notificationTimer.Stop();
        }

    }
}
