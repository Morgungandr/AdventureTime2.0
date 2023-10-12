namespace AdventureTime
{
    partial class Sotrudnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sotrudnik));
            this.advTimeDataSet = new AdventureTime.AdvTimeDataSet();
            this.sotrudnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sotrudnikTableAdapter = new AdventureTime.AdvTimeDataSetTableAdapters.SotrudnikTableAdapter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sotrFullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sotrFullTableAdapter = new AdventureTime.AdvTimeDataSetTableAdapters.SotrFullTableAdapter();
            this.idsotrudnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIOsotrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.innDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snilsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pravaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.advTimeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrFullBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // advTimeDataSet
            // 
            this.advTimeDataSet.DataSetName = "AdvTimeDataSet";
            this.advTimeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sotrudnikBindingSource
            // 
            this.sotrudnikBindingSource.DataMember = "Sotrudnik";
            this.sotrudnikBindingSource.DataSource = this.advTimeDataSet;
            // 
            // sotrudnikTableAdapter
            // 
            this.sotrudnikTableAdapter.ClearBeforeFill = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(906, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(63, 22);
            this.toolStripButton1.Text = "Добавить";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(91, 22);
            this.toolStripButton2.Text = "Редактировать";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsotrudnikDataGridViewTextBoxColumn,
            this.idpostDataGridViewTextBoxColumn,
            this.fIOsotrDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.residenceDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.passportDataGridViewTextBoxColumn,
            this.innDataGridViewTextBoxColumn,
            this.snilsDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.pravaDataGridViewTextBoxColumn,
            this.postDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sotrFullBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(906, 422);
            this.dataGridView1.TabIndex = 2;
            // 
            // sotrFullBindingSource
            // 
            this.sotrFullBindingSource.DataMember = "SotrFull";
            this.sotrFullBindingSource.DataSource = this.advTimeDataSet;
            // 
            // sotrFullTableAdapter
            // 
            this.sotrFullTableAdapter.ClearBeforeFill = true;
            // 
            // idsotrudnikDataGridViewTextBoxColumn
            // 
            this.idsotrudnikDataGridViewTextBoxColumn.DataPropertyName = "idsotrudnik";
            this.idsotrudnikDataGridViewTextBoxColumn.HeaderText = "idsotrudnik";
            this.idsotrudnikDataGridViewTextBoxColumn.Name = "idsotrudnikDataGridViewTextBoxColumn";
            this.idsotrudnikDataGridViewTextBoxColumn.Visible = false;
            this.idsotrudnikDataGridViewTextBoxColumn.Width = 64;
            // 
            // idpostDataGridViewTextBoxColumn
            // 
            this.idpostDataGridViewTextBoxColumn.DataPropertyName = "idpost";
            this.idpostDataGridViewTextBoxColumn.HeaderText = "idpost";
            this.idpostDataGridViewTextBoxColumn.Name = "idpostDataGridViewTextBoxColumn";
            this.idpostDataGridViewTextBoxColumn.Visible = false;
            this.idpostDataGridViewTextBoxColumn.Width = 41;
            // 
            // fIOsotrDataGridViewTextBoxColumn
            // 
            this.fIOsotrDataGridViewTextBoxColumn.DataPropertyName = "FIOsotr";
            this.fIOsotrDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fIOsotrDataGridViewTextBoxColumn.Name = "fIOsotrDataGridViewTextBoxColumn";
            this.fIOsotrDataGridViewTextBoxColumn.Width = 59;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 52;
            // 
            // residenceDataGridViewTextBoxColumn
            // 
            this.residenceDataGridViewTextBoxColumn.DataPropertyName = "residence";
            this.residenceDataGridViewTextBoxColumn.HeaderText = "Родной город";
            this.residenceDataGridViewTextBoxColumn.Name = "residenceDataGridViewTextBoxColumn";
            this.residenceDataGridViewTextBoxColumn.Width = 101;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 77;
            // 
            // passportDataGridViewTextBoxColumn
            // 
            this.passportDataGridViewTextBoxColumn.DataPropertyName = "passport";
            this.passportDataGridViewTextBoxColumn.HeaderText = "Паспорт";
            this.passportDataGridViewTextBoxColumn.Name = "passportDataGridViewTextBoxColumn";
            this.passportDataGridViewTextBoxColumn.Width = 75;
            // 
            // innDataGridViewTextBoxColumn
            // 
            this.innDataGridViewTextBoxColumn.DataPropertyName = "inn";
            this.innDataGridViewTextBoxColumn.HeaderText = "ИНН";
            this.innDataGridViewTextBoxColumn.Name = "innDataGridViewTextBoxColumn";
            this.innDataGridViewTextBoxColumn.Width = 56;
            // 
            // snilsDataGridViewTextBoxColumn
            // 
            this.snilsDataGridViewTextBoxColumn.DataPropertyName = "snils";
            this.snilsDataGridViewTextBoxColumn.HeaderText = "СНИЛС";
            this.snilsDataGridViewTextBoxColumn.Name = "snilsDataGridViewTextBoxColumn";
            this.snilsDataGridViewTextBoxColumn.Width = 70;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.Width = 63;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 70;
            // 
            // pravaDataGridViewTextBoxColumn
            // 
            this.pravaDataGridViewTextBoxColumn.DataPropertyName = "prava";
            this.pravaDataGridViewTextBoxColumn.HeaderText = "Уровень доступа";
            this.pravaDataGridViewTextBoxColumn.Name = "pravaDataGridViewTextBoxColumn";
            this.pravaDataGridViewTextBoxColumn.Width = 109;
            // 
            // postDataGridViewTextBoxColumn
            // 
            this.postDataGridViewTextBoxColumn.DataPropertyName = "post";
            this.postDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.postDataGridViewTextBoxColumn.Name = "postDataGridViewTextBoxColumn";
            this.postDataGridViewTextBoxColumn.Width = 90;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Зарплата";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.Width = 80;
            // 
            // Sotrudnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Sotrudnik";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.Sotrudnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advTimeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrFullBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AdvTimeDataSet advTimeDataSet;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource;
        private AdvTimeDataSetTableAdapters.SotrudnikTableAdapter sotrudnikTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sotrFullBindingSource;
        private AdvTimeDataSetTableAdapters.SotrFullTableAdapter sotrFullTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsotrudnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOsotrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn innDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pravaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
    }
}