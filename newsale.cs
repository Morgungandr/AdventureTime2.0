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
    public partial class newsale : Form
    {
       
        public newsale()
        {
            InitializeComponent();
        }

        private void newsale_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advTimeDataSet1.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.advTimeDataSet1.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advTimeDataSet1.Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.advTimeDataSet1.Sotrudnik);
            

        }
    }
}
