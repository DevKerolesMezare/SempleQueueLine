using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLine_Project.Classes
{
    public class clsTickets
    {
        public string QueueName { get; }
        public string Prefix { get; }
        public short TicketNumber { get; }
        public DateTime TicketTime { get; }
        public short WatingClients { get; set; }
        public short AverageServeTime { get; }
        public int ExpectedWaitTime { get; set; }



        public clsTickets(string Prefix,string queueName, short TicketNumber, short WaitingClients, short AverageServeTime)
        {
            this.Prefix = Prefix;
            this.QueueName = queueName;
            this.TicketNumber = TicketNumber;
            this.WatingClients = WaitingClients;
            this.AverageServeTime = AverageServeTime;

            this.TicketTime = DateTime.Now;
         
        }

        public string FullNumber()
        {
            return (Prefix + "0" + Convert.ToString(TicketNumber));
        }

        public int ExpectedServeTime()
        {
            return (AverageServeTime * WatingClients);
        }


        public static DataTable CreateTicketTableStructure()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("FullNumber", typeof(string));
            dt.Columns.Add("TicketTime", typeof(DateTime));
            dt.Columns.Add("WatingClients", typeof(short));
            dt.Columns.Add("Serve_Time_in", typeof(int));
            return dt;
        }

        public DataTable GetTicketInfo()
        {
            DataTable dt = CreateTicketTableStructure();

            DataRow row = dt.NewRow();

            row["FullNumber"] = FullNumber();
            row["TicketTime"] = this.TicketTime;
            row["WatingClients"] = this.WatingClients;
            row["Serve_Time_in"] = ExpectedServeTime();

            dt.Rows.Add(row);
            return dt;
        }

    }
}
