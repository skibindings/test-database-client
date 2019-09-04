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
    public partial class FrakciyaTable : Form
    {
        MenuForm menu;

        public FrakciyaTable(MenuForm menu)
        {
            this.menu = menu;
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            if (menu.frakciyaData == null)
            {
                RefreshData();
            }
            else
            {
                dataGridView1.DataSource = menu.frakciyaData;
            }
        }

        public void RefreshData()
        {
            using (The_State_Duma_Entities db = new The_State_Duma_Entities(DBUtils.getConnString()))
            {
                try
                {
                    menu.frakciyaData = db.Frakciyas.Select(p => new { p.ID, p.Naimenovanie, p.Kolichestvo_deputatov, p.Deputaty }).ToList();
                }
                catch
                {
                    MessageBox.Show("У вас нет прав для просмотра таблицы");
                }
            }
            dataGridView1.DataSource = menu.frakciyaData;
        }

        private void FrakciyaTable_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            RefreshData();
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

                    Frakciya frak = db.Frakciyas.Find(id);
                    listBox1.DataSource = frak.Deputaties.ToList();
                    listBox1.DisplayMember = "Familiya";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (The_State_Duma_Entities db = new The_State_Duma_Entities(DBUtils.getConnString()))
            {
                FrakciyaForm addForm = new FrakciyaForm();

                List<Deputaty> deps = db.Deputaties.ToList();
                for (int i = deps.Count - 1; i >= 0; i--)
                {
                    var dep = deps[i];

                    if(dep.Frakciya != null)
                        deps.RemoveAt(i);
                }

                DialogResult result = addForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                Frakciya frak = new Frakciya();

                frak.Naimenovanie = addForm.textBox1.Text;

                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Frakciyas.Add(frak);

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

                Frakciya frak = db.Frakciyas.Find(id);

                FrakciyaForm addForm = new FrakciyaForm();

                addForm.textBox1.Text = frak.Naimenovanie;

                List<Deputaty> deps = db.Deputaties.ToList();
                for (int i = deps.Count - 1; i >= 0; i--)
                {
                    if (deps[i].ID_frakcii != id)
                        deps.RemoveAt(i);
                }

                addForm.comboBox1.DataSource = deps;
                addForm.comboBox1.ValueMember = "Partiyniy_bilet";
                addForm.comboBox1.DisplayMember = "Familiya";

                addForm.comboBox1.SelectedItem = frak.Lider_frakcii;

                DialogResult result = addForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                frak.Naimenovanie = addForm.textBox1.Text;
                if (addForm.comboBox1.SelectedItem != null)
                    frak.Deputaty = (Deputaty)addForm.comboBox1.SelectedItem;
                else
                    frak.Deputaty = null;
                if (addForm.comboBox1.SelectedValue != null)
                    frak.Lider_frakcii = (int)addForm.comboBox1.SelectedValue;
                else
                    frak.Lider_frakcii = null;

                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Entry(frak).State = EntityState.Modified;

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
                                var frak = db.Frakciyas
                                             .FirstOrDefault(b => b.ID == id);

                                db.Frakciyas.Remove(frak);

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
    }
}
