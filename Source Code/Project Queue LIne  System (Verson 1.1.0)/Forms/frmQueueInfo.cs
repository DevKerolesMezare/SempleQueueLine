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
    public partial class frmQueueInfo : Form
    {
         public frmQueueInfo()
        {
            InitializeComponent();
        }

        public ctrlQueueInfo CtrlQueue1 => ctrlQueueInfo1;

        private void frmQueueInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
