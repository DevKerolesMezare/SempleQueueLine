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
    public partial class ctrlTicketQueueScreen : UserControl
    {

        public ctrlTicketQueueScreen()
=> InitializeComponent();

        public void SubscribeToServeTicket() // اسنقبال اي تغيير 
        {
            ctrlTicketController1.StepCompleted += (s, e) =>
            {
                PopulateTicketsInTablePanel();

                frmQueue.CtrlQueue1.RefreshTickets();
                frmTicketViewer1.ctrlTicketViewer.ShowTicket();
                lblTotalTickets.Text = clsGlobal.QueueLine.GetAllTickets().Rows.Count.ToString();
            };
        }

        void RenderTickets(List<string> tickets)  // Chat GPT
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.ColumnCount = tickets.Count;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            // صف واحد فقط بارتفاع ثابت
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));

            for (int i = 0; i < tickets.Count; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150));

                Label lbl = new Label();
                lbl.Text = tickets[i];
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Dock = DockStyle.Fill;
                lbl.Margin = new Padding(5);
                lbl.BackColor = Color.White;
                lbl.BorderStyle = BorderStyle.FixedSingle;
                lbl.Font = new Font("Segoe UI", 12, FontStyle.Bold);

                tableLayoutPanel1.Controls.Add(lbl, i, 0); // col=i, row=0

              
                   
                lbl.Cursor = Cursors.Hand; // تخلي شكل الماوس يتغير لما ييجي على الليبل
                lbl.Click += tableLayoutPanel1_Click;
                                  
            }
        }

        private void ctrlFilterTicketsByQueueName_Load(object sender, EventArgs e)
        {
            SubscribeToServeTicket();

            cbQueueName.Items.Add(clsGlobal.QueueLine.queueName.ToString());
            cbQueueName.SelectedIndex = 0;       
        }

        private void PopulateTicketsInTablePanel()
        {
            List<string> fullNumbers = clsGlobal.QueueLine.GetAllTickets().AsEnumerable().Select(row => row["FullNumber"].ToString()).ToList();

            RenderTickets(fullNumbers);
        }

        private void lblTotalTickets_Click(object sender, EventArgs e)
        {
            PopulateTicketsInTablePanel();
        }


        private frmQueueInfo frmQueue = new frmQueueInfo();
        private void button1_Click(object sender, EventArgs e)
        {
            frmQueue.Show();
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                //string ticketNumber = clickedLabel.Text;
                //MessageBox.Show("تم اختيار التذكرة رقم: " + ticketNumber);


                frmTicketDetails frm = new frmTicketDetails(clickedLabel.Text); // table panal  this lable text
                frm.ShowDialog();
            }
        }

        private frmTicketViewer frmTicketViewer1 = new frmTicketViewer();
        private void btnAllTickets_Click(object sender, EventArgs e)
        {          
            frmTicketViewer1.Show();
        }
    }
}
