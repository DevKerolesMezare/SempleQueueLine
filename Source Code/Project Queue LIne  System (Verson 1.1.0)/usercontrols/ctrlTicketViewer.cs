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
    public partial class ctrlTicketViewer : UserControl
    {
        public ctrlTicketViewer()
        {
            InitializeComponent();
        }

        private clsTickets _tickets;

        private short _CurrentTicket = 0;


        public void ShowTicket()  // and Refresh
        {

            if (clsGlobal.QueueLine.queueLine.Count ==0)
                return;

            

            if (_CurrentTicket < 0)
            {
                _CurrentTicket = 0;

                MessageBox.Show("No tickets available", "Ticket Viewer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(_CurrentTicket > clsGlobal.QueueLine.queueLine.Count-1)
            {
                _CurrentTicket--;

                MessageBox.Show("No tickets available", "Ticket Viewer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _tickets = clsGlobal.QueueLine.queueLine.ToList()[_CurrentTicket];
            ctrlTicketInfo1._ticketNumber = _tickets.FullNumber();
            ctrlTicketInfo1.RefreshTicket();   // 
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _CurrentTicket++;
            ShowTicket();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            _CurrentTicket--;
            ShowTicket();
        }
    }
}
