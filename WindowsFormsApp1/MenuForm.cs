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
    public partial class MenuForm : Form
    {
        DeputatyTable deputatyTable;
        FrakciyaTable frakciyaTable;
        SozyvTable sozyvTable;
        ZasedaniyaTable zasedaniyaTable;
        ZakonoproektTable zakonoproektTable;

        public object deputatyData;
        public object frakciyaData;
        public object sozyvData;
        public object zasedaniyaData;
        public object zakonoproektData;

        public MenuForm()
        {
            InitializeComponent();

            deputatyTable = null;
            frakciyaTable = null;
            sozyvTable = null;
            zasedaniyaTable = null;
            zasedaniyaTable = null;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            GC.Collect();
            if (!isFormOpened("DeputatyTable"))
            {
                deputatyTable = new DeputatyTable(this);
                deputatyTable.Show();
            }
            else
            {
                deputatyTable.Focus();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            GC.Collect();
            if (!isFormOpened("SozyvTable"))
            {
                sozyvTable = new SozyvTable(this);
                sozyvTable.Show();
            }
            else
            {
                sozyvTable.Focus();
            }
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private bool isFormOpened(string name1)
        {
            bool opened = false;
            FormCollection openforms = Application.OpenForms;

            foreach (Form frms in openforms) { 
                string name2 = frms.Name;
                if (name2 == name1)
                {
                    opened = true;
                }
            }

            return opened;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            GC.Collect();
            if (!isFormOpened("FrakciyaTable"))
            {
                frakciyaTable = new FrakciyaTable(this);
                frakciyaTable.Show();
            }
            else
            {
                frakciyaTable.Focus();
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            GC.Collect();
            if (!isFormOpened("ZasedaniyaTable"))
            {
                zasedaniyaTable = new ZasedaniyaTable(this);
                zasedaniyaTable.Show();
            }
            else
            {
                zasedaniyaTable.Focus();
            }
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            GC.Collect();
            if (!isFormOpened("ZakonoproektTable"))
            {
                zakonoproektTable = new ZakonoproektTable(this);
                zakonoproektTable.Show();
            }
            else
            {
                zakonoproektTable.Focus();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ProcedureForm1 procF = new ProcedureForm1();
            procF.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ProcedureForm2 procF = new ProcedureForm2();
            procF.Show();
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            ProcedureForm3 procF = new ProcedureForm3();
            procF.Show();
        }
    }
}
