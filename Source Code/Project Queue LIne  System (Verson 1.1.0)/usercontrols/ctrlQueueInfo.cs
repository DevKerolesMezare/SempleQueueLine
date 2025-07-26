using QueueLine_Project.Classes;
using QueueLine_UI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueLine_Project.usercontrols
{
    public partial class ctrlQueueInfo : UserControl
    {
        public ctrlQueueInfo()
           => InitializeComponent();
   

        public void RefreshTickets()
        {
            _LoadData();
        }

        private void _LoadData()
        {
            lblQueueName.Text = clsGlobal.QueueLine.queueName.Trim();
            lblPrefix.Text = clsGlobal.QueueLine.Prefix.Trim();
            lblTotalTickets.Text = clsGlobal.QueueLine.TotalTickets.ToString();
            lblCanceled.Text = clsGlobal.QueueLine.SkippedClients.ToString(); //Skip
            lblServedClient.Text = clsGlobal.QueueLine.ServedClients().ToString();
            lblWatingClient.Text = clsGlobal.QueueLine.WaitingClients().ToString();
        }

        private void ctrlQueueInfo_Load(object sender, EventArgs e)
        {
            RefreshTickets();
            _LoadData();
        }


    }
}
