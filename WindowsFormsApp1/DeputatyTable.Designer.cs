namespace WindowsFormsApp1
{
    partial class DeputatyTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.partiyniybiletDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familiyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otchestovoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionvyborovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datarozhdeniyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frakciyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.komitetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deputatyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deputatyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 449);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Депутаты";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(25, 53);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 35);
            this.button5.TabIndex = 10;
            this.button5.Text = "Обновить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(771, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Помощники :";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(775, 238);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(198, 84);
            this.listBox2.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partiyniybiletDataGridViewTextBoxColumn,
            this.familiyaDataGridViewTextBoxColumn,
            this.imyaDataGridViewTextBoxColumn,
            this.otchestovoDataGridViewTextBoxColumn,
            this.regionvyborovDataGridViewTextBoxColumn,
            this.datarozhdeniyaDataGridViewTextBoxColumn,
            this.frakciyaDataGridViewTextBoxColumn,
            this.komitetDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.deputatyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(165, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(551, 287);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(551, 387);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 35);
            this.button4.TabIndex = 6;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(381, 387);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 35);
            this.button3.TabIndex = 5;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(208, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(771, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Участник созывов :";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(775, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(198, 84);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(791, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Информация";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // partiyniybiletDataGridViewTextBoxColumn
            // 
            this.partiyniybiletDataGridViewTextBoxColumn.DataPropertyName = "Partiyniy_bilet";
            this.partiyniybiletDataGridViewTextBoxColumn.HeaderText = "Партбилет";
            this.partiyniybiletDataGridViewTextBoxColumn.Name = "partiyniybiletDataGridViewTextBoxColumn";
            // 
            // familiyaDataGridViewTextBoxColumn
            // 
            this.familiyaDataGridViewTextBoxColumn.DataPropertyName = "Familiya";
            this.familiyaDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.familiyaDataGridViewTextBoxColumn.Name = "familiyaDataGridViewTextBoxColumn";
            // 
            // imyaDataGridViewTextBoxColumn
            // 
            this.imyaDataGridViewTextBoxColumn.DataPropertyName = "Imya";
            this.imyaDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.imyaDataGridViewTextBoxColumn.Name = "imyaDataGridViewTextBoxColumn";
            // 
            // otchestovoDataGridViewTextBoxColumn
            // 
            this.otchestovoDataGridViewTextBoxColumn.DataPropertyName = "Otchestovo";
            this.otchestovoDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.otchestovoDataGridViewTextBoxColumn.Name = "otchestovoDataGridViewTextBoxColumn";
            // 
            // regionvyborovDataGridViewTextBoxColumn
            // 
            this.regionvyborovDataGridViewTextBoxColumn.DataPropertyName = "Region_vyborov";
            this.regionvyborovDataGridViewTextBoxColumn.HeaderText = "Регион выборов";
            this.regionvyborovDataGridViewTextBoxColumn.Name = "regionvyborovDataGridViewTextBoxColumn";
            // 
            // datarozhdeniyaDataGridViewTextBoxColumn
            // 
            this.datarozhdeniyaDataGridViewTextBoxColumn.DataPropertyName = "Data_rozhdeniya";
            this.datarozhdeniyaDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.datarozhdeniyaDataGridViewTextBoxColumn.Name = "datarozhdeniyaDataGridViewTextBoxColumn";
            // 
            // frakciyaDataGridViewTextBoxColumn
            // 
            this.frakciyaDataGridViewTextBoxColumn.DataPropertyName = "Frakciya";
            this.frakciyaDataGridViewTextBoxColumn.HeaderText = "Фракция";
            this.frakciyaDataGridViewTextBoxColumn.Name = "frakciyaDataGridViewTextBoxColumn";
            // 
            // komitetDataGridViewTextBoxColumn
            // 
            this.komitetDataGridViewTextBoxColumn.DataPropertyName = "Komitet";
            this.komitetDataGridViewTextBoxColumn.HeaderText = "Комитет";
            this.komitetDataGridViewTextBoxColumn.Name = "komitetDataGridViewTextBoxColumn";
            // 
            // deputatyBindingSource
            // 
            this.deputatyBindingSource.DataSource = typeof(WindowsFormsApp1.Deputaty);
            // 
            // DeputatyTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 468);
            this.Controls.Add(this.groupBox1);
            this.Name = "DeputatyTable";
            this.Text = "Депутаты";
            this.Load += new System.EventHandler(this.DeputatyTable_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deputatyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource deputatyBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn partiyniybiletDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familiyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otchestovoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionvyborovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datarozhdeniyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frakciyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn komitetDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button5;
    }
}