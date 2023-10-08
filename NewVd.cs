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
    public partial class Vidtura : Form
    {
        public Vidtura()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advTimeDataSet.Vidtura". При необходимости она может быть перемещена или удалена.
            this.vidturaTableAdapter.Fill(this.advTimeDataSet.Vidtura);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.vidturaTableAdapter.Update(this.advTimeDataSet.Vidtura);
        }
    }
}
