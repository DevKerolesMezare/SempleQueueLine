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

        private void _LoadData()
        {
            lblCurrentTicket.Text = clsGlobal.QueueLine.Prefix.ToString();
        }

        private void ctrlServeTicket_Load(object sender, EventArgs e)
        {
            btnNext.Enabled = false;
            btnMarkServed.Enabled = false;
            btnSkip.Enabled = false;
            btnRecall.Enabled = false;
           
            _LoadData();
        }
  
        private void btnIsuueTicket_Click(object sender, EventArgs e)
        {
            clsGlobal.QueueLine.IssueTicket();
            OnStepCompleted();

            btnMarkServed.Enabled = true;
            btnSkip.Enabled = true;
            btnRecall.Enabled = true;
        }

        private void btnRecall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("7abiby Come To Here Hhh", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من تخطي هذه التذكرة", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                MessageBox.Show("تم اللغاء العملية", "Message");
                return;
            }
            else
                MessageBox.Show("تم تخطي التذكرة", "Message");

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
                MessageBox.Show("لا يوجد عملاء قيد الانتظار في هذه الصف", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            MessageBox.Show("تمت خدمة هذه التذكرة بنجاح", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
