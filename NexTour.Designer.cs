namespace AdventureTime
{
    partial class NewTour
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.operbox = new System.Windows.Forms.ComboBox();
            this.operatorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advTimeDataSet1 = new AdventureTime.AdvTimeDataSet();
            this.pitbox = new System.Windows.Forms.ComboBox();
            this.pitanieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advTimeDataSet = new AdventureTime.AdvTimeDataSet();
            this.idvid = new System.Windows.Forms.ComboBox();
            this.vidturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.namebox = new System.Windows.Forms.TextBox();
            this.pricebox = new System.Windows.Forms.TextBox();
            this.durationbox = new System.Windows.Forms.TextBox();
            this.maxad = new System.Windows.Forms.TextBox();
            this.maxch = new System.Windows.Forms.TextBox();
            this.depart = new System.Windows.Forms.TextBox();
            this.countrybox = new System.Windows.Forms.TextBox();
            this.vidturaTableAdapter = new AdventureTime.AdvTimeDataSetTableAdapters.VidturaTableAdapter();
            this.pitanieTableAdapter = new AdventureTime.AdvTimeDataSetTableAdapters.PitanieTableAdapter();
            this.toursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tourTableAdapter1 = new AdventureTime.AdvTimeDataSetTableAdapters.TourTableAdapter();
            this.operatorsTableAdapter1 = new AdventureTime.AdvTimeDataSetTableAdapters.OperatorsTableAdapter();
            this.toursTableAdapter1 = new AdventureTime.AdvTimeDataSetTableAdapters.ToursTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.operatorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTimeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitanieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTimeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(173, 43);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(13, 13);
            this.labelid.TabIndex = 3;
            this.labelid.Text = "0";
            this.labelid.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Название тура";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Гороод отправления";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Вид тура";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Цена тура";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Длительность";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Тип питаниия";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Макс взрослых";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Макс детей";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Оператор";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 391);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Страна прибытия";
            // 
            // operbox
            // 
            this.operbox.DataSource = this.operatorsBindingSource;
            this.operbox.DisplayMember = "operatorname";
            this.operbox.FormattingEnabled = true;
            this.operbox.Location = new System.Drawing.Point(176, 322);
            this.operbox.Name = "operbox";
            this.operbox.Size = new System.Drawing.Size(121, 21);
            this.operbox.TabIndex = 14;
            this.operbox.ValueMember = "idoperator";
            // 
            // operatorsBindingSource
            // 
            this.operatorsBindingSource.DataMember = "Operators";
            this.operatorsBindingSource.DataSource = this.advTimeDataSet1;
            // 
            // advTimeDataSet1
            // 
            this.advTimeDataSet1.DataSetName = "AdvTimeDataSet";
            this.advTimeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pitbox
            // 
            this.pitbox.DataSource = this.pitanieBindingSource;
            this.pitbox.DisplayMember = "pitaniatip";
            this.pitbox.FormattingEnabled = true;
            this.pitbox.Location = new System.Drawing.Point(176, 212);
            this.pitbox.Name = "pitbox";
            this.pitbox.Size = new System.Drawing.Size(121, 21);
            this.pitbox.TabIndex = 15;
            this.pitbox.ValueMember = "idpitanie";
            // 
            // pitanieBindingSource
            // 
            this.pitanieBindingSource.DataMember = "Pitanie";
            this.pitanieBindingSource.DataSource = this.advTimeDataSet;
            // 
            // advTimeDataSet
            // 
            this.advTimeDataSet.DataSetName = "AdvTimeDataSet";
            this.advTimeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idvid
            // 
            this.idvid.DataSource = this.vidturaBindingSource;
            this.idvid.DisplayMember = "vidturaname";
            this.idvid.FormattingEnabled = true;
            this.idvid.Location = new System.Drawing.Point(176, 136);
            this.idvid.Name = "idvid";
            this.idvid.Size = new System.Drawing.Size(121, 21);
            this.idvid.TabIndex = 16;
            this.idvid.ValueMember = "idvidtura";
            // 
            // vidturaBindingSource
            // 
            this.vidturaBindingSource.DataMember = "Vidtura";
            this.vidturaBindingSource.DataSource = this.advTimeDataSet;
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(176, 74);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(221, 20);
            this.namebox.TabIndex = 17;
            // 
            // pricebox
            // 
            this.pricebox.Location = new System.Drawing.Point(176, 102);
            this.pricebox.Name = "pricebox";
            this.pricebox.Size = new System.Drawing.Size(221, 20);
            this.pricebox.TabIndex = 18;
            // 
            // durationbox
            // 
            this.durationbox.Location = new System.Drawing.Point(176, 176);
            this.durationbox.Name = "durationbox";
            this.durationbox.Size = new System.Drawing.Size(221, 20);
            this.durationbox.TabIndex = 19;
            // 
            // maxad
            // 
            this.maxad.Location = new System.Drawing.Point(176, 240);
            this.maxad.Name = "maxad";
            this.maxad.Size = new System.Drawing.Size(121, 20);
            this.maxad.TabIndex = 20;
            // 
            // maxch
            // 
            this.maxch.Location = new System.Drawing.Point(176, 280);
            this.maxch.Name = "maxch";
            this.maxch.Size = new System.Drawing.Size(121, 20);
            this.maxch.TabIndex = 21;
            // 
            // depart
            // 
            this.depart.Location = new System.Drawing.Point(176, 355);
            this.depart.Name = "depart";
            this.depart.Size = new System.Drawing.Size(221, 20);
            this.depart.TabIndex = 22;
            // 
            // countrybox
            // 
            this.countrybox.Location = new System.Drawing.Point(176, 383);
            this.countrybox.Name = "countrybox";
            this.countrybox.Size = new System.Drawing.Size(221, 20);
            this.countrybox.TabIndex = 23;
            // 
            // vidturaTableAdapter
            // 
            this.vidturaTableAdapter.ClearBeforeFill = true;
            // 
            // pitanieTableAdapter
            // 
            this.pitanieTableAdapter.ClearBeforeFill = true;
            // 
            // toursBindingSource
            // 
            this.toursBindingSource.DataMember = "Tours";
            this.toursBindingSource.DataSource = this.advTimeDataSet;
            // 
            // tourTableAdapter1
            // 
            this.tourTableAdapter1.ClearBeforeFill = true;
            // 
            // operatorsTableAdapter1
            // 
            this.operatorsTableAdapter1.ClearBeforeFill = true;
            // 
            // toursTableAdapter1
            // 
            this.toursTableAdapter1.ClearBeforeFill = true;
            // 
            // NewTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 474);
            this.Controls.Add(this.countrybox);
            this.Controls.Add(this.depart);
            this.Controls.Add(this.maxch);
            this.Controls.Add(this.maxad);
            this.Controls.Add(this.durationbox);
            this.Controls.Add(this.pricebox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.idvid);
            this.Controls.Add(this.pitbox);
            this.Controls.Add(this.operbox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "NewTour";
            this.Text = "Новый тур";
            this.Load += new System.EventHandler(this.NewTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.operatorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTimeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitanieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTimeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox operbox;
        private System.Windows.Forms.ComboBox pitbox;
        private System.Windows.Forms.ComboBox idvid;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox pricebox;
        private System.Windows.Forms.TextBox durationbox;
        private System.Windows.Forms.TextBox maxad;
        private System.Windows.Forms.TextBox maxch;
        private System.Windows.Forms.TextBox depart;
        private System.Windows.Forms.TextBox countrybox;
        private AdvTimeDataSet advTimeDataSet;
        private System.Windows.Forms.BindingSource toursBindingSource;
        private System.Windows.Forms.BindingSource vidturaBindingSource;
        private AdvTimeDataSetTableAdapters.VidturaTableAdapter vidturaTableAdapter;
        private System.Windows.Forms.BindingSource pitanieBindingSource;
        private AdvTimeDataSetTableAdapters.PitanieTableAdapter pitanieTableAdapter;
        private AdvTimeDataSet advTimeDataSet1;
        private System.Windows.Forms.BindingSource operatorsBindingSource;
        private AdvTimeDataSetTableAdapters.OperatorsTableAdapter operatorsTableAdapter;
        private AdvTimeDataSetTableAdapters.TourTableAdapter tourTableAdapter1;
        private AdvTimeDataSetTableAdapters.OperatorsTableAdapter operatorsTableAdapter1;
        private AdvTimeDataSetTableAdapters.ToursTableAdapter toursTableAdapter1;
    }
}