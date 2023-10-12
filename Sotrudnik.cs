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
    }
}
