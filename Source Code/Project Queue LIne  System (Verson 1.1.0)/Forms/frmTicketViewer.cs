using QueueLine_Project.usercontrols;
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

namespace QueueLine_Project.Forms
{
    public partial class frmTicketViewer : Form
    {


        public ctrlTicketViewer ctrlTicketViewer => ctrlTicketViewer1;

        public frmTicketViewer()
        {
            InitializeComponent();
        }

        private void frmTicketViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
