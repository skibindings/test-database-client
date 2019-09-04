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
    public partial class DeputatyTable : Form
    {
        MenuForm menu;

        public DeputatyTable(MenuForm menu)
        {
            this.menu = menu;
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            if (menu.deputatyData == null)
            {
                RefreshData();
            }
            else
            {
                dataGridView1.DataSource = menu.deputatyData;
            }
        }

        public void RefreshData()
        {
            using (The_State_Duma_Entities db = new The_State_Duma_Entities(DBUtils.getConnString()))
            {
                try
                {
                    menu.deputatyData = db.Deputaties.Select(p => new { p.Partiyniy_bilet, p.Familiya, p.Imya, p.Otchestovo, p.Region_vyborov, p.Data_rozhdeniya, p.Frakciya, p.Komitet }).ToList();
                }
                catch
                {
                    MessageBox.Show("У вас нет прав для просмотра таблицы");
                }
            }
            dataGridView1.DataSource = menu.deputatyData;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
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

                    Deputaty dep = db.Deputaties.Find(id);
                    listBox1.DataSource = dep.Sozyvies.ToList();
                    listBox1.DisplayMember = "Nomer";

                    listBox2.DataSource = dep.Pomoshnik_deputata_.ToList();
                    listBox2.DisplayMember = "Familiya";
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (The_State_Duma_Entities db = new The_State_Duma_Entities(DBUtils.getConnString()))
            {
                DeputatyForm addForm = new DeputatyForm();

                List<Sozyvy> sozes = db.Sozyvies.ToList();
                addForm.listBox1.DataSource = sozes;
                addForm.listBox1.ValueMember = "Nomer";
                addForm.listBox1.DisplayMember = "Nomer";

                List<Frakciya> frakces = db.Frakciyas.ToList();
                addForm.comboBox1.DataSource = frakces;
                addForm.comboBox1.ValueMember = "ID";
                addForm.comboBox1.DisplayMember = "Naimenovanie";

                List<Komitet> kometes = db.Komitets.ToList();
                addForm.comboBox2.DataSource = kometes;
                addForm.comboBox2.ValueMember = "ID";
                addForm.comboBox2.DisplayMember = "Naimenovanie";

                DialogResult result = addForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                Deputaty dep = new Deputaty();
                dep.Partiyniy_bilet = (int)addForm.numericUpDown1.Value;
                dep.Familiya = addForm.textBox2.Text;
                dep.Imya = addForm.textBox1.Text;
                dep.Otchestovo = addForm.textBox3.Text;
                dep.Region_vyborov = addForm.textBox4.Text;

                dep.Data_rozhdeniya = DateTime.Parse(addForm.maskedTextBox1.Text);

                sozes.Clear(); // очищаем список и заново заполняем его выделенными элементами
                foreach (var soz in addForm.listBox1.SelectedItems)
                {
                    sozes.Add((Sozyvy)soz);
                }
                dep.Sozyvies = sozes;

                dep.Frakciya = (Frakciya)addForm.comboBox1.SelectedItem;
                dep.ID_frakcii = (int)addForm.comboBox1.SelectedValue;

                dep.Komitet = (Komitet)addForm.comboBox2.SelectedItem;
                dep.ID_komiteta = (int)addForm.comboBox2.SelectedValue;

                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Deputaties.Add(dep);

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
                                var dep = db.Deputaties.Include(b => b.Sozyvies)
                                             .FirstOrDefault(b => b.Partiyniy_bilet == id);

                                db.Deputaties.Remove(dep);

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

                Deputaty dep = db.Deputaties.Find(id);

                DeputatyForm addForm = new DeputatyForm();

                addForm.numericUpDown1.Value = dep.Partiyniy_bilet;
                addForm.textBox2.Text = dep.Familiya;
                addForm.textBox1.Text = dep.Imya;
                addForm.textBox3.Text = dep.Otchestovo;
                addForm.textBox4.Text = dep.Region_vyborov;
                addForm.maskedTextBox1.Text = dep.Data_rozhdeniya.ToString();

                // получаем список команд 
                List<Sozyvy> sozes = db.Sozyvies.ToList();
                addForm.listBox1.DataSource = sozes;
                addForm.listBox1.ValueMember = "Nomer";
                addForm.listBox1.DisplayMember = "Nomer";

                List<Frakciya> frakces = db.Frakciyas.ToList();
                addForm.comboBox1.DataSource = frakces;
                addForm.comboBox1.ValueMember = "ID";
                addForm.comboBox1.DisplayMember = "Naimenovanie";

                List<Komitet> kometes = db.Komitets.ToList();
                addForm.comboBox2.DataSource = kometes;
                addForm.comboBox2.ValueMember = "ID";
                addForm.comboBox2.DisplayMember = "Naimenovanie";

                foreach (Sozyvy s in dep.Sozyvies)
                    addForm.listBox1.SelectedItem = s;

                addForm.comboBox1.SelectedItem = dep.Frakciya;
                addForm.comboBox2.SelectedItem = dep.Komitet;

                DialogResult result = addForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                dep.Partiyniy_bilet = (int)addForm.numericUpDown1.Value;
                dep.Familiya = addForm.textBox2.Text;
                dep.Imya = addForm.textBox1.Text;
                dep.Otchestovo = addForm.textBox3.Text;
                dep.Region_vyborov = addForm.textBox4.Text;

                dep.Data_rozhdeniya = DateTime.Parse(addForm.maskedTextBox1.Text);

                sozes.Clear(); // очищаем список и заново заполняем его выделенными элементами
                foreach (var soz in addForm.listBox1.SelectedItems)
                {
                    sozes.Add((Sozyvy)soz);
                }
                dep.Sozyvies = sozes;

                foreach (var s in sozes)
                {
                    if (addForm.listBox1.SelectedItems.Contains(s))
                    {
                        if (!dep.Sozyvies.Contains(s))
                            dep.Sozyvies.Add(s);
                    }
                    else
                    {
                        if (dep.Sozyvies.Contains(s))
                            dep.Sozyvies.Remove(s);
                    }
                }

                dep.Frakciya = (Frakciya)addForm.comboBox1.SelectedItem;
                dep.ID_frakcii = (int)addForm.comboBox1.SelectedValue;

                dep.Komitet = (Komitet)addForm.comboBox2.SelectedItem;
                dep.ID_komiteta = (int)addForm.comboBox2.SelectedValue;

                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Entry(dep).State = EntityState.Modified;

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

        private void DeputatyTable_Load(object sender, EventArgs e)
        {

        }
    }
}
