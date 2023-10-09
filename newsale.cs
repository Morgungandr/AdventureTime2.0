using AdventureTime.AdvTimeDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureTime
{
    public partial class newsale : Form
    {
        public int idcl = 0;
        public int idskidk = 0;
        public newsale(string idsale = "0"
            , string idclient = "0"
            , string idskidka = "0"
            , DateTime saledate = default(DateTime)
            )
        {
            InitializeComponent();
            idcl = Convert.ToInt32(idclient);
            idskidk =  Convert.ToInt32(idskidka);
            labelid.Text = idsale;
            if (saledate == default(DateTime)) { dateTimePicker1.Value = DateTime.Today; }
            else { dateTimePicker1.Value = saledate; }
        }

        private void newsale_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advTimeDataSet1.Skidka". При необходимости она может быть перемещена или удалена.
            this.skidkaTableAdapter.Fill(this.advTimeDataSet1.Skidka);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advTimeDataSet1.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.advTimeDataSet1.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advTimeDataSet1.Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.advTimeDataSet1.Sotrudnik);
            clientchoosebox.SelectedValue = idcl;
            skidkacombobox.SelectedValue = idskidk;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public static class ChosenTour
        {
            public static string chosentourdata = "";
            public static string chosentourid = "";
            public static string chosenprice = "";
            public static double SelPrc = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Selecttour clientsform = new Selecttour();
            clientsform.ShowDialog();
            textBox1.Text = ChosenTour.chosentourdata;
            PriceBox.Text = ChosenTour.chosenprice;
            EndPriceBox.Text = Convert.ToString(Convert.ToDouble(ChosenTour.chosenprice) - Convert.ToDouble(ChosenTour.chosenprice) * ChosenTour.SelPrc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (labelid.Text == "0")
            {
                this.saleTableAdapter1.NewSale(Convert.ToInt32(LoggedUser.loggeduser), Convert.ToInt32(ChosenTour.chosentourid),  Convert.ToInt32(clientchoosebox.SelectedValue)
                       
                    , Convert.ToInt32(skidkacombobox.SelectedValue), Convert.ToDecimal(EndPriceBox), dateTimePicker1.Value
                    );
            }
            else
            {
                this.saleTableAdapter1.EditeSale( Convert.ToInt32(labelid.Text)
                          , Convert.ToInt32(clientchoosebox.SelectedValue)
                          , ChosenTour.chosentourid
                          , Convert.ToInt32(skidkacombobox.SelectedValue)
                          , Convert.ToInt32(EndPriceBox)
                          , LoggedUser.loggeduser
                          , dateTimePicker1.Value
                     );
            }
            this.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           ChosenTour.SelPrc  = (double)this.skidkaTableAdapter.percentqarry(Convert.ToInt32(skidkacombobox.SelectedValue));
            EndPriceBox.Text = Convert.ToString(Convert.ToDouble(ChosenTour.chosenprice) -Convert.ToDouble(ChosenTour.chosenprice) * ChosenTour.SelPrc);
          
        }
    }
}
