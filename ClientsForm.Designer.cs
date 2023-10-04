namespace AdventureTime
{
    partial class ClientsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportseriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportnomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personaldataoftheclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ransomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.advTimeDataSet = new AdventureTime.AdvTimeDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.datesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skidkanameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tournameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pitaniatipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vidturanameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new AdventureTime.AdvTimeDataSetTableAdapters.ClientTableAdapter();
            this.selectToursbyClientTableAdapter = new AdventureTime.AdvTimeDataSetTableAdapters.SelectToursbyClientTableAdapter();
            this.addclientbutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.filterbox = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTimeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 40);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer1.Size = new System.Drawing.Size(748, 444);
            this.splitContainer1.SplitterDistance = 185;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclientDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.birthdateDataGridViewTextBoxColumn,
            this.documentsDataGridViewTextBoxColumn,
            this.passportseriaDataGridViewTextBoxColumn,
            this.passportnomerDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.personaldataoftheclientDataGridViewTextBoxColumn,
            this.ransomDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(748, 185);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.button2_Click);
            // 
            // idclientDataGridViewTextBoxColumn
            // 
            this.idclientDataGridViewTextBoxColumn.DataPropertyName = "idclient";
            this.idclientDataGridViewTextBoxColumn.HeaderText = "ИД";
            this.idclientDataGridViewTextBoxColumn.Name = "idclientDataGridViewTextBoxColumn";
            this.idclientDataGridViewTextBoxColumn.ReadOnly = true;
            this.idclientDataGridViewTextBoxColumn.Width = 49;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО Клиента";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            this.fIODataGridViewTextBoxColumn.Width = 96;
            // 
            // birthdateDataGridViewTextBoxColumn
            // 
            this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "birthdate";
            this.birthdateDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            this.birthdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.birthdateDataGridViewTextBoxColumn.Width = 102;
            // 
            // documentsDataGridViewTextBoxColumn
            // 
            this.documentsDataGridViewTextBoxColumn.DataPropertyName = "documents";
            this.documentsDataGridViewTextBoxColumn.HeaderText = "Документ";
            this.documentsDataGridViewTextBoxColumn.Name = "documentsDataGridViewTextBoxColumn";
            this.documentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentsDataGridViewTextBoxColumn.Width = 83;
            // 
            // passportseriaDataGridViewTextBoxColumn
            // 
            this.passportseriaDataGridViewTextBoxColumn.DataPropertyName = "passportseria";
            this.passportseriaDataGridViewTextBoxColumn.HeaderText = "Серия";
            this.passportseriaDataGridViewTextBoxColumn.Name = "passportseriaDataGridViewTextBoxColumn";
            this.passportseriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.passportseriaDataGridViewTextBoxColumn.Width = 63;
            // 
            // passportnomerDataGridViewTextBoxColumn
            // 
            this.passportnomerDataGridViewTextBoxColumn.DataPropertyName = "passportnomer";
            this.passportnomerDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.passportnomerDataGridViewTextBoxColumn.Name = "passportnomerDataGridViewTextBoxColumn";
            this.passportnomerDataGridViewTextBoxColumn.ReadOnly = true;
            this.passportnomerDataGridViewTextBoxColumn.Width = 66;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 77;
            // 
            // personaldataoftheclientDataGridViewTextBoxColumn
            // 
            this.personaldataoftheclientDataGridViewTextBoxColumn.DataPropertyName = "personaldataoftheclient";
            this.personaldataoftheclientDataGridViewTextBoxColumn.HeaderText = "Профиль";
            this.personaldataoftheclientDataGridViewTextBoxColumn.Name = "personaldataoftheclientDataGridViewTextBoxColumn";
            this.personaldataoftheclientDataGridViewTextBoxColumn.ReadOnly = true;
            this.personaldataoftheclientDataGridViewTextBoxColumn.Width = 78;
            // 
            // ransomDataGridViewTextBoxColumn
            // 
            this.ransomDataGridViewTextBoxColumn.DataPropertyName = "ransom";
            this.ransomDataGridViewTextBoxColumn.HeaderText = "Прибыль";
            this.ransomDataGridViewTextBoxColumn.Name = "ransomDataGridViewTextBoxColumn";
            this.ransomDataGridViewTextBoxColumn.ReadOnly = true;
            this.ransomDataGridViewTextBoxColumn.Width = 78;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Client";
            this.bindingSource1.DataSource = this.advTimeDataSet;
            // 
            // advTimeDataSet
            // 
            this.advTimeDataSet.DataSetName = "AdvTimeDataSet";
            this.advTimeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datesDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn,
            this.skidkanameDataGridViewTextBoxColumn,
            this.tournameDataGridViewTextBoxColumn,
            this.tourpriceDataGridViewTextBoxColumn,
            this.pitaniatipDataGridViewTextBoxColumn,
            this.vidturanameDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(748, 249);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // datesDataGridViewTextBoxColumn
            // 
            this.datesDataGridViewTextBoxColumn.DataPropertyName = "dates";
            this.datesDataGridViewTextBoxColumn.HeaderText = "Дата продажи";
            this.datesDataGridViewTextBoxColumn.Name = "datesDataGridViewTextBoxColumn";
            this.datesDataGridViewTextBoxColumn.ReadOnly = true;
            this.datesDataGridViewTextBoxColumn.Width = 97;
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "Сотрудник";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr1DataGridViewTextBoxColumn.Width = 85;
            // 
            // skidkanameDataGridViewTextBoxColumn
            // 
            this.skidkanameDataGridViewTextBoxColumn.DataPropertyName = "skidkaname";
            this.skidkanameDataGridViewTextBoxColumn.HeaderText = "Тип скидки";
            this.skidkanameDataGridViewTextBoxColumn.Name = "skidkanameDataGridViewTextBoxColumn";
            this.skidkanameDataGridViewTextBoxColumn.ReadOnly = true;
            this.skidkanameDataGridViewTextBoxColumn.Width = 83;
            // 
            // tournameDataGridViewTextBoxColumn
            // 
            this.tournameDataGridViewTextBoxColumn.DataPropertyName = "tourname";
            this.tournameDataGridViewTextBoxColumn.HeaderText = "Приключение";
            this.tournameDataGridViewTextBoxColumn.Name = "tournameDataGridViewTextBoxColumn";
            this.tournameDataGridViewTextBoxColumn.ReadOnly = true;
            this.tournameDataGridViewTextBoxColumn.Width = 101;
            // 
            // tourpriceDataGridViewTextBoxColumn
            // 
            this.tourpriceDataGridViewTextBoxColumn.DataPropertyName = "tourprice";
            this.tourpriceDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.tourpriceDataGridViewTextBoxColumn.Name = "tourpriceDataGridViewTextBoxColumn";
            this.tourpriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.tourpriceDataGridViewTextBoxColumn.Width = 87;
            // 
            // pitaniatipDataGridViewTextBoxColumn
            // 
            this.pitaniatipDataGridViewTextBoxColumn.DataPropertyName = "pitaniatip";
            this.pitaniatipDataGridViewTextBoxColumn.HeaderText = "Питание";
            this.pitaniatipDataGridViewTextBoxColumn.Name = "pitaniatipDataGridViewTextBoxColumn";
            this.pitaniatipDataGridViewTextBoxColumn.ReadOnly = true;
            this.pitaniatipDataGridViewTextBoxColumn.Width = 75;
            // 
            // vidturanameDataGridViewTextBoxColumn
            // 
            this.vidturanameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.vidturanameDataGridViewTextBoxColumn.DataPropertyName = "vidturaname";
            this.vidturanameDataGridViewTextBoxColumn.HeaderText = "Тип приключения";
            this.vidturanameDataGridViewTextBoxColumn.Name = "vidturanameDataGridViewTextBoxColumn";
            this.vidturanameDataGridViewTextBoxColumn.ReadOnly = true;
            this.vidturanameDataGridViewTextBoxColumn.Width = 111;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Длительность";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            this.durationDataGridViewTextBoxColumn.Width = 105;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "SelectToursbyClient";
            this.bindingSource2.DataSource = this.advTimeDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // selectToursbyClientTableAdapter
            // 
            this.selectToursbyClientTableAdapter.ClearBeforeFill = true;
            // 
            // addclientbutton
            // 
            this.addclientbutton.BackColor = System.Drawing.SystemColors.Control;
            this.addclientbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addclientbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addclientbutton.ForeColor = System.Drawing.Color.Green;
            this.addclientbutton.Location = new System.Drawing.Point(11, 9);
            this.addclientbutton.Name = "addclientbutton";
            this.addclientbutton.Size = new System.Drawing.Size(114, 23);
            this.addclientbutton.TabIndex = 1;
            this.addclientbutton.Text = "Новый клиент";
            this.addclientbutton.UseVisualStyleBackColor = false;
            this.addclientbutton.Click += new System.EventHandler(this.addclientbutton_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(598, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Редактировать клиента";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // filterbox
            // 
            this.filterbox.Location = new System.Drawing.Point(148, 12);
            this.filterbox.Name = "filterbox";
            this.filterbox.Size = new System.Drawing.Size(421, 20);
            this.filterbox.TabIndex = 3;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Transparent;
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.ForeColor = System.Drawing.Color.Transparent;
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.Location = new System.Drawing.Point(542, 12);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(27, 20);
            this.search.TabIndex = 4;
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(748, 484);
            this.Controls.Add(this.search);
            this.Controls.Add(this.filterbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addclientbutton);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ClientsForm";
            this.Text = "ClientsForm";
            this.Load += new System.EventHandler(this.ClientsForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTimeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private AdvTimeDataSet advTimeDataSet;
        private AdvTimeDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource2;
        private AdvTimeDataSetTableAdapters.SelectToursbyClientTableAdapter selectToursbyClientTableAdapter;
        private System.Windows.Forms.Button addclientbutton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportseriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportnomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personaldataoftheclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ransomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skidkanameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tournameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pitaniatipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vidturanameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox filterbox;
        private System.Windows.Forms.Button search;
    }
}