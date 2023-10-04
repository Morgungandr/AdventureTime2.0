namespace AdventureTime
{
    partial class Vidtura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vidtura));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.vidturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advTimeDataSet = new AdventureTime.AdvTimeDataSet();
            this.vidturaTableAdapter = new AdventureTime.AdvTimeDataSetTableAdapters.VidturaTableAdapter();
            this.idvidtura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idvidturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vidturanameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vidturaopisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vidturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTimeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvidtura,
            this.idvidturaDataGridViewTextBoxColumn,
            this.vidturanameDataGridViewTextBoxColumn,
            this.vidturaopisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vidturaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(64, 70);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(613, 301);
            this.dataGridView1.TabIndex = 0;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.vidturaBindingSource;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // vidturaBindingSource
            // 
            this.vidturaBindingSource.DataMember = "Vidtura";
            this.vidturaBindingSource.DataSource = this.advTimeDataSet;
            // 
            // advTimeDataSet
            // 
            this.advTimeDataSet.DataSetName = "AdvTimeDataSet";
            this.advTimeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vidturaTableAdapter
            // 
            this.vidturaTableAdapter.ClearBeforeFill = true;
            // 
            // idvidtura
            // 
            this.idvidtura.DataPropertyName = "idvidtura";
            this.idvidtura.HeaderText = "idvidtura";
            this.idvidtura.Name = "idvidtura";
            this.idvidtura.ReadOnly = true;
            this.idvidtura.Visible = false;
            // 
            // idvidturaDataGridViewTextBoxColumn
            // 
            this.idvidturaDataGridViewTextBoxColumn.DataPropertyName = "idvidtura";
            this.idvidturaDataGridViewTextBoxColumn.HeaderText = "idvidtura";
            this.idvidturaDataGridViewTextBoxColumn.Name = "idvidturaDataGridViewTextBoxColumn";
            this.idvidturaDataGridViewTextBoxColumn.Visible = false;
            // 
            // vidturanameDataGridViewTextBoxColumn
            // 
            this.vidturanameDataGridViewTextBoxColumn.DataPropertyName = "vidturaname";
            this.vidturanameDataGridViewTextBoxColumn.HeaderText = "vidturaname";
            this.vidturanameDataGridViewTextBoxColumn.Name = "vidturanameDataGridViewTextBoxColumn";
            // 
            // vidturaopisDataGridViewTextBoxColumn
            // 
            this.vidturaopisDataGridViewTextBoxColumn.DataPropertyName = "vidturaopis";
            this.vidturaopisDataGridViewTextBoxColumn.HeaderText = "vidturaopis";
            this.vidturaopisDataGridViewTextBoxColumn.Name = "vidturaopisDataGridViewTextBoxColumn";
            // 
            // Vidtura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Vidtura";
            this.Text = "Виды туров";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vidturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTimeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AdvTimeDataSet advTimeDataSet;
        private System.Windows.Forms.BindingSource vidturaBindingSource;
        private AdvTimeDataSetTableAdapters.VidturaTableAdapter vidturaTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvidtura;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvidturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vidturanameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vidturaopisDataGridViewTextBoxColumn;
    }
}