namespace AdventureTime
{
    partial class NewSotr
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
            this.fiosotr = new System.Windows.Forms.TextBox();
            this.gen = new System.Windows.Forms.TextBox();
            this.res = new System.Windows.Forms.TextBox();
            this.phon = new System.Windows.Forms.TextBox();
            this.pasp = new System.Windows.Forms.TextBox();
            this.innn = new System.Windows.Forms.TextBox();
            this.snil = new System.Windows.Forms.TextBox();
            this.log = new System.Windows.Forms.TextBox();
            this.pas = new System.Windows.Forms.TextBox();
            this.PostchooseBox = new System.Windows.Forms.ComboBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advTimeDataSet = new AdventureTime.AdvTimeDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.postTableAdapter = new AdventureTime.AdvTimeDataSetTableAdapters.PostTableAdapter();
            this.sotrudnikTableAdapter1 = new AdventureTime.AdvTimeDataSetTableAdapters.SotrudnikTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.prav = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTimeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(110, 43);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(13, 13);
            this.labelid.TabIndex = 0;
            this.labelid.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ФИО";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Пол";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Родной город";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Телефон";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Паспорт";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "ИНН";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "СНИЛС";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Логин";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Пароль";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 413);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Должность";
            // 
            // fiosotr
            // 
            this.fiosotr.Location = new System.Drawing.Point(113, 69);
            this.fiosotr.Name = "fiosotr";
            this.fiosotr.Size = new System.Drawing.Size(259, 20);
            this.fiosotr.TabIndex = 1;
            // 
            // gen
            // 
            this.gen.Location = new System.Drawing.Point(113, 102);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(259, 20);
            this.gen.TabIndex = 1;
            // 
            // res
            // 
            this.res.Location = new System.Drawing.Point(113, 135);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(259, 20);
            this.res.TabIndex = 1;
            // 
            // phon
            // 
            this.phon.Location = new System.Drawing.Point(113, 169);
            this.phon.Name = "phon";
            this.phon.Size = new System.Drawing.Size(259, 20);
            this.phon.TabIndex = 1;
            // 
            // pasp
            // 
            this.pasp.Location = new System.Drawing.Point(113, 205);
            this.pasp.Name = "pasp";
            this.pasp.Size = new System.Drawing.Size(259, 20);
            this.pasp.TabIndex = 1;
            // 
            // innn
            // 
            this.innn.Location = new System.Drawing.Point(113, 238);
            this.innn.Name = "innn";
            this.innn.Size = new System.Drawing.Size(259, 20);
            this.innn.TabIndex = 1;
            // 
            // snil
            // 
            this.snil.Location = new System.Drawing.Point(113, 271);
            this.snil.Name = "snil";
            this.snil.Size = new System.Drawing.Size(259, 20);
            this.snil.TabIndex = 1;
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(113, 305);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(259, 20);
            this.log.TabIndex = 1;
            // 
            // pas
            // 
            this.pas.Location = new System.Drawing.Point(113, 343);
            this.pas.Name = "pas";
            this.pas.Size = new System.Drawing.Size(259, 20);
            this.pas.TabIndex = 1;
            // 
            // PostchooseBox
            // 
            this.PostchooseBox.DataSource = this.postBindingSource;
            this.PostchooseBox.DisplayMember = "post";
            this.PostchooseBox.FormattingEnabled = true;
            this.PostchooseBox.Location = new System.Drawing.Point(113, 404);
            this.PostchooseBox.Name = "PostchooseBox";
            this.PostchooseBox.Size = new System.Drawing.Size(259, 21);
            this.PostchooseBox.TabIndex = 2;
            this.PostchooseBox.ValueMember = "idpost";
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataMember = "Post";
            this.postBindingSource.DataSource = this.advTimeDataSet;
            // 
            // advTimeDataSet
            // 
            this.advTimeDataSet.DataSetName = "AdvTimeDataSet";
            this.advTimeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(297, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // postTableAdapter
            // 
            this.postTableAdapter.ClearBeforeFill = true;
            // 
            // sotrudnikTableAdapter1
            // 
            this.sotrudnikTableAdapter1.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Права";
            // 
            // prav
            // 
            this.prav.Location = new System.Drawing.Point(113, 374);
            this.prav.Name = "prav";
            this.prav.Size = new System.Drawing.Size(259, 20);
            this.prav.TabIndex = 5;
            // 
            // NewSotr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 474);
            this.Controls.Add(this.prav);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PostchooseBox);
            this.Controls.Add(this.pas);
            this.Controls.Add(this.log);
            this.Controls.Add(this.snil);
            this.Controls.Add(this.innn);
            this.Controls.Add(this.pasp);
            this.Controls.Add(this.phon);
            this.Controls.Add(this.res);
            this.Controls.Add(this.gen);
            this.Controls.Add(this.fiosotr);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "NewSotr";
            this.Text = "Настройка";
            this.Load += new System.EventHandler(this.NewSotr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTimeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox fiosotr;
        private System.Windows.Forms.TextBox gen;
        private System.Windows.Forms.TextBox res;
        private System.Windows.Forms.TextBox phon;
        private System.Windows.Forms.TextBox pasp;
        private System.Windows.Forms.TextBox innn;
        private System.Windows.Forms.TextBox snil;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.TextBox pas;
        private System.Windows.Forms.ComboBox PostchooseBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private AdvTimeDataSet advTimeDataSet;
        private System.Windows.Forms.BindingSource postBindingSource;
        private AdvTimeDataSetTableAdapters.PostTableAdapter postTableAdapter;
        private AdvTimeDataSetTableAdapters.SotrudnikTableAdapter sotrudnikTableAdapter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prav;
    }
}