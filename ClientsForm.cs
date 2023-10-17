using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AdventureTime
{
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advTimeDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.advTimeDataSet.Client);

            this.selectToursbyClientTableAdapter.Fill(this.advTimeDataSet.SelectToursbyClient, Convert.ToInt16(advTimeDataSet.Client.FirstOrDefault()[0].ToString()));

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var rowsCount = dataGridView1.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1) return;
            this.selectToursbyClientTableAdapter.Fill(this.advTimeDataSet.SelectToursbyClient, Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
        }

        private void addclientbutton_Click(object sender, EventArgs e)
        {
            NewClient clientsform = new NewClient();
            clientsform.ShowDialog();
            this.clientTableAdapter.Fill(this.advTimeDataSet.Client);

            this.selectToursbyClientTableAdapter.Fill(this.advTimeDataSet.SelectToursbyClient, Convert.ToInt16(advTimeDataSet.Client.FirstOrDefault()[0].ToString()));

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewClient clientsform = new NewClient( idclient: (dataGridView1.SelectedRows[0].Cells[0].Value.ToString()),
               FIO: (dataGridView1.SelectedRows[0].Cells[1].Value.ToString()),
            birthdate : (Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[2].Value.ToString())),
            passportseria: (dataGridView1.SelectedRows[0].Cells[4].Value.ToString()),
            passportnomer: (dataGridView1.SelectedRows[0].Cells[5].Value.ToString()),
            documents: (dataGridView1.SelectedRows[0].Cells[3].Value.ToString()),
            phone: (dataGridView1.SelectedRows[0].Cells[6].Value.ToString()),
            personaldataoftheclient: (dataGridView1.SelectedRows[0].Cells[7].Value.ToString()),
            ransom: (dataGridView1.SelectedRows[0].Cells[8].Value.ToString()));
            clientsform.ShowDialog();
            this.clientTableAdapter.Fill(this.advTimeDataSet.Client);

            this.selectToursbyClientTableAdapter.Fill(this.advTimeDataSet.SelectToursbyClient, Convert.ToInt16(advTimeDataSet.Client.FirstOrDefault()[0].ToString()));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.bindingSource1.Filter = "FIO LIKE '%"+ filterbox.Text +"%'";
        }

        private void filterbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
