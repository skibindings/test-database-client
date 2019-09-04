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
    public partial class ZasedaniyaForm : Form
    {

        public ZasedaniyaForm()
        {
            InitializeComponent();
            button1.DialogResult = DialogResult.Cancel;
            button2.DialogResult = DialogResult.None;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ZasedaniyaForm_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.DialogResult == DialogResult.None)
            {
                MessageBox.Show("Некорректно введенные данные");
            }
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime Data_provedeniya = DateTime.Parse(maskedTextBox1.Text);
                TimeSpan Vremya_nachala = TimeSpan.Parse(maskedTextBox2.Text);
                TimeSpan Vremya_konca = TimeSpan.Parse(maskedTextBox3.Text);
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
                DateTime Data_provedeniya = DateTime.Parse(maskedTextBox1.Text);
                TimeSpan Vremya_nachala = TimeSpan.Parse(maskedTextBox2.Text);
                TimeSpan Vremya_konca = TimeSpan.Parse(maskedTextBox3.Text);
                button2.DialogResult = DialogResult.OK;
            }
            catch
            {
                button2.DialogResult = DialogResult.None;
            }
        }

        private void maskedTextBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime Data_provedeniya = DateTime.Parse(maskedTextBox1.Text);
                TimeSpan Vremya_nachala = TimeSpan.Parse(maskedTextBox2.Text);
                TimeSpan Vremya_konca = TimeSpan.Parse(maskedTextBox3.Text);
                button2.DialogResult = DialogResult.OK;
            }
            catch
            {
                button2.DialogResult = DialogResult.None;
            }
        }
    }
}
