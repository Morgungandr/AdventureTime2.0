namespace AdventureTime
{
    partial class newoper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newoper));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.advTimeDataSet = new AdventureTime.AdvTimeDataSet();
            this.operatorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operatorsTableAdapter = new AdventureTime.AdvTimeDataSetTableAdapters.OperatorsTableAdapter();
            this.idoperatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatoropisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTimeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.operatorsBindingSource;
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
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 25);
            this.bindingNavigator1.TabIndex = 0;
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idoperatorDataGridViewTextBoxColumn,
            this.operatornameDataGridViewTextBoxColumn,
            this.operatoropisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.operatorsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(43, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(654, 331);
            this.dataGridView1.TabIndex = 1;
            // 
            // advTimeDataSet
            // 
            this.advTimeDataSet.DataSetName = "AdvTimeDataSet";
            this.advTimeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // operatorsBindingSource
            // 
            this.operatorsBindingSource.DataMember = "Operators";
            this.operatorsBindingSource.DataSource = this.advTimeDataSet;
            // 
            // operatorsTableAdapter
            // 
            this.operatorsTableAdapter.ClearBeforeFill = true;
            // 
            // idoperatorDataGridViewTextBoxColumn
            // 
            this.idoperatorDataGridViewTextBoxColumn.DataPropertyName = "idoperator";
            this.idoperatorDataGridViewTextBoxColumn.HeaderText = "idoperator";
            this.idoperatorDataGridViewTextBoxColumn.Name = "idoperatorDataGridViewTextBoxColumn";
            this.idoperatorDataGridViewTextBoxColumn.Visible = false;
            // 
            // operatornameDataGridViewTextBoxColumn
            // 
            this.operatornameDataGridViewTextBoxColumn.DataPropertyName = "operatorname";
            this.operatornameDataGridViewTextBoxColumn.HeaderText = "Оператор";
            this.operatornameDataGridViewTextBoxColumn.Name = "operatornameDataGridViewTextBoxColumn";
            // 
            // operatoropisDataGridViewTextBoxColumn
            // 
            this.operatoropisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.operatoropisDataGridViewTextBoxColumn.DataPropertyName = "operatoropis";
            this.operatoropisDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.operatoropisDataGridViewTextBoxColumn.Name = "operatoropisDataGridViewTextBoxColumn";
            this.operatoropisDataGridViewTextBoxColumn.Width = 82;
            // 
            // newoper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "newoper";
            this.Text = "Тур Оператор";
            this.Load += new System.EventHandler(this.newoper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTimeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AdvTimeDataSet advTimeDataSet;
        private System.Windows.Forms.BindingSource operatorsBindingSource;
        private AdvTimeDataSetTableAdapters.OperatorsTableAdapter operatorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idoperatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatoropisDataGridViewTextBoxColumn;
    }
}