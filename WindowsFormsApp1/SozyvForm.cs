using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SozyvForm : Form
    {
        public SozyvForm()
        {
            InitializeComponent();
            button1.DialogResult = DialogResult.Cancel;
            button2.DialogResult = DialogResult.None;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.DialogResult == DialogResult.None)
            {
                MessageBox.Show("Некорректно введенные данные");
            }
        }

        private void SozyvForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime p1 = DateTime.Parse(maskedTextBox1.Text);
                DateTime p2 = DateTime.Parse(maskedTextBox2.Text);
                button2.DialogResult = DialogResult.OK;
            }
            catch
            {
                button2.DialogResult = DialogResult.None;
            }
        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime p1 = DateTime.Parse(maskedTextBox1.Text);
                DateTime p2 = DateTime.Parse(maskedTextBox2.Text);
                button2.DialogResult = DialogResult.OK;
            }
            catch
            {
                button2.DialogResult = DialogResult.None;
            }
        }
    }
}
