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
using static AdventureTime.AdvTimeDataSet;

namespace AdventureTime
{
    public partial class newsale : Form
    {
        public int idcl = 0;
        public int idskidk = 0;
        public int idsc = 0;
        public int idsotr  = 0;
        public newsale(string idsale = "0"
            , string idclient = "0"
            , string idskidka = "101"
            , string idschedule = "0"
            , string idsotrudnik = "0"
            )
        {
            InitializeComponent();
            idcl = Convert.ToInt32(idclient);
            idskidk =  Convert.ToInt32(idskidka);
            idsc = Convert.ToInt32(idschedule);
            labelid.Text = idsale;
            idsotr = Convert.ToInt32(idsotrudnik);    
            dateTimePicker1.Value = DateTime.Today; 
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
            
            if (labelid.Text != "0") {
                DataRow CurSc = schedulefullTableAdapter1.GetDataBy(idsc)[0];
                ChosenTour.chosentourdata = CurSc[9].ToString()
                + ", c " + CurSc[1].ToString()
                + " по " + CurSc[2].ToString() ;
                ChosenTour.chosenprice = CurSc[8].ToString() ;
                textBox1.Text = ChosenTour.chosentourdata;
                PriceBox.Text = ChosenTour.chosenprice;
                ChosenTour.SelPrc = (double)this.skidkaTableAdapter.percentqarry(idskidk);
                EndPriceBox.Text = Convert.ToString(Convert.ToDouble(ChosenTour.chosenprice) - Convert.ToDouble(ChosenTour.chosenprice) * ChosenTour.SelPrc);
            }
            if (idsotr != 0)
            {
                SotrudnikBox.SelectedValue = idsotr;
            }
            else { SotrudnikBox.SelectedValue = Convert.ToInt32(LoggedUser.loggeduser); }
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
                this.saleTableAdapter1.NewSale( Convert.ToInt32(LoggedUser.loggeduser)
                    , Convert.ToInt32(ChosenTour.chosentourid)
                    ,  Convert.ToInt32(clientchoosebox.SelectedValue)
                   , dateTimePicker1.Value
                   , Convert.ToInt32(skidkacombobox.SelectedValue)
                   , Convert.ToDecimal(EndPriceBox.Text)
                    );
            }
            else
            {
                this.saleTableAdapter1.EditSale(Convert.ToInt32(labelid.Text)
                    , Convert.ToInt32(LoggedUser.loggeduser)
                    , Convert.ToInt32(ChosenTour.chosentourid)
                    , Convert.ToInt32(clientchoosebox.SelectedValue)
                    , dateTimePicker1.Value
                    , Convert.ToInt32(skidkacombobox.SelectedValue)
                    , Convert.ToDecimal(EndPriceBox)
                     );
            }
            this.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           ChosenTour.SelPrc  = (double)this.skidkaTableAdapter.percentqarry(Convert.ToInt32(skidkacombobox.SelectedValue));
            EndPriceBox.Text = Convert.ToString(Convert.ToDouble(ChosenTour.chosenprice) - Convert.ToDouble(ChosenTour.chosenprice) * ChosenTour.SelPrc);
          
        }
    }
}
