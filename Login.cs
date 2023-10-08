using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureTime
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow CurUser = selectUserCommandTableAdapter1.GetData(loginBox.Text, passwordBox.Text)[0];
                if (CurUser.IsNull(0))
                {
                MessageBox.Show("Пользователь или пароль введны неверно", "О нет, ошибка!", MessageBoxButtons.OK);
                }
                else
                {
                    LoggedUser.loggeduser = CurUser[2].ToString();

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка запроса к базе данных", "О нет, ошибка!", MessageBoxButtons.OK);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)

        {
            System.Windows.Forms.Application.Exit();
        }

        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void loginBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
