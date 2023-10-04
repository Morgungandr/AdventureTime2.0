using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AdventureTime
{
    public partial class Form3 : Form 
    {
        public Form3(string idclient = "0"
            , string FIO = ""
            , DateTime birthdate = default(DateTime) 
           , string passportseria = ""
           , string passportnomer  = ""
            , string documents  = ""
           ,string phone = ""
           , string personaldataoftheclient = ""
           , string ransom = "0")
        {   
          
            InitializeComponent();
            labelid.Text = idclient;
            fio.Text = FIO;
            if (birthdate == default(DateTime)) { dateTimePicker1.Value = DateTime.Today; }
            else { dateTimePicker1.Value = birthdate;}
            
            nom.Text = passportnomer;
            ser.Text = passportseria;
            doc.Text = documents;
            tel.Text = phone;
            inf.Text = personaldataoftheclient;
            sum.Text = ransom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelid.Text == "0")
            {
                this.clientTableAdapter1.NewClient(fio.Text
                            , dateTimePicker1.Value
                            , nom.Text
                            , ser.Text
                            , doc.Text
                            , tel.Text
                            , inf.Text
                            , Convert.ToInt64(sum.Text));
            }
            else { 
                this.clientTableAdapter1.EditClient(Convert.ToInt32(labelid.Text)
                            ,fio.Text
                            , dateTimePicker1.Value
                            , nom.Text
                            , ser.Text
                            , doc.Text
                            , tel.Text
                            , inf.Text
                            , Convert.ToDecimal(sum.Text));
            }
            this.Close();
          
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }
    }
}
