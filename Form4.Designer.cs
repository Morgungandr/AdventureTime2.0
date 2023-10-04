namespace AdventureTime
{
    partial class tourform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tourform));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.advTimeDataSet1 = new AdventureTime.AdvTimeDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toursearch = new System.Windows.Forms.Button();
            this.filterbox = new System.Windows.Forms.TextBox();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.toursTableAdapter1 = new AdventureTime.AdvTimeDataSetTableAdapters.ToursTableAdapter();
            this.idtour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vidturanameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pitaniatipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxadult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxchild = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departurecity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idvidtura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpitanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idoperator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTimeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtour,
            this.tourname,
            this.country,
            this.vidturanameDataGridViewTextBoxColumn,
            this.pitaniatipDataGridViewTextBoxColumn,
            this.tourprice,
            this.maxadult,
            this.maxchild,
            this.duration,
            this.operatornameDataGridViewTextBoxColumn,
            this.departurecity,
            this.idvidtura,
            this.idpitanie,
            this.idoperator});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1145, 384);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Tours";
            this.bindingSource1.DataSource = this.advTimeDataSet1;
            // 
            // advTimeDataSet1
            // 
            this.advTimeDataSet1.DataSetName = "AdvTimeDataSet";
            this.advTimeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Новый тур";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(992, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toursearch
            // 
            this.toursearch.BackColor = System.Drawing.Color.Transparent;
            this.toursearch.Image = ((System.Drawing.Image)(resources.GetObject("toursearch.Image")));
            this.toursearch.Location = new System.Drawing.Point(879, 22);
            this.toursearch.Name = "toursearch";
            this.toursearch.Size = new System.Drawing.Size(31, 20);
            this.toursearch.TabIndex = 4;
            this.toursearch.UseVisualStyleBackColor = false;
            this.toursearch.Click += new System.EventHandler(this.toursearch_Click);
            // 
            // filterbox
            // 
            this.filterbox.Location = new System.Drawing.Point(229, 22);
            this.filterbox.Name = "filterbox";
            this.filterbox.Size = new System.Drawing.Size(644, 20);
            this.filterbox.TabIndex = 5;
            this.filterbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = this.advTimeDataSet1;
            this.bindingSource2.Position = 0;
            // 
            // toursTableAdapter1
            // 
            this.toursTableAdapter1.ClearBeforeFill = true;
            // 
            // idtour
            // 
            this.idtour.DataPropertyName = "idtura";
            this.idtour.HeaderText = "ID";
            this.idtour.Name = "idtour";
            this.idtour.ReadOnly = true;
            // 
            // tourname
            // 
            this.tourname.DataPropertyName = "tourname";
            this.tourname.HeaderText = "Тур";
            this.tourname.Name = "tourname";
            // 
            // country
            // 
            this.country.DataPropertyName = "country";
            this.country.HeaderText = "Страна прибытия";
            this.country.Name = "country";
            // 
            // vidturanameDataGridViewTextBoxColumn
            // 
            this.vidturanameDataGridViewTextBoxColumn.DataPropertyName = "vidturaname";
            this.vidturanameDataGridViewTextBoxColumn.HeaderText = "Вид тура";
            this.vidturanameDataGridViewTextBoxColumn.Name = "vidturanameDataGridViewTextBoxColumn";
            // 
            // pitaniatipDataGridViewTextBoxColumn
            // 
            this.pitaniatipDataGridViewTextBoxColumn.DataPropertyName = "pitaniatip";
            this.pitaniatipDataGridViewTextBoxColumn.HeaderText = "Тип питания";
            this.pitaniatipDataGridViewTextBoxColumn.Name = "pitaniatipDataGridViewTextBoxColumn";
            // 
            // tourprice
            // 
            this.tourprice.DataPropertyName = "tourprice";
            this.tourprice.HeaderText = "Цена тура";
            this.tourprice.Name = "tourprice";
            // 
            // maxadult
            // 
            this.maxadult.DataPropertyName = "maxadult";
            this.maxadult.HeaderText = "Макс вз";
            this.maxadult.Name = "maxadult";
            // 
            // maxchild
            // 
            this.maxchild.DataPropertyName = "maxchild";
            this.maxchild.HeaderText = "Макс дет";
            this.maxchild.Name = "maxchild";
            // 
            // duration
            // 
            this.duration.DataPropertyName = "duration";
            this.duration.HeaderText = "Длительность";
            this.duration.Name = "duration";
            // 
            // operatornameDataGridViewTextBoxColumn
            // 
            this.operatornameDataGridViewTextBoxColumn.DataPropertyName = "operatorname";
            this.operatornameDataGridViewTextBoxColumn.HeaderText = "Оператор";
            this.operatornameDataGridViewTextBoxColumn.Name = "operatornameDataGridViewTextBoxColumn";
            // 
            // departurecity
            // 
            this.departurecity.DataPropertyName = "departurecity";
            this.departurecity.HeaderText = "Город отправ";
            this.departurecity.Name = "departurecity";
            // 
            // idvidtura
            // 
            this.idvidtura.DataPropertyName = "idvidtura";
            this.idvidtura.HeaderText = "idvidtura";
            this.idvidtura.Name = "idvidtura";
            this.idvidtura.Visible = false;
            // 
            // idpitanie
            // 
            this.idpitanie.DataPropertyName = "idpitanie";
            this.idpitanie.HeaderText = "idpitanie";
            this.idpitanie.Name = "idpitanie";
            this.idpitanie.Visible = false;
            // 
            // idoperator
            // 
            this.idoperator.DataPropertyName = "idoperator";
            this.idoperator.HeaderText = "idoperator";
            this.idoperator.Name = "idoperator";
            this.idoperator.Visible = false;
            // 
            // tourform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 469);
            this.Controls.Add(this.filterbox);
            this.Controls.Add(this.toursearch);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "tourform";
            this.Text = "Туры";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTimeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button toursearch;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private AdvTimeDataSet advTimeDataSet1;
        private System.Windows.Forms.TextBox filterbox;
        private AdvTimeDataSetTableAdapters.ToursTableAdapter toursTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtour;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourname;
        private System.Windows.Forms.DataGridViewTextBoxColumn country;
        private System.Windows.Forms.DataGridViewTextBoxColumn vidturanameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pitaniatipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxadult;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxchild;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departurecity;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvidtura;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpitanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn idoperator;
    }
}