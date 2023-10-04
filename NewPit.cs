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
    public partial class NewPit : Form
    {
        public NewPit()
        {
            InitializeComponent();
        }

        private void NewPit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advTimeDataSet.Pitanie". При необходимости она может быть перемещена или удалена.
            this.pitanieTableAdapter.Fill(this.advTimeDataSet.Pitanie);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.pitanieTableAdapter.Update(this.advTimeDataSet.Pitanie);
        }
    }
}
