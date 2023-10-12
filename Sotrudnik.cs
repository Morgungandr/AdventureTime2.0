using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureTime
{
    public partial class Sotrudnik : Form
    {
        public Sotrudnik()
        {
            InitializeComponent();
        }

        private void Sotrudnik_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advTimeDataSet.SotrFull". При необходимости она может быть перемещена или удалена.
            this.sotrFullTableAdapter.Fill(this.advTimeDataSet.SotrFull);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advTimeDataSet.Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.advTimeDataSet.Sotrudnik);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            NewSotr clientsform = new NewSotr();
            clientsform.ShowDialog();
            this.sotrFullTableAdapter.Fill(this.advTimeDataSet.SotrFull);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            NewSotr clientsform = new NewSotr(
                idsotrudnik: (dataGridView1.SelectedRows[0].Cells[0].Value.ToString())
                , idpost: (dataGridView1.SelectedRows[0].Cells[1].Value.ToString())
                , FIOsotr: (dataGridView1.SelectedRows[0].Cells[2].Value.ToString())
                , gender: (dataGridView1.SelectedRows[0].Cells[3].Value.ToString())
                , residence: (dataGridView1.SelectedRows[0].Cells[4].Value.ToString())
                , phone: (dataGridView1.SelectedRows[0].Cells[5].Value.ToString())
                , passport: (dataGridView1.SelectedRows[0].Cells[6].Value.ToString())
                , inn: (dataGridView1.SelectedRows[0].Cells[7].Value.ToString())
                , snils: (dataGridView1.SelectedRows[0].Cells[8].Value.ToString())
                , login: (dataGridView1.SelectedRows[0].Cells[9].Value.ToString())
                , password: (dataGridView1.SelectedRows[0].Cells[10].Value.ToString())
                , prava: (dataGridView1.SelectedRows[0].Cells[11].Value.ToString())
                );
            clientsform.ShowDialog();
            this.sotrFullTableAdapter.Fill(this.advTimeDataSet.SotrFull);
        }
    }
}
