namespace AdventureTime
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.турыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видыТуровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.питаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skidkanameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tournameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vidturanameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pitaniatipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departurecityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idschedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsotrudnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idskidka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idvidtura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpitanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advTimeDataSet = new AdventureTime.AdvTimeDataSet();
            this.salesViewTableAdapter1 = new AdventureTime.AdvTimeDataSetTableAdapters.SalesViewTableAdapter();
            this.продаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расписаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.турыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.возвратToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTimeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1085, 476);
            this.splitContainer1.SplitterDistance = 82;
            this.splitContainer1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.расписаниеToolStripMenuItem,
            this.продаToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.турыToolStripMenuItem1,
            this.клиентыToolStripMenuItem1,
            this.возвратToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1085, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem,
            this.турыToolStripMenuItem,
            this.видыТуровToolStripMenuItem,
            this.питаниеToolStripMenuItem,
            this.операторыToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            this.справочникиToolStripMenuItem.Click += new System.EventHandler(this.справочникиToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // турыToolStripMenuItem
            // 
            this.турыToolStripMenuItem.Name = "турыToolStripMenuItem";
            this.турыToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.турыToolStripMenuItem.Text = "Туры";
            this.турыToolStripMenuItem.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // видыТуровToolStripMenuItem
            // 
            this.видыТуровToolStripMenuItem.Name = "видыТуровToolStripMenuItem";
            this.видыТуровToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.видыТуровToolStripMenuItem.Text = "Виды туров";
            this.видыТуровToolStripMenuItem.Click += new System.EventHandler(this.видыТуровToolStripMenuItem_Click);
            // 
            // питаниеToolStripMenuItem
            // 
            this.питаниеToolStripMenuItem.Name = "питаниеToolStripMenuItem";
            this.питаниеToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.питаниеToolStripMenuItem.Text = "Питание";
            this.питаниеToolStripMenuItem.Click += new System.EventHandler(this.питаниеToolStripMenuItem_Click);
            // 
            // операторыToolStripMenuItem
            // 
            this.операторыToolStripMenuItem.Name = "операторыToolStripMenuItem";
            this.операторыToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.операторыToolStripMenuItem.Text = "Операторы";
            this.операторыToolStripMenuItem.Click += new System.EventHandler(this.операторыToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.expr1DataGridViewTextBoxColumn,
            this.datesDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.skidkanameDataGridViewTextBoxColumn,
            this.tournameDataGridViewTextBoxColumn,
            this.vidturanameDataGridViewTextBoxColumn,
            this.pitaniatipDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.departurecityDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.finalprice,
            this.idsale,
            this.idschedule,
            this.idtura,
            this.idsotrudnik,
            this.idclient,
            this.idskidka,
            this.idvidtura,
            this.idpitanie});
            this.dataGridView1.DataSource = this.salesViewBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(1085, 390);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "FIOsotr";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "Сотрудник";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr1DataGridViewTextBoxColumn.Width = 85;
            // 
            // datesDataGridViewTextBoxColumn
            // 
            this.datesDataGridViewTextBoxColumn.DataPropertyName = "dates";
            this.datesDataGridViewTextBoxColumn.HeaderText = "Дата продажи";
            this.datesDataGridViewTextBoxColumn.Name = "datesDataGridViewTextBoxColumn";
            this.datesDataGridViewTextBoxColumn.ReadOnly = true;
            this.datesDataGridViewTextBoxColumn.Width = 97;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            this.fIODataGridViewTextBoxColumn.Width = 68;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 77;
            // 
            // skidkanameDataGridViewTextBoxColumn
            // 
            this.skidkanameDataGridViewTextBoxColumn.DataPropertyName = "skidkaname";
            this.skidkanameDataGridViewTextBoxColumn.HeaderText = "Скидка";
            this.skidkanameDataGridViewTextBoxColumn.Name = "skidkanameDataGridViewTextBoxColumn";
            this.skidkanameDataGridViewTextBoxColumn.ReadOnly = true;
            this.skidkanameDataGridViewTextBoxColumn.Width = 69;
            // 
            // tournameDataGridViewTextBoxColumn
            // 
            this.tournameDataGridViewTextBoxColumn.DataPropertyName = "tourname";
            this.tournameDataGridViewTextBoxColumn.HeaderText = "Тур";
            this.tournameDataGridViewTextBoxColumn.Name = "tournameDataGridViewTextBoxColumn";
            this.tournameDataGridViewTextBoxColumn.ReadOnly = true;
            this.tournameDataGridViewTextBoxColumn.Width = 50;
            // 
            // vidturanameDataGridViewTextBoxColumn
            // 
            this.vidturanameDataGridViewTextBoxColumn.DataPropertyName = "vidturaname";
            this.vidturanameDataGridViewTextBoxColumn.HeaderText = "Тип тура";
            this.vidturanameDataGridViewTextBoxColumn.Name = "vidturanameDataGridViewTextBoxColumn";
            this.vidturanameDataGridViewTextBoxColumn.ReadOnly = true;
            this.vidturanameDataGridViewTextBoxColumn.Width = 70;
            // 
            // pitaniatipDataGridViewTextBoxColumn
            // 
            this.pitaniatipDataGridViewTextBoxColumn.DataPropertyName = "pitaniatip";
            this.pitaniatipDataGridViewTextBoxColumn.HeaderText = "Питание";
            this.pitaniatipDataGridViewTextBoxColumn.Name = "pitaniatipDataGridViewTextBoxColumn";
            this.pitaniatipDataGridViewTextBoxColumn.ReadOnly = true;
            this.pitaniatipDataGridViewTextBoxColumn.Width = 75;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            this.countryDataGridViewTextBoxColumn.Width = 68;
            // 
            // departurecityDataGridViewTextBoxColumn
            // 
            this.departurecityDataGridViewTextBoxColumn.DataPropertyName = "departurecity";
            this.departurecityDataGridViewTextBoxColumn.HeaderText = "Город отправления";
            this.departurecityDataGridViewTextBoxColumn.Name = "departurecityDataGridViewTextBoxColumn";
            this.departurecityDataGridViewTextBoxColumn.ReadOnly = true;
            this.departurecityDataGridViewTextBoxColumn.Width = 119;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Длительность";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            this.durationDataGridViewTextBoxColumn.Width = 105;
            // 
            // finalprice
            // 
            this.finalprice.DataPropertyName = "finalprice";
            this.finalprice.HeaderText = "Итоговая цена";
            this.finalprice.Name = "finalprice";
            this.finalprice.ReadOnly = true;
            this.finalprice.Width = 98;
            // 
            // idsale
            // 
            this.idsale.DataPropertyName = "idsale";
            this.idsale.HeaderText = "idsale";
            this.idsale.Name = "idsale";
            this.idsale.ReadOnly = true;
            this.idsale.Visible = false;
            this.idsale.Width = 59;
            // 
            // idschedule
            // 
            this.idschedule.DataPropertyName = "idschedule";
            this.idschedule.HeaderText = "idschedule";
            this.idschedule.Name = "idschedule";
            this.idschedule.ReadOnly = true;
            this.idschedule.Visible = false;
            this.idschedule.Width = 83;
            // 
            // idtura
            // 
            this.idtura.DataPropertyName = "idtura";
            this.idtura.HeaderText = "idtura";
            this.idtura.Name = "idtura";
            this.idtura.ReadOnly = true;
            this.idtura.Visible = false;
            this.idtura.Width = 58;
            // 
            // idsotrudnik
            // 
            this.idsotrudnik.DataPropertyName = "idsotrudnik";
            this.idsotrudnik.HeaderText = "idsotrudnik";
            this.idsotrudnik.Name = "idsotrudnik";
            this.idsotrudnik.ReadOnly = true;
            this.idsotrudnik.Visible = false;
            this.idsotrudnik.Width = 83;
            // 
            // idclient
            // 
            this.idclient.DataPropertyName = "idclient";
            this.idclient.HeaderText = "idclient";
            this.idclient.Name = "idclient";
            this.idclient.ReadOnly = true;
            this.idclient.Visible = false;
            this.idclient.Width = 65;
            // 
            // idskidka
            // 
            this.idskidka.DataPropertyName = "idskidka";
            this.idskidka.HeaderText = "idskidka";
            this.idskidka.Name = "idskidka";
            this.idskidka.ReadOnly = true;
            this.idskidka.Visible = false;
            this.idskidka.Width = 71;
            // 
            // idvidtura
            // 
            this.idvidtura.DataPropertyName = "idvidtura";
            this.idvidtura.HeaderText = "idvidtura";
            this.idvidtura.Name = "idvidtura";
            this.idvidtura.ReadOnly = true;
            this.idvidtura.Visible = false;
            this.idvidtura.Width = 72;
            // 
            // idpitanie
            // 
            this.idpitanie.DataPropertyName = "idpitanie";
            this.idpitanie.HeaderText = "idpitanie";
            this.idpitanie.Name = "idpitanie";
            this.idpitanie.ReadOnly = true;
            this.idpitanie.Visible = false;
            this.idpitanie.Width = 71;
            // 
            // salesViewBindingSource
            // 
            this.salesViewBindingSource.AllowNew = false;
            this.salesViewBindingSource.DataMember = "SalesView";
            this.salesViewBindingSource.DataSource = this.advTimeDataSet;
            // 
            // advTimeDataSet
            // 
            this.advTimeDataSet.DataSetName = "AdvTimeDataSet";
            this.advTimeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesViewTableAdapter1
            // 
            this.salesViewTableAdapter1.ClearBeforeFill = true;
            // 
            // продаToolStripMenuItem
            // 
            this.продаToolStripMenuItem.Name = "продаToolStripMenuItem";
            this.продаToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.продаToolStripMenuItem.Text = "Продажа";
            this.продаToolStripMenuItem.Click += new System.EventHandler(this.salebutton_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.button3_Click);
            // 
            // расписаниеToolStripMenuItem
            // 
            this.расписаниеToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.расписаниеToolStripMenuItem.Name = "расписаниеToolStripMenuItem";
            this.расписаниеToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.расписаниеToolStripMenuItem.Text = "Расписание";
            this.расписаниеToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // турыToolStripMenuItem1
            // 
            this.турыToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.турыToolStripMenuItem1.Name = "турыToolStripMenuItem1";
            this.турыToolStripMenuItem1.Size = new System.Drawing.Size(47, 20);
            this.турыToolStripMenuItem1.Text = "Туры";
            this.турыToolStripMenuItem1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // клиентыToolStripMenuItem1
            // 
            this.клиентыToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.клиентыToolStripMenuItem1.Name = "клиентыToolStripMenuItem1";
            this.клиентыToolStripMenuItem1.Size = new System.Drawing.Size(67, 20);
            this.клиентыToolStripMenuItem1.Text = "Клиенты";
            this.клиентыToolStripMenuItem1.Click += new System.EventHandler(this.button1_Click);
            // 
            // возвратToolStripMenuItem
            // 
            this.возвратToolStripMenuItem.Name = "возвратToolStripMenuItem";
            this.возвратToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.возвратToolStripMenuItem.Text = "Возврат";
            this.возвратToolStripMenuItem.Click += new System.EventHandler(this.возвратToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1085, 476);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Время приключений";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTimeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource salesViewBindingSource;
        private AdvTimeDataSet advTimeDataSet;
        private AdvTimeDataSetTableAdapters.SalesViewTableAdapter salesViewTableAdapter1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem турыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem питаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видыТуровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операторыToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skidkanameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tournameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vidturanameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pitaniatipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departurecityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsale;
        private System.Windows.Forms.DataGridViewTextBoxColumn idschedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtura;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsotrudnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn idskidka;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvidtura;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpitanie;
        private System.Windows.Forms.ToolStripMenuItem продаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расписаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem турыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem возвратToolStripMenuItem;
    }
}

