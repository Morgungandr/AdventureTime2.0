using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureTime
{
    public partial class NewSotr : Form
    {
        public int idpos = 0;
        public NewSotr(string idsotrudnik = "0"
            , string FIOsotr = ""            
           , string gender = ""
            , string residence = ""
           , string phone = ""
            , string passport = ""
            , string inn = ""
            , string snils = ""
           , string login = ""
           , string password = ""
           , string idpost = "0")
        {
            InitializeComponent();
            labelid.Text = idsotrudnik;
            idpos = Convert.ToInt32(idpost);
            fiosotr.Text = FIOsotr;
            gen.Text = gender;
            res.Text = residence;
            phon.Text = phone;
            pasp.Text =passport;
            innn.Text = inn;
            snil.Text =snils ;
            log.Text =login;
            pas.Text =password ;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewSotr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advTimeDataSet.Post". При необходимости она может быть перемещена или удалена.
            this.postTableAdapter.Fill(this.advTimeDataSet.Post);
            PostchooseBox.SelectedValue = idpos;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (labelid.Text == "0")
            {
                this.sotrudnikTableAdapter1.NewSotr(Convert.ToInt32(PostchooseBox.SelectedValue)
                            , fiosotr.Text
                            , gen.Text
                            , res.Text
                            , phon.Text
                            , pasp.Text
                            , innn.Text
                            , snil.Text
                            , log.Text
                            , pas.Text
                            );
            }
            else
            {
                this.sotrudnikTableAdapter1.EditSotr(Convert.ToInt32(labelid.Text)
                            , Convert.ToInt32(PostchooseBox.SelectedValue)
                            , fiosotr.Text
                            , gen.Text
                            , res.Text
                            , phon.Text
                            , pasp.Text
                            , innn.Text
                            , snil.Text
                            , log.Text
                            , pas.Text);
            }
            this.Close();
        }
    }
}
