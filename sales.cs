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
    public partial class sales : Form
    {
        public sales()
        {
            InitializeComponent();
        }

        private void sales_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advTimeDataSet.SaleFull". При необходимости она может быть перемещена или удалена.
            this.saleFullTableAdapter.Fill(this.advTimeDataSet.SaleFull);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advTimeDataSet.SaleFull". При необходимости она может быть перемещена или удалена.
            this.saleFullTableAdapter.Fill(this.advTimeDataSet.SaleFull);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advTimeDataSet.Account". При необходимости она может быть перемещена или удалена.
            this.accountTableAdapter.Fill(this.advTimeDataSet.Account);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            newsale clientsform = new newsale();
            clientsform.ShowDialog();
        }
    }
}
