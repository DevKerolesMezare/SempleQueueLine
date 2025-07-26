using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueLine_Project.Classes
{
    public class clsQueueLine 
    {
        public Queue<clsTickets> queueLine = new Queue<clsTickets>();

        public string queueName { get; }
        public string Prefix { get; }
        public short TotalTickets { get; private set; }
        public short AverageServeTime { get; private set; }

        public short SkippedClients { get; private set; }

        public clsQueueLine(string queueName, string Prefix, short AverageServeTime)
        {
            this.queueName = queueName; 
            this.Prefix = Prefix;
            this.TotalTickets = 0;
            this.AverageServeTime = AverageServeTime;
        }

        public int WaitingClients()
        {
            return queueLine.Count;
        }

        public int ServedClients()
        {
            return TotalTickets - WaitingClients() - SkippedClients;
        }

        public bool ServeNextClient()
        {
            if (queueLine.Count == 0)
                return false;

            queueLine.Dequeue();  // pop
            return true;
        }

        public bool SkipCurrentClient()
        {
            if (queueLine.Count == 0)
                return false;

            queueLine.Dequeue(); // remove from queue
            SkippedClients++;    // count it as skipped
            return true;
        }

        public string WhoisNext()
        {
            if (queueLine.Count == 0)
            {
                return "No Clients Left.";
            }
            else
                return queueLine.Peek().FullNumber();
        }

        public void IssueTicket()
        {
            TotalTickets++;
            clsTickets tickets = new clsTickets(Prefix, queueName, TotalTickets, (short)WaitingClients(), AverageServeTime);

            queueLine.Enqueue(tickets); // push
        }

        public DataTable GetAllTickets()
        {
            DataTable dt =  clsTickets.CreateTicketTableStructure();

            foreach (clsTickets ticket in queueLine)
            {
                DataTable row = ticket.GetTicketInfo();

                dt.Rows.Add(row.Rows[0].ItemArray);
            }

            return dt;
        }


        public clsTickets FindTicketByFullNumber(string FullNumber)
        {
            foreach (clsTickets ticket in queueLine)
            {
                if(ticket.FullNumber() == FullNumber)
                    return ticket;
            }
           return null;
        }

    }
}
