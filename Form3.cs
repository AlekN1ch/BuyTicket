using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyTicket
{
    public partial class Form3 : Form
    {
        public static string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TicketBase.accdb";
        public OleDbConnection myConnection;
        public string price;
        public bool find = false;
        public Form3()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connection);
            myConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string start=comboBox3.Text;
            string finish = comboBox4.Text;
            string ch = comboBox4.Text;
            if (comboBox3.Text == ch)
            {
                MessageBox.Show("Неверный маршрут");
                comboBox3.Text = string.Empty;
                comboBox4.Text = string.Empty;
            }
            else
            {
                try
                {
                    string query = "SELECT price FROM buyTicketTable WHERE start='" + start + "'AND finish='" + finish + "'";
                    OleDbCommand command = new OleDbCommand(query, myConnection);
                    price = command.ExecuteScalar().ToString();
                }
                catch 
                {
                    string query1 = "SELECT price FROM buyTicketTable WHERE start='" + finish + "'AND finish='" + start + "'";
                    OleDbCommand command2 = new OleDbCommand(query1, myConnection);
                    price = command2.ExecuteScalar().ToString();
                }
                label1.Text = price;
                button2.Enabled= true;
                Form2.first = false;
                
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ticketBaseDataSet.buyTicketTable". При необходимости она может быть перемещена или удалена.
            this.buyTicketTableTableAdapter.Fill(this.ticketBaseDataSet.buyTicketTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ticketBaseDataSet.TicketTable". При необходимости она может быть перемещена или удалена.
            this.ticketTableTableAdapter.Fill(this.ticketBaseDataSet.TicketTable);
            button2.Enabled = find;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            checkBox(comboBox1);
        }
        public void checkBox(ComboBox comboBox1)
        {
            bool go=false;
            string name = comboBox1.Text;
            List<string> list = new List<string>();
            foreach (var item in comboBox1.Items)
            {
                list.Add(item.ToString());
            }
            foreach (var iyem in list)
            {
                if (name == iyem) 
                {
                    go=true;
                    break;
                }
                
            }
            if (go)
            { 

            }
            else
            {
                MessageBox.Show("Неверный ввод");
                comboBox1.Text = string.Empty;
            }
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            checkBox(comboBox2);
        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
            checkBox(comboBox3);
            

        }

        private void comboBox4_TextChanged(object sender, EventArgs e)
        {
            checkBox(comboBox4);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string time, data, start, finish;
            time = comboBox1.Text;
            data = comboBox2.Text;
            start = comboBox3.Text;
            finish = comboBox4.Text;
            if (time == string.Empty || data == string.Empty || start == string.Empty || finish == string.Empty )
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                string quary = "INSERT INTO TicketTable([time],[data],[start],[finish],[price]) VALUES" + "('" + time + "','" + data + "','" + start + "','" + finish + "','" + price + "')";
                OleDbCommand command1 = new OleDbCommand(quary, myConnection);
                command1.ExecuteNonQuery();
                Form2 form2 = new Form2();
                form2.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
