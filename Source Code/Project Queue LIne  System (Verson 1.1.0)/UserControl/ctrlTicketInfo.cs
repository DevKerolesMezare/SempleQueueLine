using QueueLine_Project.Classes;
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
    public partial class ctrlTicketInfo : UserControl
    {

        private clsTickets _ticket;

        public string _ticketNumber { get; set; }


        public ctrlTicketInfo() => InitializeComponent();

        //public ctrlTicketInfo(string FullNumber)
        //{
        //    InitializeComponent();

        //    if (!string.IsNullOrEmpty(FullNumber)) this._ticketNumber = FullNumber;
        //    else this._ticketNumber = "";
        //}


        private void LoadTicketInfo()
         {
            _ticket = clsQueueLine.FindTicketByFullNumber(this._ticketNumber);

            if (_ticket == null)
                return;

                lblQueueName.Text = _ticket.QueueName.Trim();
                lblPrefix.Text = _ticket.Prefix.Trim();
                lblNumber.Text = _ticket.TicketNumber.ToString();
                lblTime.Text = _ticket.TicketTime.ToShortTimeString().ToString();

                lblWatingClient.Text = _ticket.WatingClients.ToString();
                lblExpTime.Text = _ticket.ExpectedServeTime().ToString();      
        }


    

        private void ctrlTicketInfo_Load(object sender, EventArgs e)
        {
            LoadTicketInfo();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
