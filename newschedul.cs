using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureTime
{
    public partial class newschedul : Form
    {
        public int idtur = 0;
        public newschedul(string idschedule = "0"
            , string idtour = "0"
            ,DateTime dateofdispatch = default(DateTime)
            ,DateTime returndate = default(DateTime))
        {
            InitializeComponent();
                idtur = Convert.ToInt32(idtour);
                labelid.Text = idschedule;
                if (dateofdispatch == default(DateTime)) { dateTimePicker2.Value = DateTime.Today; }
                else { dateTimePicker2.Value = dateofdispatch; }
                if (returndate == default(DateTime)) { dateTimePicker2.Value = DateTime.Today; }
                else { dateTimePicker2.Value = returndate; }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (labelid.Text == "0")
            {
                this.scheduleTableAdapter1.NewSchedule(Convert.ToInt32(Tourchoosebox.SelectedValue)
                , Tourdatabox.Value
                , dateTimePicker2.Value);
            }
            else
            {
                this.scheduleTableAdapter1.EditeSchedule(11, Convert.ToInt32(labelid.Text)
                            , Convert.ToInt32(Tourchoosebox.SelectedValue)
                            , Tourdatabox.Value
                            , dateTimePicker2.Value
                            );
            }
            this.Close();
        }

        private void newschedul_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advTimeDataSet.Tour". При необходимости она может быть перемещена или удалена.
            this.tourTableAdapter1.Fill(this.advTimeDataSet2.Tour);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advTimeDataSet.Schedulefull". При необходимости она может быть перемещена или удалена.
          // this.schedulefullTableAdapter.Fill(this.advTimeDataSet2.Schedulefull);
            Tourchoosebox.SelectedValue = idtur;

        }

        private void Tourchoosebox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
