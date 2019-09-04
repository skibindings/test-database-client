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
    public partial class ZasedaniyaTable : Form
    {
        MenuForm menu;

        public ZasedaniyaTable(MenuForm menu)
        {
            this.menu = menu;
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            if (menu.zasedaniyaData == null)
            {
                RefreshData();
            }
            else
            {
                dataGridView1.DataSource = menu.zasedaniyaData;
            }
        }

        public void RefreshData()
        {
            using (The_State_Duma_Entities db = new The_State_Duma_Entities(DBUtils.getConnString()))
            {
                try
                {
                    db.UpdateSessionStatus();
                }
                catch
                {
                    MessageBox.Show("У вас нет прав для обновления статуса заседаний");
                }

                try
                {
                    menu.zasedaniyaData = db.Zasedanies.Select(p => new { p.Nomer, p.Naimenovanie, p.Tip, p.Nomer_sozyva, p.Data_provedeniya, p.Vremya_nachala, p.Vremya_konca, p.Status_zasedaniya, p.Mesto_provedeniya1 }).ToList();
                }
                catch
                {
                    MessageBox.Show("У вас нет прав для просмотра таблицы");
                }
            }
            dataGridView1.DataSource = menu.zasedaniyaData;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
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
                ZasedaniyaForm addForm = new ZasedaniyaForm();

                List<Sozyvy> sozes = db.Sozyvies.ToList();
                addForm.comboBox1.DataSource = sozes;
                addForm.comboBox1.ValueMember = "Nomer";
                addForm.comboBox1.DisplayMember = "Nomer";

                List<Mesto_provedeniya> mesta = db.Mesto_provedeniya.ToList();
                addForm.comboBox2.DataSource = mesta;
                addForm.comboBox2.ValueMember = "ID";
                addForm.comboBox2.DisplayMember = "Ulica";

                addForm.radioButton1.Checked = true;
                addForm.radioButton2.Checked = false;

                DialogResult result = addForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                Zasedanie zased = new Zasedanie();
                zased.Nomer = 0;
                zased.Naimenovanie = addForm.textBox1.Text;

                zased.Data_provedeniya = DateTime.Parse(addForm.maskedTextBox1.Text);
                zased.Vremya_nachala = TimeSpan.Parse(addForm.maskedTextBox2.Text);
                zased.Vremya_konca = TimeSpan.Parse(addForm.maskedTextBox3.Text);

                if (addForm.radioButton1.Checked)
                    zased.Tip = addForm.radioButton1.Text;
                else
                    zased.Tip = addForm.radioButton2.Text;

                zased.Nomer_sozyva = (int)addForm.comboBox1.SelectedValue;
                zased.Sozyvy = (Sozyvy)addForm.comboBox1.SelectedItem;

                zased.Mesto_provedeniya = (int)addForm.comboBox2.SelectedValue;
                zased.Mesto_provedeniya1 = (Mesto_provedeniya)addForm.comboBox2.SelectedItem;

                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Zasedanies.Add(zased);

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
                                var frak = db.Zasedanies
                                             .FirstOrDefault(b => b.Nomer == id);

                                db.Zasedanies.Remove(frak);

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

                Zasedanie zased = db.Zasedanies.Find(id);

                ZasedaniyaForm addForm = new ZasedaniyaForm();

                addForm.textBox1.Text = zased.Naimenovanie;
                addForm.maskedTextBox1.Text = zased.Data_provedeniya.ToString();
                addForm.maskedTextBox2.Text = zased.Vremya_nachala.ToString();
                addForm.maskedTextBox3.Text = zased.Vremya_konca.ToString();

                List<Sozyvy> sozes = db.Sozyvies.ToList();
                addForm.comboBox1.DataSource = sozes;
                addForm.comboBox1.ValueMember = "Nomer";
                addForm.comboBox1.DisplayMember = "Nomer";

                List<Mesto_provedeniya> mesta = db.Mesto_provedeniya.ToList();
                addForm.comboBox2.DataSource = mesta;
                addForm.comboBox2.ValueMember = "ID";
                addForm.comboBox2.DisplayMember = "Ulica";

                addForm.comboBox1.SelectedItem = zased.Sozyvy;
                addForm.comboBox2.SelectedItem = zased.Mesto_provedeniya1;

                if (zased.Tip == "Plenarnoe Zasedanie" || zased.Tip == "Пленарное заседание")
                    addForm.radioButton1.Checked = true;
                else if(zased.Tip == "Заседание совета ГД")
                    addForm.radioButton2.Checked = true;

                DialogResult result = addForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                zased.Naimenovanie = addForm.textBox1.Text;
                zased.Data_provedeniya = DateTime.Parse(addForm.maskedTextBox1.Text);
                zased.Vremya_nachala = TimeSpan.Parse(addForm.maskedTextBox2.Text);
                zased.Vremya_konca = TimeSpan.Parse(addForm.maskedTextBox3.Text);
                if (addForm.radioButton1.Checked)
                    zased.Tip = addForm.radioButton1.Text;
                else
                    zased.Tip = addForm.radioButton2.Text;

                zased.Nomer_sozyva = (int)addForm.comboBox1.SelectedValue;
                zased.Sozyvy = (Sozyvy)addForm.comboBox1.SelectedItem;

                zased.Mesto_provedeniya = (int)addForm.comboBox2.SelectedValue;
                zased.Mesto_provedeniya1 = (Mesto_provedeniya)addForm.comboBox2.SelectedItem;

                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Entry(zased).State = EntityState.Modified;

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

        private void ZasedaniyaTable_Load(object sender, EventArgs e)
        {

        }
    }
}
