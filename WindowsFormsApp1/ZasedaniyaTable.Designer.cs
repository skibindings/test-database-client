namespace WindowsFormsApp1
{
    partial class ZasedaniyaTable
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naimenovanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomersozyvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataprovedeniyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vremyanachalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vremyakoncaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statuszasedaniyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mesto_provedeniya1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zasedanieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zasedanieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 432);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заседания";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomerDataGridViewTextBoxColumn,
            this.naimenovanieDataGridViewTextBoxColumn,
            this.tipDataGridViewTextBoxColumn,
            this.nomersozyvaDataGridViewTextBoxColumn,
            this.dataprovedeniyaDataGridViewTextBoxColumn,
            this.vremyanachalaDataGridViewTextBoxColumn,
            this.vremyakoncaDataGridViewTextBoxColumn,
            this.statuszasedaniyaDataGridViewTextBoxColumn,
            this.Mesto_provedeniya1});
            this.dataGridView1.DataSource = this.zasedanieBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(159, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(525, 290);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(517, 370);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 35);
            this.button4.TabIndex = 6;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(347, 370);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 35);
            this.button3.TabIndex = 5;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Mesto_provedeniya1";
            this.dataGridViewTextBoxColumn1.HeaderText = "Место проведения";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // nomerDataGridViewTextBoxColumn
            // 
            this.nomerDataGridViewTextBoxColumn.DataPropertyName = "Nomer";
            this.nomerDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.nomerDataGridViewTextBoxColumn.Name = "nomerDataGridViewTextBoxColumn";
            // 
            // naimenovanieDataGridViewTextBoxColumn
            // 
            this.naimenovanieDataGridViewTextBoxColumn.DataPropertyName = "Naimenovanie";
            this.naimenovanieDataGridViewTextBoxColumn.HeaderText = "Название";
            this.naimenovanieDataGridViewTextBoxColumn.Name = "naimenovanieDataGridViewTextBoxColumn";
            // 
            // tipDataGridViewTextBoxColumn
            // 
            this.tipDataGridViewTextBoxColumn.DataPropertyName = "Tip";
            this.tipDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.tipDataGridViewTextBoxColumn.Name = "tipDataGridViewTextBoxColumn";
            // 
            // nomersozyvaDataGridViewTextBoxColumn
            // 
            this.nomersozyvaDataGridViewTextBoxColumn.DataPropertyName = "Nomer_sozyva";
            this.nomersozyvaDataGridViewTextBoxColumn.HeaderText = "Номер созыва";
            this.nomersozyvaDataGridViewTextBoxColumn.Name = "nomersozyvaDataGridViewTextBoxColumn";
            // 
            // dataprovedeniyaDataGridViewTextBoxColumn
            // 
            this.dataprovedeniyaDataGridViewTextBoxColumn.DataPropertyName = "Data_provedeniya";
            this.dataprovedeniyaDataGridViewTextBoxColumn.HeaderText = "Дата проведения";
            this.dataprovedeniyaDataGridViewTextBoxColumn.Name = "dataprovedeniyaDataGridViewTextBoxColumn";
            // 
            // vremyanachalaDataGridViewTextBoxColumn
            // 
            this.vremyanachalaDataGridViewTextBoxColumn.DataPropertyName = "Vremya_nachala";
            this.vremyanachalaDataGridViewTextBoxColumn.HeaderText = "Время начала";
            this.vremyanachalaDataGridViewTextBoxColumn.Name = "vremyanachalaDataGridViewTextBoxColumn";
            // 
            // vremyakoncaDataGridViewTextBoxColumn
            // 
            this.vremyakoncaDataGridViewTextBoxColumn.DataPropertyName = "Vremya_konca";
            this.vremyakoncaDataGridViewTextBoxColumn.HeaderText = "Время конца";
            this.vremyakoncaDataGridViewTextBoxColumn.Name = "vremyakoncaDataGridViewTextBoxColumn";
            // 
            // statuszasedaniyaDataGridViewTextBoxColumn
            // 
            this.statuszasedaniyaDataGridViewTextBoxColumn.DataPropertyName = "Status_zasedaniya";
            this.statuszasedaniyaDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.statuszasedaniyaDataGridViewTextBoxColumn.Name = "statuszasedaniyaDataGridViewTextBoxColumn";
            // 
            // Mesto_provedeniya1
            // 
            this.Mesto_provedeniya1.DataPropertyName = "Mesto_provedeniya1";
            this.Mesto_provedeniya1.HeaderText = "Место проведения";
            this.Mesto_provedeniya1.Name = "Mesto_provedeniya1";
            // 
            // zasedanieBindingSource
            // 
            this.zasedanieBindingSource.DataSource = typeof(WindowsFormsApp1.Zasedanie);
            // 
            // ZasedaniyaTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 457);
            this.Controls.Add(this.groupBox1);
            this.Name = "ZasedaniyaTable";
            this.Text = "Заседания";
            this.Load += new System.EventHandler(this.ZasedaniyaTable_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zasedanieBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource zasedanieBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomersozyvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataprovedeniyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vremyanachalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vremyakoncaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statuszasedaniyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mesto_provedeniya1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}