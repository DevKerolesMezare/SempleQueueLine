using QueueLine_Project.Classes;
using System;
using System.Collections;
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
    public partial class frmtest : Form
    {
        public frmtest()
        {
            InitializeComponent();
        }


        private void _LoadData()
        {
            dataGridView1.DataSource = clsGlobal.QueueLine.GetAllTickets();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsGlobal.QueueLine.IssueTicket();

            lblTotalTickets.Text = clsGlobal.QueueLine.TotalTickets.ToString();
            lblAvreageTime.Text = clsGlobal.QueueLine.AverageServeTime.ToString();
            lblServedClient.Text = clsGlobal.QueueLine.ServedClients().ToString();
            lblWatingClient.Text = clsGlobal.QueueLine.WaitingClients().ToString();

            _LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clsGlobal.QueueLine.ServeNextClient();
            lblTotalTickets.Text = clsGlobal.QueueLine.TotalTickets.ToString();
            lblAvreageTime.Text = clsGlobal.QueueLine.AverageServeTime.ToString();
            lblServedClient.Text = clsGlobal.QueueLine.ServedClients().ToString();
            lblWatingClient.Text = clsGlobal.QueueLine.WaitingClients().ToString();

            _LoadData();

        }

        private void ctrlServeTicket1_Load(object sender, EventArgs e)
        {

        }

        private void btnSkippedClient_Click(object sender, EventArgs e)
        {
            clsGlobal.QueueLine.SkipCurrentClient();

            lblScippedClient.Text = clsGlobal.QueueLine.SkippedClients.ToString();
            _LoadData();
        }

        private void ctrlServeTicket1_StepCompleted(object sender, EventArgs e)
        {

        }

        private void ctrlServeTicket1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
