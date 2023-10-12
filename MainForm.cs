using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace AdventureTime
{
    
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advTimeDataSet1.SalesView1". При необходимости она может быть перемещена или удалена.
            //LoggedUser.loggeduser = "102";
               Login form = new Login();
               form.ShowDialog();
              if (LoggedUser.loggeduser == "") {
                  System.Windows.Forms.Application.Exit();
              }

            salesViewTableAdapter1.Fill(advTimeDataSet.SalesView);

            if (LoggedUser.prava == "admin") { сотрудникиToolStripMenuItem.Visible = true; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientsForm clientsform = new ClientsForm();
            clientsform.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tourform clientsform = new tourform();
            clientsform.ShowDialog();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void справочникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void видыТуровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vidtura clientsform = new Vidtura();
            clientsform.ShowDialog();
        }

        private void питаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPit clientsform = new NewPit();
            clientsform.ShowDialog();
        }
        private void операторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newoper clientsform = new newoper();
            clientsform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Schedule clientsform = new Schedule();
            clientsform.ShowDialog();
        }

        private void salebutton_Click(object sender, EventArgs e)
        {
            newsale clientsform = new newsale();
            clientsform.ShowDialog();
            salesViewTableAdapter1.Fill(advTimeDataSet.SalesView);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            newsale clientsform = new newsale(
                idsale: (dataGridView1.SelectedRows[0].Cells[12].Value.ToString())
                , idschedule: (dataGridView1.SelectedRows[0].Cells[13].Value.ToString())
                , idclient: (dataGridView1.SelectedRows[0].Cells[16].Value.ToString())
                , idsotrudnik:(dataGridView1.SelectedRows[0].Cells[15].Value.ToString())
                , idskidka: (dataGridView1.SelectedRows[0].Cells[17].Value.ToString())
                );
            clientsform.ShowDialog();
            salesViewTableAdapter1.Fill(advTimeDataSet.SalesView);

        }

        private void возвратToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.salesViewBindingSource.Filter = "FIO LIKE '%" + filterboxcl.Text + "%'";
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClientSearch_Click_2(object sender, EventArgs e)
        {
            this.salesViewBindingSource.Filter = "FIO LIKE '%" + filterboxcl.Text + "%'";
        }

        private void TourSearch_Click_2(object sender, EventArgs e)
        {
            this.salesViewBindingSource.Filter = "tourname LIKE '%" + filterboxtour.Text + "%'";
        }

        private void SotrSearch_Click_2(object sender, EventArgs e)
        {
            this.salesViewBindingSource.Filter = "FIOsotr LIKE '%" + filterboxsotr.Text + "%'";
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sotrudnik clientsform = new Sotrudnik();
            clientsform.ShowDialog();
            
        }

        private void постыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
    public static class LoggedUser
    {
        public static string loggeduser = "";
        public static string prava = "";
    }
}
