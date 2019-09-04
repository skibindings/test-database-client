using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBUtils.setLoginPassword(textBox1.Text, textBox2.Text); //
            using (The_State_Duma_Entities db = new The_State_Duma_Entities(DBUtils.getConnString()))
            {

                DbConnection conn = db.Database.Connection;
                try
                {
                    conn.Open(); // проверка соединения
                    Console.WriteLine("Connection success");

                    this.Hide();
                    var form1 = new MenuForm();
                    form1.Closed += (s, args) => this.Close();
                    form1.Show();
                }
                catch // ошибка соединения
                {
                    Console.WriteLine("Сonnection failed");
                    MessageBox.Show("Неправильная пара логин-пароль");
                    textBox2.Text = "";
                }
            }
        }
    }
}
