namespace AdventureTime
{
    partial class Schedule
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
            this.newschedulebutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.schedulefullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advTimeDataSet1 = new AdventureTime.AdvTimeDataSet();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleTableAdapter = new AdventureTime.AdvTimeDataSetTableAdapters.ScheduleTableAdapter();
            this.schedulefullTableAdapter = new AdventureTime.AdvTimeDataSetTableAdapters.SchedulefullTableAdapter();
            this.advTimeDataSet2 = new AdventureTime.AdvTimeDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tournameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returndateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departurecityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxchildDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxadultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pitaniatipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vidturanameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulefullBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTimeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTimeDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.tournameDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.returndateDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.departurecityDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.maxchildDataGridViewTextBoxColumn,
            this.maxadultDataGridViewTextBoxColumn,
            this.tourpriceDataGridViewTextBoxColumn,
            this.pitaniatipDataGridViewTextBoxColumn,
            this.vidturanameDataGridViewTextBoxColumn,
            this.operatornameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.schedulefullBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1145, 478);
            this.dataGridView1.TabIndex = 0;
            // 
            // newschedulebutton
            // 
            this.newschedulebutton.Location = new System.Drawing.Point(-1, -2);
            this.newschedulebutton.Name = "newschedulebutton";
            this.newschedulebutton.Size = new System.Drawing.Size(96, 26);
            this.newschedulebutton.TabIndex = 1;
            this.newschedulebutton.Text = "Новый";
            this.newschedulebutton.UseVisualStyleBackColor = true;
            this.newschedulebutton.Click += new System.EventHandler(this.newschedulebutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // schedulefullBindingSource
            // 
            this.schedulefullBindingSource.DataMember = "Schedulefull";
            this.schedulefullBindingSource.DataSource = this.advTimeDataSet2;
            // 
            // advTimeDataSet1
            // 
            this.advTimeDataSet1.DataSetName = "AdvTimeDataSet";
            this.advTimeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataMember = "Schedulefull";
            this.scheduleBindingSource.DataSource = this.advTimeDataSet2;
            // 
            // scheduleTableAdapter
            // 
            this.scheduleTableAdapter.ClearBeforeFill = true;
            // 
            // schedulefullTableAdapter
            // 
            this.schedulefullTableAdapter.ClearBeforeFill = true;
            // 
            // advTimeDataSet2
            // 
            this.advTimeDataSet2.DataSetName = "AdvTimeDataSet";
            this.advTimeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idschedule";
            this.dataGridViewTextBoxColumn1.HeaderText = "idschedule";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idtura";
            this.dataGridViewTextBoxColumn3.HeaderText = "idtura";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // tournameDataGridViewTextBoxColumn
            // 
            this.tournameDataGridViewTextBoxColumn.DataPropertyName = "tourname";
            this.tournameDataGridViewTextBoxColumn.HeaderText = "Название тура";
            this.tournameDataGridViewTextBoxColumn.Name = "tournameDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "dateofdispatch";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата отправления";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // returndateDataGridViewTextBoxColumn
            // 
            this.returndateDataGridViewTextBoxColumn.DataPropertyName = "returndate";
            this.returndateDataGridViewTextBoxColumn.HeaderText = "Дата возвращения";
            this.returndateDataGridViewTextBoxColumn.Name = "returndateDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Страна прибытия";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // departurecityDataGridViewTextBoxColumn
            // 
            this.departurecityDataGridViewTextBoxColumn.DataPropertyName = "departurecity";
            this.departurecityDataGridViewTextBoxColumn.HeaderText = "Город отправления";
            this.departurecityDataGridViewTextBoxColumn.Name = "departurecityDataGridViewTextBoxColumn";
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Длительность";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            // 
            // maxchildDataGridViewTextBoxColumn
            // 
            this.maxchildDataGridViewTextBoxColumn.DataPropertyName = "maxchild";
            this.maxchildDataGridViewTextBoxColumn.HeaderText = "Макс детей";
            this.maxchildDataGridViewTextBoxColumn.Name = "maxchildDataGridViewTextBoxColumn";
            // 
            // maxadultDataGridViewTextBoxColumn
            // 
            this.maxadultDataGridViewTextBoxColumn.DataPropertyName = "maxadult";
            this.maxadultDataGridViewTextBoxColumn.HeaderText = "Макс взрослых";
            this.maxadultDataGridViewTextBoxColumn.Name = "maxadultDataGridViewTextBoxColumn";
            // 
            // tourpriceDataGridViewTextBoxColumn
            // 
            this.tourpriceDataGridViewTextBoxColumn.DataPropertyName = "tourprice";
            this.tourpriceDataGridViewTextBoxColumn.HeaderText = "Цена тура";
            this.tourpriceDataGridViewTextBoxColumn.Name = "tourpriceDataGridViewTextBoxColumn";
            // 
            // pitaniatipDataGridViewTextBoxColumn
            // 
            this.pitaniatipDataGridViewTextBoxColumn.DataPropertyName = "pitaniatip";
            this.pitaniatipDataGridViewTextBoxColumn.HeaderText = "Тип питания";
            this.pitaniatipDataGridViewTextBoxColumn.Name = "pitaniatipDataGridViewTextBoxColumn";
            // 
            // vidturanameDataGridViewTextBoxColumn
            // 
            this.vidturanameDataGridViewTextBoxColumn.DataPropertyName = "vidturaname";
            this.vidturanameDataGridViewTextBoxColumn.HeaderText = "Вид тура";
            this.vidturanameDataGridViewTextBoxColumn.Name = "vidturanameDataGridViewTextBoxColumn";
            // 
            // operatornameDataGridViewTextBoxColumn
            // 
            this.operatornameDataGridViewTextBoxColumn.DataPropertyName = "operatorname";
            this.operatornameDataGridViewTextBoxColumn.HeaderText = "Оператор";
            this.operatornameDataGridViewTextBoxColumn.Name = "operatornameDataGridViewTextBoxColumn";
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 506);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newschedulebutton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Schedule";
            this.Text = "Расписание туров";
            this.Load += new System.EventHandler(this.Schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulefullBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTimeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTimeDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private AdvTimeDataSetTableAdapters.ScheduleTableAdapter scheduleTableAdapter;
        private AdvTimeDataSet advTimeDataSet1;
        private System.Windows.Forms.BindingSource schedulefullBindingSource;
        private AdvTimeDataSetTableAdapters.SchedulefullTableAdapter schedulefullTableAdapter;
        private System.Windows.Forms.Button newschedulebutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idscheduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofdispatchDataGridViewTextBoxColumn;
        private AdvTimeDataSet advTimeDataSet2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn tournameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn returndateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departurecityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxchildDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxadultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pitaniatipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vidturanameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatornameDataGridViewTextBoxColumn;
    }
}