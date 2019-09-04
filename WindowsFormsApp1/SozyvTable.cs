using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SozyvTable : Form
    {
        MenuForm menu;

        public SozyvTable(MenuForm menu)
        {
            this.menu = menu;

            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            if (menu.sozyvData == null)
            {
                RefreshData();
            }
            else
            {
                dataGridView1.DataSource = menu.sozyvData;
            }
        }

        public void RefreshData()
        {
            using (The_State_Duma_Entities db = new The_State_Duma_Entities(DBUtils.getConnString()))
            {
                try
                {
                    menu.sozyvData = db.Sozyvies.Select(p => new { p.Nomer, p.Frakciya, p.Data_nachala, p.Data_konca }).ToList();
                }
                catch
                {
                    MessageBox.Show("У вас нет прав для просмотра таблицы");
                }
            }

            dataGridView1.DataSource = menu.sozyvData;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (The_State_Duma_Entities db = new The_State_Duma_Entities(DBUtils.getConnString()))
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int index = dataGridView1.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                    if (converted == false)
                        return;

                    Sozyvy sozyv = db.Sozyvies.Find(id);
                    listBox1.DataSource = sozyv.Deputaties.ToList();
                    listBox1.DisplayMember = "Familiya";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        // добавление
        private void button2_Click(object sender, EventArgs e)
        {
            using (The_State_Duma_Entities db = new The_State_Duma_Entities(DBUtils.getConnString()))
            { 
                SozyvForm addForm = new SozyvForm();

                List<Deputaty> deps = db.Deputaties.ToList();
                addForm.listBox1.DataSource = deps;
                addForm.listBox1.ValueMember = "Partiyniy_bilet";
                addForm.listBox1.DisplayMember = "Familiya";
                
                DialogResult result = addForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                Sozyvy sozyv = new Sozyvy();
                sozyv.Nomer = 0;
                sozyv.Data_nachala = DateTime.Parse(addForm.maskedTextBox1.Text);
                sozyv.Data_konca = DateTime.Parse(addForm.maskedTextBox2.Text);
                deps.Clear(); // очищаем список и заново заполняем его выделенными элементами
                foreach (var dep in addForm.listBox1.SelectedItems)
                {
                    deps.Add((Deputaty)dep);
                }
                sozyv.Deputaties = deps;

                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Sozyvies.Add(sozyv);

                        try
                        {
                            db.SaveChanges();
                        }
                        catch (DbUpdateException ex)
                        {
                            MessageBox.Show("Ошибка добавления : " + ex.ToString());
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка добавления : " + ex.ToString());

                        try { transaction.Rollback(); }
                        catch (Exception ex2)
                        {
                            MessageBox.Show("Ошибка отката : " + ex2.ToString());
                        }
                    }
                }
                RefreshData();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) {
                var confirmResult = MessageBox.Show("Вы уверены, что хотите удалить запись?",
                                        "Подтвердить удаление",
                                        MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)  {
                    using (The_State_Duma_Entities db = new The_State_Duma_Entities(DBUtils.getConnString())) {
                        int index = dataGridView1.SelectedRows[0].Index;
                        int id = 0;
                        bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                        if (converted == false)
                            return;

                        using (var transaction = db.Database.BeginTransaction()) {
                            try {
                                var soz = db.Sozyvies.Include(b => b.Deputaties)
                                                .FirstOrDefault(b => b.Nomer == id);
                                db.Sozyvies.Remove(soz);

                                try {
                                    db.SaveChanges();
                                }
                                catch (Exception ex) {
                                    MessageBox.Show("Ошибка удаления : " + ex.ToString());
                                }
                                transaction.Commit();
                            }
                            catch (Exception ex) {
                                MessageBox.Show("Ошибка удаления : " + ex.ToString());
                                try { transaction.Rollback(); }
                                catch (Exception ex2) {
                                    MessageBox.Show("Ошибка отката : " + ex2.ToString());
                                }
                            }
                        }
                    }
                    RefreshData();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (The_State_Duma_Entities db = new The_State_Duma_Entities(DBUtils.getConnString()))
            {
                if (dataGridView1.SelectedRows.Count < 1)
                    return;

                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Sozyvy sozyv = db.Sozyvies.Find(id);

                SozyvForm addForm = new SozyvForm();

                addForm.maskedTextBox1.Text = sozyv.Data_nachala.ToString();
                addForm.maskedTextBox2.Text = sozyv.Data_konca.ToString();

                // получаем список команд 
                List<Deputaty> deps = db.Deputaties.ToList();
                addForm.listBox1.DataSource = deps;
                addForm.listBox1.ValueMember = "Partiyniy_bilet";
                addForm.listBox1.DisplayMember = "Familiya";

                foreach (Deputaty d in sozyv.Deputaties)
                    addForm.listBox1.SelectedItem = d;

                DialogResult result = addForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                sozyv.Data_nachala = DateTime.Parse(addForm.maskedTextBox1.Text);
                sozyv.Data_konca = DateTime.Parse(addForm.maskedTextBox2.Text);
                deps.Clear(); // очищаем список и заново заполняем его выделенными элементами
                foreach (var dep in addForm.listBox1.SelectedItems)
                {
                    deps.Add((Deputaty)dep);
                }
                sozyv.Deputaties = deps;

                foreach (var d in deps)
                {
                    if (addForm.listBox1.SelectedItems.Contains(d))
                    {
                        if (!sozyv.Deputaties.Contains(d))
                            sozyv.Deputaties.Add(d);
                    }
                    else
                    {
                        if (sozyv.Deputaties.Contains(d))
                            sozyv.Deputaties.Remove(d);
                    }
                }

                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Entry(sozyv).State = EntityState.Modified;

                        try
                        {
                            db.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка обновления : " + ex.ToString());
                        }
                        
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка обновления : " + ex.ToString());
                        try { transaction.Rollback(); }
                        catch (Exception ex2)
                        {
                            MessageBox.Show("Ошибка отката : " + ex2.ToString());
                        }
                    }
                }

                RefreshData();
            }
        }
    }
}
