using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AdventureTime
{
    public partial class NewTour : Form
    {
        public int idvids = 0;
        public int idpit = 0;
        public int idop = 0;
        public NewTour(string idtour = "0",
              string idvidtura = "101"
            , string idpitanie = "0"
            , string idoperator = "0"
            , string tourname = ""
           , string country = ""
           , string duration = ""
            , string maxchild = ""
           , string maxadult = ""
           , string departurecity = ""
           , string tourprice = "0")
        {
            InitializeComponent();
            idvids = Convert.ToInt32(idvidtura);
            idpit = Convert.ToInt32(idpitanie);
            idop = Convert.ToInt32(idoperator);
            labelid.Text = idtour;
            namebox.Text = tourname;
            pricebox.Text = tourprice;
            durationbox.Text = duration;
            maxad.Text = maxadult;
            maxch.Text = maxchild;
            depart.Text = departurecity;
            countrybox.Text = country;
        }

        private void NewTour_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advTimeDataSet1.Operators". При необходимости она может быть перемещена или удалена.
            this.operatorsTableAdapter1.Fill(this.advTimeDataSet1.Operators);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advTimeDataSet.Pitanie". При необходимости она может быть перемещена или удалена.
            this.pitanieTableAdapter.Fill(this.advTimeDataSet.Pitanie);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advTimeDataSet.Vidtura". При необходимости она может быть перемещена или удалена.
            this.vidturaTableAdapter.Fill(this.advTimeDataSet.Vidtura);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advTimeDataSet.Tours". При необходимости она может быть перемещена или удалена.
            this.toursTableAdapter1.Fill(this.advTimeDataSet.Tours);
            this.tourTableAdapter1.Fill(this.advTimeDataSet.Tour);
            idvid.SelectedValue = idvids;
            pitbox.SelectedValue = idpit;
            operbox.SelectedValue = idop;
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (labelid.Text == "0")
            {
                this.tourTableAdapter1.NewTour(
                              Convert.ToInt32(idvid.SelectedValue)
                            , Convert.ToInt32(pitbox.SelectedValue)
                            , Convert.ToInt32(operbox.SelectedValue)
                            , namebox.Text
                            , Convert.ToDecimal(pricebox.Text)
                            , depart.Text 
                            , Convert.ToInt32(maxad.Text)
                            , maxch.Text
                            , Convert.ToInt32(durationbox.Text)
                            , countrybox.Text
                            );
            }
            else
            {
                this.tourTableAdapter1.EditTour(Convert.ToInt32(labelid.Text)
                            , Convert.ToInt32(idvid.SelectedValue)
                            , Convert.ToInt32(pitbox.SelectedValue)
                            , Convert.ToInt32(operbox.SelectedValue)
                            , namebox.Text
                            , Convert.ToDecimal(pricebox.Text)
                            , depart.Text 
                            , Convert.ToInt32(maxad.Text)
                            , maxch.Text
                            , Convert.ToInt32(durationbox.Text)
                            , countrybox.Text
                            );
            }
            this.Close();
        }
    }
}
