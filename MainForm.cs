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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                idsale: (dataGridView1.SelectedRows[0].Cells[14].Value.ToString())
                , idschedule: (dataGridView1.SelectedRows[0].Cells[15].Value.ToString())
                , idclient: (dataGridView1.SelectedRows[0].Cells[18].Value.ToString())
                , idsotrudnik:(dataGridView1.SelectedRows[0].Cells[17].Value.ToString())
                , idskidka: (dataGridView1.SelectedRows[0].Cells[19].Value.ToString())
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
            List<string> filterParts = new List<string>();
            if (filterboxcl.Text != "" && filterboxcl.Text != "Клиент")
            {
                filterParts.Add("FIO LIKE '%" + filterboxcl.Text + "%'");
            }
            if (filterboxtour.Text != "" && filterboxtour.Text != "Тур")
            {
                filterParts.Add("tourname LIKE '%" + filterboxtour.Text + "%'");
            }
            if (filterboxsotr.Text != "" && filterboxsotr.Text != "Сотрудник")
            {
                filterParts.Add("FIOsotr LIKE '%" + filterboxsotr.Text + "%'");
            }
            filterParts.Add(string.Format(" dates >= '{0:dd.MM.yyyy}' AND dates <= '{1:dd.MM.yyyy}'"
                , dtPickerSell1.Value.ToShortDateString(), dtPickerSell2.Value.ToShortDateString()));
            filterParts.Add(string.Format(" dateofdispatch >= '{0:dd.MM.yyyy}' AND dateofdispatch <= '{1:dd.MM.yyyy}'"
                , dtPickerdispatch1.Value.ToShortDateString(), dtPickerdispatch2.Value.ToShortDateString()));
            filterParts.Add(string.Format(" returndate >= '{0:dd.MM.yyyy}' AND returndate <= '{1:dd.MM.yyyy}'"
                , dtPickerreturn1.Value.ToShortDateString(), dtPickerreturn2.Value.ToShortDateString()));
            string filter = string.Join(" AND ", filterParts);
            this.salesViewBindingSource.Filter = filter;




            
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sotrudnik clientsform = new Sotrudnik();
            clientsform.ShowDialog();
            
        }

        private void постыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Post clientsform = new Post();
            clientsform.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void filterboxcl_Enter(object sender, EventArgs e)
        {
            filterboxcl.ForeColor = Color.Black;
            filterboxcl.Text = "";
            filterboxcl.Enter -= filterboxcl_Enter;
            filterboxcl.Leave += filterboxcl_Leave;
            filterboxcl.TextChanged += filterboxcl_TextChanged;
        }

        private void filterboxcl_Leave(object sender, EventArgs e)
        {
            filterboxcl.ForeColor = Color.Silver;
            filterboxcl.Text = "Клиент";
            filterboxcl.Enter += filterboxcl_Enter;
        }

        private void filterboxcl_TextChanged(object sender, EventArgs e)
        {
            filterboxcl.Leave -= filterboxcl_Leave;
            filterboxcl.TextChanged -= filterboxcl_TextChanged;
        }

        private void filterboxtour_TextChanged(object sender, EventArgs e)
        {
            filterboxtour.Leave -= filterboxtour_Leave;
            filterboxtour.TextChanged -= filterboxtour_TextChanged;
        }

        private void filterboxtour_Enter(object sender, EventArgs e)
        {
            filterboxtour.ForeColor = Color.Black;
            filterboxtour.Text = "";
            filterboxtour.Enter -= filterboxtour_Enter;
            filterboxtour.Leave += filterboxtour_Leave;
            filterboxtour.TextChanged += filterboxtour_TextChanged;
        }

        

        private void filterboxtour_Leave(object sender, EventArgs e)
        {
            filterboxtour.ForeColor = Color.Silver;
            filterboxtour.Text = "Тур";
            filterboxtour.Enter += filterboxtour_Enter;
        }

        private void filterboxsotr_Enter(object sender, EventArgs e)
        {
            filterboxsotr.ForeColor = Color.Black;
            filterboxsotr.Text = "";
            filterboxsotr.Enter -= filterboxsotr_Enter;
            filterboxsotr.Leave += filterboxsotr_Leave;
            filterboxsotr.TextChanged += filterboxsotr_TextChanged;
        }

        private void filterboxsotr_Leave(object sender, EventArgs e)
        {
            filterboxsotr.ForeColor = Color.Silver;
            filterboxsotr.Text = "Сотрудник";
            filterboxsotr.Enter += filterboxsotr_Enter;
        }

        private void filterboxsotr_TextChanged(object sender, EventArgs e)
        {
            filterboxsotr.Leave -= filterboxsotr_Leave;
            filterboxsotr.TextChanged -= filterboxsotr_TextChanged;
        }
    }
    public static class LoggedUser
    {
        public static string loggeduser = "";
        public static string prava = "";
    }
}
