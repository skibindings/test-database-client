using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ZakonoproektTable : Form
    {
        MenuForm menu;

        public ZakonoproektTable(MenuForm menu)
        {
            this.menu = menu;
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            if (menu.zakonoproektData == null)
            {
                RefreshData();
            }
            else
            {
                dataGridView1.DataSource = menu.zakonoproektData;
            }
        }

        public void RefreshData()
        {
            using (The_State_Duma_Entities db = new The_State_Duma_Entities(DBUtils.getConnString()))
            {
                try
                {
                    menu.zakonoproektData = db.Zakonoproekts.Select(p => new { p.ID, p.Naimenovanie, p.Opisanie, p.Deputaty }).ToList();
                }
                catch
                {
                    MessageBox.Show("У вас нет прав для просмотра таблицы");
                }
            }
            dataGridView1.DataSource = menu.zakonoproektData;
        }

        private void ZakonoproektTable_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (The_State_Duma_Entities db = new The_State_Duma_Entities(DBUtils.getConnString()))
            {
                ZakonoproektForm addForm = new ZakonoproektForm();

                List<Deputaty> deps = db.Deputaties.ToList();
                addForm.comboBox1.DataSource = deps;
                addForm.comboBox1.ValueMember = "Partiyniy_bilet";
                addForm.comboBox1.DisplayMember = "Familiya";

                DialogResult result = addForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                Zakonoproekt zak = new Zakonoproekt();

                zak.Naimenovanie = addForm.textBox1.Text;
                zak.Opisanie = addForm.richTextBox1.Text;
                zak.Deputaty = (Deputaty)addForm.comboBox1.SelectedItem;
                zak.Vnesen = (int)addForm.comboBox1.SelectedValue;
            
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Zakonoproekts.Add(zak);

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
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var confirmResult = MessageBox.Show("Вы уверены, что хотите удалить запись?",
                                     "Подтвердить удаление",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    using (The_State_Duma_Entities db = new The_State_Duma_Entities(DBUtils.getConnString()))
                    {
                        int index = dataGridView1.SelectedRows[0].Index;
                        int id = 0;
                        bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                        if (converted == false)
                            return;

                        using (var transaction = db.Database.BeginTransaction())
                        {
                            try
                            {
                                var zak = db.Zakonoproekts
                                             .FirstOrDefault(b => b.ID == id);

                                db.Zakonoproekts.Remove(zak);

                                try
                                {
                                    db.SaveChanges();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Ошибка удаления : " + ex.ToString());
                                }

                                transaction.Commit();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ошибка удаления : " + ex.ToString());
                                try { transaction.Rollback(); }
                                catch (Exception ex2)
                                {
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

                Zakonoproekt zak = db.Zakonoproekts.Find(id);
                ZakonoproektForm addForm = new ZakonoproektForm();

                addForm.textBox1.Text = zak.Naimenovanie;
                addForm.richTextBox1.Text = zak.Opisanie;

                List<Deputaty> deps = db.Deputaties.ToList();

                addForm.comboBox1.DataSource = deps;
                addForm.comboBox1.ValueMember = "Partiyniy_bilet";
                addForm.comboBox1.DisplayMember = "Familiya";

                addForm.comboBox1.SelectedItem = zak.Deputaty;

                DialogResult result = addForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                zak.Naimenovanie = addForm.textBox1.Text;
                zak.Opisanie = addForm.richTextBox1.Text;
                zak.Deputaty = (Deputaty)addForm.comboBox1.SelectedItem;
                zak.Vnesen = (int)addForm.comboBox1.SelectedValue;

                using (var transaction = db.Database.BeginTransaction()) {
                    try {
                        db.Entry(zak).State = EntityState.Modified;
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
                    catch (Exception ex) {
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
