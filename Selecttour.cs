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
    public partial class Selecttour : Form
    {
        public Selecttour()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            newsale.ChosenTour.chosentourid = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            newsale.ChosenTour.chosentourdata = dataGridView1.SelectedRows[0].Cells[2].Value.ToString() 
                + ", c " + dataGridView1.SelectedRows[0].Cells[3].Value.ToString() 
                + " по " + dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            newsale.ChosenTour.chosenprice = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            this.Close();

        }

        private void scheduleBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Selecttour_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advTimeDataSet1.Schedulefull". При необходимости она может быть перемещена или удалена.
            this.schedulefullTableAdapter.Fill(this.advTimeDataSet2.Schedulefull);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advTimeDataSet.Schedule". При необходимости она может быть перемещена или удалена.
            this.scheduleTableAdapter.Fill(this.advTimeDataSet2.Schedule);
        }
    }
}
