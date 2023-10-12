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
    public partial class Post : Form
    {
        public Post()
        {
            InitializeComponent();
        }

        private void Post_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advTimeDataSet.Post". При необходимости она может быть перемещена или удалена.
            this.postTableAdapter.Fill(this.advTimeDataSet.Post);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.postTableAdapter.Update(this.advTimeDataSet.Post);
        }
    }
}
