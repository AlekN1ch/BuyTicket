﻿using System;
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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ticketBaseDataSet.buyTicketTable". При необходимости она может быть перемещена или удалена.
            this.buyTicketTableTableAdapter.Fill(this.ticketBaseDataSet.buyTicketTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ticketBaseDataSet.TicketTable". При необходимости она может быть перемещена или удалена.
            this.ticketTableTableAdapter.Fill(this.ticketBaseDataSet.TicketTable);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}
