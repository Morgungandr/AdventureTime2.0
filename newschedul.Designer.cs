namespace AdventureTime
{
    partial class newschedul
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
            this.Tourchoosebox = new System.Windows.Forms.ComboBox();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.advTimeDataSet2 = new AdventureTime.AdvTimeDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Tourdatabox = new System.Windows.Forms.DateTimePicker();
            this.labelid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tourTableAdapter1 = new AdventureTime.AdvTimeDataSetTableAdapters.TourTableAdapter();
            this.scheduleTableAdapter1 = new AdventureTime.AdvTimeDataSetTableAdapters.ScheduleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTimeDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tourchoosebox
            // 
            this.Tourchoosebox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Tourchoosebox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Tourchoosebox.DataSource = this.bindingSource2;
            this.Tourchoosebox.DisplayMember = "tourname";
            this.Tourchoosebox.FormattingEnabled = true;
            this.Tourchoosebox.Location = new System.Drawing.Point(132, 69);
            this.Tourchoosebox.Name = "Tourchoosebox";
            this.Tourchoosebox.Size = new System.Drawing.Size(121, 21);
            this.Tourchoosebox.TabIndex = 0;
            this.Tourchoosebox.ValueMember = "idtura";
            this.Tourchoosebox.SelectedIndexChanged += new System.EventHandler(this.Tourchoosebox_SelectedIndexChanged);
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "Tour";
            this.bindingSource2.DataSource = this.advTimeDataSet2;
            // 
            // advTimeDataSet2
            // 
            this.advTimeDataSet2.DataSetName = "AdvTimeDataSet";
            this.advTimeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Tourdatabox
            // 
            this.Tourdatabox.Location = new System.Drawing.Point(132, 107);
            this.Tourdatabox.Name = "Tourdatabox";
            this.Tourdatabox.Size = new System.Drawing.Size(200, 20);
            this.Tourdatabox.TabIndex = 1;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(129, 41);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(13, 13);
            this.labelid.TabIndex = 2;
            this.labelid.Text = "0\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тур";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Дата отправления";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(132, 143);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Дата возвращения";
            // 
            // tourTableAdapter1
            // 
            this.tourTableAdapter1.ClearBeforeFill = true;
            // 
            // scheduleTableAdapter1
            // 
            this.scheduleTableAdapter1.ClearBeforeFill = true;
            // 
            // newschedul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 229);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.Tourdatabox);
            this.Controls.Add(this.Tourchoosebox);
            this.Name = "newschedul";
            this.Text = "Новое расписание";
            this.Load += new System.EventHandler(this.newschedul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTimeDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Tourchoosebox;
        private System.Windows.Forms.DateTimePicker Tourdatabox;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private AdvTimeDataSetTableAdapters.TourTableAdapter tourTableAdapter;
        private AdvTimeDataSet advTimeDataSet2;
        private AdvTimeDataSetTableAdapters.TourTableAdapter tourTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private AdvTimeDataSetTableAdapters.ScheduleTableAdapter scheduleTableAdapter1;
    }
}