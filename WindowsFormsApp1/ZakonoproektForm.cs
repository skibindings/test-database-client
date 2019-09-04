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
    public partial class ZakonoproektForm : Form
    {
        public ZakonoproektForm()
        {
            InitializeComponent();
            button1.DialogResult = DialogResult.Cancel;
            button2.DialogResult = DialogResult.OK;
        }

        private void ZakonoproektForm_Load(object sender, EventArgs e)
        {

        }
    }
}
