using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace BuyTicket
{
    
    public partial class Form2 : Form
    {
        public static bool first=true;
        public static string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TicketBase.accdb";
        public OleDbConnection myConnection;
        public Form2()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connection);
            myConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.ticketTableTableAdapter.Fill(this.ticketBaseDataSet.TicketTable);
            if (first)
            {
                this.ticketTableTableAdapter.Fill(this.ticketBaseDataSet.TicketTable);
                string quary = "DELETE FROM TicketTable";
                OleDbCommand command1 = new OleDbCommand(quary, myConnection);
                command1.ExecuteNonQuery();
                
            }
            else
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "ticketBaseDataSet.TicketTable". При необходимости она может быть перемещена или удалена.
                this.ticketTableTableAdapter.Fill(this.ticketBaseDataSet.TicketTable);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ticketTableTableAdapter.Fill(this.ticketBaseDataSet.TicketTable);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}
