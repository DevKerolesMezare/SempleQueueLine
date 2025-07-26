using QueueLine_Project;
using QueueLine_Project.Classes;
using QueueLine_Project.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueLine_UI.UserControls
{
    public partial class ctrlTicketController : UserControl
    {
        public ctrlTicketController() => InitializeComponent();

        public event EventHandler StepCompleted;

        protected virtual void OnStepCompleted()
        {
            StepCompleted?.Invoke(this, EventArgs.Empty);
        }

        private void ctrlServeTicket_Load(object sender, EventArgs e)
        {
            btnNext.Enabled = false;
            btnMarkServed.Enabled = false;
            btnSkip.Enabled = false;
            btnRecall.Enabled = false;
           
        }
  
        private void btnIsuueTicket_Click(object sender, EventArgs e)
        {
            if (clsGlobal.QueueLine.queueLine.Count == 0)
            {
                btnMarkServed.Enabled = true;
                btnSkip.Enabled = true;
                btnRecall.Enabled = true;
            }

            clsGlobal.QueueLine.IssueTicket();

            if (clsGlobal.QueueLine.queueLine.Count == 1)
            {
                lblCurrentTicket.Text = clsGlobal.QueueLine.WhoisNext().ToString();
            }

            OnStepCompleted();          
        }

        private void btnRecall_Click(object sender, EventArgs e)
        {
            // ممكن تعمل هنا حدث اول ما الميثود دي تتنادي يروح يتصل او يبعت رساله للعميل الحالي
            MessageBox.Show("Please come to the counter (Testing Message)", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to skip this ticket?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                MessageBox.Show("Operation cancelled", "Message");
                return;
            }
            else
                MessageBox.Show("Ticket skipped", "Message");

            /// اشعار

            // Skip
            clsGlobal.QueueLine.SkipCurrentClient().ToString();

            //
            btnNext.Enabled = true;

            //
            btnSkip.Enabled = false;

            //
            btnRecall.Enabled = false;

            btnMarkServed.Enabled = false;

            OnStepCompleted();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (clsGlobal.QueueLine.GetAllTickets().Rows.Count == 0)
            {
                MessageBox.Show("No clients are currently in this queue", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblCurrentTicket.Text = "A00";
                btnNext.Enabled = false;
                    return;
            }


            lblCurrentTicket.Text = clsGlobal.QueueLine.WhoisNext().ToString();


            //
            btnNext.Enabled = false;

            //
            btnMarkServed.Enabled = true;

            //
            btnRecall.Enabled = true;

            // 
            btnSkip.Enabled = true;

            OnStepCompleted();
        }

        private void btnMarkServed_Click(object sender, EventArgs e)
        {

            clsGlobal.QueueLine.ServeNextClient().ToString();

            MessageBox.Show("Ticket served successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //
            btnMarkServed.Enabled = false;

            //
            btnRecall.Enabled = false;

            // 
            btnSkip.Enabled = false;


            btnNext.Enabled = true;

            OnStepCompleted();
        }
   
    }
}
