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
    public partial class tourform : Form
    {
        public tourform()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advTimeDataSet1.Tours". При необходимости она может быть перемещена или удалена.
            this.toursTableAdapter1.Fill(this.advTimeDataSet1.Tours);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advTimeDataSet1.DataTable2". При необходимости она может быть перемещена или удалена.
            this.toursTableAdapter1   .Fill(this.advTimeDataSet1.Tours);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advTimeDataSet1.DataTable1". При необходимости она может быть перемещена или удалена.
            this.toursTableAdapter1.Fill(this.advTimeDataSet1.Tours);
          
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advTimeDataSet1.Tour". При необходимости она может быть перемещена или удалена.
         //   this.tourTableAdapter.Fill(this.advTimeDataSet1.Tour);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toursearch_Click(object sender, EventArgs e)
        {
            this.bindingSource1.Filter = "tourname LIKE '%" + filterbox.Text + "%'";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewTour clientsform = new NewTour();
            clientsform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewTour clientsform = new NewTour(idtour: (dataGridView1.SelectedRows[0].Cells[0].Value.ToString()),
               idvidtura: (dataGridView1.SelectedRows[0].Cells[11].Value.ToString()),
            idpitanie: (dataGridView1.SelectedRows[0].Cells[12].Value.ToString()),
            idoperator: (dataGridView1.SelectedRows[0].Cells[13].Value.ToString()),
            tourname: (dataGridView1.SelectedRows[0].Cells[1].Value.ToString()),
            country: (dataGridView1.SelectedRows[0].Cells[2].Value.ToString()),
            duration: (dataGridView1.SelectedRows[0].Cells[8].Value.ToString()),
            maxchild: (dataGridView1.SelectedRows[0].Cells[6].Value.ToString()),
            maxadult: (dataGridView1.SelectedRows[0].Cells[7].Value.ToString()),
            departurecity: (dataGridView1.SelectedRows[0].Cells[10].Value.ToString()),
             tourprice: (dataGridView1.SelectedRows[0].Cells[5].Value.ToString())
             );
            this.toursTableAdapter1.Fill(this.advTimeDataSet1.Tours);
            clientsform.ShowDialog();
        }
    }
}
