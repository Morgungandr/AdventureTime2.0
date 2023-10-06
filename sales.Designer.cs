namespace AdventureTime
{
    partial class sales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.advTimeDataSet = new AdventureTime.AdvTimeDataSet();
            this.advTimeDataSet1 = new AdventureTime.AdvTimeDataSet();
            this.accountTableAdapter = new AdventureTime.AdvTimeDataSetTableAdapters.AccountTableAdapter();
            this.saleFullTableAdapter = new AdventureTime.AdvTimeDataSetTableAdapters.SaleFullTableAdapter();
            this.idsaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idscheduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idskidkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsotrudnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tournameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIOsotr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skidkanameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofdispatchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returndateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTimeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTimeDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsaleDataGridViewTextBoxColumn,
            this.idscheduleDataGridViewTextBoxColumn,
            this.idskidkaDataGridViewTextBoxColumn,
            this.idturaDataGridViewTextBoxColumn,
            this.idsotrudnikDataGridViewTextBoxColumn,
            this.tournameDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.FIOsotr,
            this.datesDataGridViewTextBoxColumn,
            this.skidkanameDataGridViewTextBoxColumn,
            this.dateofdispatchDataGridViewTextBoxColumn,
            this.returndateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 404);
            this.dataGridView1.TabIndex = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "SaleFull";
            this.bindingSource1.DataSource = this.advTimeDataSet;
            // 
            // advTimeDataSet
            // 
            this.advTimeDataSet.DataSetName = "AdvTimeDataSet";
            this.advTimeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // advTimeDataSet1
            // 
            this.advTimeDataSet1.DataSetName = "AdvTimeDataSet";
            this.advTimeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // saleFullTableAdapter
            // 
            this.saleFullTableAdapter.ClearBeforeFill = true;
            // 
            // idsaleDataGridViewTextBoxColumn
            // 
            this.idsaleDataGridViewTextBoxColumn.DataPropertyName = "idsale";
            this.idsaleDataGridViewTextBoxColumn.HeaderText = "idsale";
            this.idsaleDataGridViewTextBoxColumn.Name = "idsaleDataGridViewTextBoxColumn";
            this.idsaleDataGridViewTextBoxColumn.Visible = false;
            // 
            // idscheduleDataGridViewTextBoxColumn
            // 
            this.idscheduleDataGridViewTextBoxColumn.DataPropertyName = "idschedule";
            this.idscheduleDataGridViewTextBoxColumn.HeaderText = "idschedule";
            this.idscheduleDataGridViewTextBoxColumn.Name = "idscheduleDataGridViewTextBoxColumn";
            this.idscheduleDataGridViewTextBoxColumn.ReadOnly = true;
            this.idscheduleDataGridViewTextBoxColumn.Visible = false;
            // 
            // idskidkaDataGridViewTextBoxColumn
            // 
            this.idskidkaDataGridViewTextBoxColumn.DataPropertyName = "idskidka";
            this.idskidkaDataGridViewTextBoxColumn.HeaderText = "idskidka";
            this.idskidkaDataGridViewTextBoxColumn.Name = "idskidkaDataGridViewTextBoxColumn";
            this.idskidkaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idturaDataGridViewTextBoxColumn
            // 
            this.idturaDataGridViewTextBoxColumn.DataPropertyName = "idtura";
            this.idturaDataGridViewTextBoxColumn.HeaderText = "idtura";
            this.idturaDataGridViewTextBoxColumn.Name = "idturaDataGridViewTextBoxColumn";
            this.idturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idturaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idsotrudnikDataGridViewTextBoxColumn
            // 
            this.idsotrudnikDataGridViewTextBoxColumn.DataPropertyName = "idsotrudnik";
            this.idsotrudnikDataGridViewTextBoxColumn.HeaderText = "idsotrudnik";
            this.idsotrudnikDataGridViewTextBoxColumn.Name = "idsotrudnikDataGridViewTextBoxColumn";
            this.idsotrudnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // tournameDataGridViewTextBoxColumn
            // 
            this.tournameDataGridViewTextBoxColumn.DataPropertyName = "tourname";
            this.tournameDataGridViewTextBoxColumn.HeaderText = "Тур";
            this.tournameDataGridViewTextBoxColumn.Name = "tournameDataGridViewTextBoxColumn";
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            // 
            // FIOsotr
            // 
            this.FIOsotr.DataPropertyName = "FIOsotr";
            this.FIOsotr.HeaderText = "Сотрудник";
            this.FIOsotr.Name = "FIOsotr";
            // 
            // datesDataGridViewTextBoxColumn
            // 
            this.datesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.datesDataGridViewTextBoxColumn.DataPropertyName = "dates";
            this.datesDataGridViewTextBoxColumn.HeaderText = "Дата оформления заказа";
            this.datesDataGridViewTextBoxColumn.Name = "datesDataGridViewTextBoxColumn";
            this.datesDataGridViewTextBoxColumn.Width = 150;
            // 
            // skidkanameDataGridViewTextBoxColumn
            // 
            this.skidkanameDataGridViewTextBoxColumn.DataPropertyName = "skidkaname";
            this.skidkanameDataGridViewTextBoxColumn.HeaderText = "Скидка";
            this.skidkanameDataGridViewTextBoxColumn.Name = "skidkanameDataGridViewTextBoxColumn";
            // 
            // dateofdispatchDataGridViewTextBoxColumn
            // 
            this.dateofdispatchDataGridViewTextBoxColumn.DataPropertyName = "dateofdispatch";
            this.dateofdispatchDataGridViewTextBoxColumn.HeaderText = "Дата отправки";
            this.dateofdispatchDataGridViewTextBoxColumn.Name = "dateofdispatchDataGridViewTextBoxColumn";
            // 
            // returndateDataGridViewTextBoxColumn
            // 
            this.returndateDataGridViewTextBoxColumn.DataPropertyName = "returndate";
            this.returndateDataGridViewTextBoxColumn.HeaderText = "Дата возвращения";
            this.returndateDataGridViewTextBoxColumn.Name = "returndateDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Новая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "sales";
            this.Text = "Продажа";
            this.Load += new System.EventHandler(this.sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTimeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTimeDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AdvTimeDataSet advTimeDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private AdvTimeDataSet advTimeDataSet;
        private AdvTimeDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
        private AdvTimeDataSetTableAdapters.SaleFullTableAdapter saleFullTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idscheduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idskidkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsotrudnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tournameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIOsotr;
        private System.Windows.Forms.DataGridViewTextBoxColumn datesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skidkanameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofdispatchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returndateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}