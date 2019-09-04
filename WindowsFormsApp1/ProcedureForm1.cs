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
    public partial class ProcedureForm1 : Form
    {
        public ProcedureForm1()
        {
            InitializeComponent();
            using (The_State_Duma_Entities db = new The_State_Duma_Entities(DBUtils.getConnString()))
            {
                List<Sozyvy> sozes = db.Sozyvies.ToList();
                comboBox1.DataSource = sozes;
                comboBox1.ValueMember = "Nomer";
                comboBox1.DisplayMember = "Nomer";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (The_State_Duma_Entities db = new The_State_Duma_Entities(DBUtils.getConnString()))
            {
                try
                {
                    dataGridView1.DataSource = db.Vozrastnoi_sostav_new((int)comboBox1.SelectedValue);
                }
                catch
                {
                    MessageBox.Show("У вас нет прав для использования процедуры");
                }
            }
        }

        private void ProcedureForm1_Load(object sender, EventArgs e)
        {

        }
    }
}
