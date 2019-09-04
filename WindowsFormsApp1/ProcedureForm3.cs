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
    public partial class ProcedureForm3 : Form
    {
        public ProcedureForm3()
        {
            InitializeComponent();
            using (The_State_Duma_Entities db = new The_State_Duma_Entities(DBUtils.getConnString()))
            {
                try
                {
                    var proc = db.GetSozyvyStatus();
                    dataGridView1.DataSource = proc;

                    int best_soz = -1;
                    decimal best_results = 0;

                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        if ((decimal)dataGridView1[4, i].Value > best_results)
                        {
                            best_results = (decimal)dataGridView1[4, i].Value;
                            best_soz = (int)dataGridView1[0, i].Value;
                        }

                    }
                    label1.Text = "Самый результативный созыв : " + best_soz;
                }
                catch
                {
                    MessageBox.Show("У вас нет прав для использования процедуры");
                }
            }
        }

        private void ProcedureForm3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
