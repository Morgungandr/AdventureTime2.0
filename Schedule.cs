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
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advTimeDataSet1.Schedulefull". При необходимости она может быть перемещена или удалена.
            this.schedulefullTableAdapter.Fill(this.advTimeDataSet2.Schedulefull);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advTimeDataSet.Schedule". При необходимости она может быть перемещена или удалена.
            this.scheduleTableAdapter.Fill(this.advTimeDataSet2.Schedule);

        }

        private void newschedulebutton_Click(object sender, EventArgs e)
        {
            newschedul clientsform = new newschedul();
            clientsform.ShowDialog();
            this.schedulefullTableAdapter.Fill(this.advTimeDataSet2.Schedulefull);

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newschedul clientsform = new newschedul(idschedule: (dataGridView1.SelectedRows[0].Cells[0].Value.ToString())
                , idtour: (dataGridView1.SelectedRows[0].Cells[1].Value.ToString())
                , dateofdispatch: (Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[3].Value.ToString()))
                , returndate: (Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[4].Value.ToString())));
            clientsform.ShowDialog();
            this.schedulefullTableAdapter.Fill(this.advTimeDataSet2.Schedulefull);
        }
    }
}
