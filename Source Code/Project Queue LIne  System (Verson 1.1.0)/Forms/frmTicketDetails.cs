using QueueLine_Project.usercontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueLine_Project.Forms
{
    public partial class frmTicketDetails : Form
    {

        public frmTicketDetails(string TicketNumber)
        {
            InitializeComponent();

            ctrlTicketInfo1._ticketNumber = TicketNumber;
        }
    }
}
