namespace BuyTicket
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ticketBaseDataSet = new BuyTicket.TicketBaseDataSet();
            this.ticketTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketTableTableAdapter = new BuyTicket.TicketBaseDataSetTableAdapters.TicketTableTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyTicketTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buyTicketTableTableAdapter = new BuyTicket.TicketBaseDataSetTableAdapters.buyTicketTableTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyTicketTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.startDataGridViewTextBoxColumn,
            this.finishDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.placeCountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.buyTicketTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(64, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(928, 394);
            this.dataGridView1.TabIndex = 0;
            // 
            // ticketBaseDataSet
            // 
            this.ticketBaseDataSet.DataSetName = "TicketBaseDataSet";
            this.ticketBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketTableBindingSource
            // 
            this.ticketTableBindingSource.DataMember = "TicketTable";
            this.ticketTableBindingSource.DataSource = this.ticketBaseDataSet;
            // 
            // ticketTableTableAdapter
            // 
            this.ticketTableTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "data";
            this.dataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.Width = 125;
            // 
            // startDataGridViewTextBoxColumn
            // 
            this.startDataGridViewTextBoxColumn.DataPropertyName = "start";
            this.startDataGridViewTextBoxColumn.HeaderText = "start";
            this.startDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startDataGridViewTextBoxColumn.Name = "startDataGridViewTextBoxColumn";
            this.startDataGridViewTextBoxColumn.Width = 125;
            // 
            // finishDataGridViewTextBoxColumn
            // 
            this.finishDataGridViewTextBoxColumn.DataPropertyName = "finish";
            this.finishDataGridViewTextBoxColumn.HeaderText = "finish";
            this.finishDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.finishDataGridViewTextBoxColumn.Name = "finishDataGridViewTextBoxColumn";
            this.finishDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // placeCountDataGridViewTextBoxColumn
            // 
            this.placeCountDataGridViewTextBoxColumn.DataPropertyName = "placeCount";
            this.placeCountDataGridViewTextBoxColumn.HeaderText = "placeCount";
            this.placeCountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.placeCountDataGridViewTextBoxColumn.Name = "placeCountDataGridViewTextBoxColumn";
            this.placeCountDataGridViewTextBoxColumn.Width = 125;
            // 
            // buyTicketTableBindingSource
            // 
            this.buyTicketTableBindingSource.DataMember = "buyTicketTable";
            this.buyTicketTableBindingSource.DataSource = this.ticketBaseDataSet;
            // 
            // buyTicketTableTableAdapter
            // 
            this.buyTicketTableTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.button1.Location = new System.Drawing.Point(793, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 97);
            this.button1.TabIndex = 1;
            this.button1.Text = "Мои билеты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.label1.Location = new System.Drawing.Point(403, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Доступные рейсы";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyTicketTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TicketBaseDataSet ticketBaseDataSet;
        private System.Windows.Forms.BindingSource ticketTableBindingSource;
        private TicketBaseDataSetTableAdapters.TicketTableTableAdapter ticketTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource buyTicketTableBindingSource;
        private TicketBaseDataSetTableAdapters.buyTicketTableTableAdapter buyTicketTableTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

