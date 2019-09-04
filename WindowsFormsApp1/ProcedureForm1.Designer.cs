namespace WindowsFormsApp1
{
    partial class ProcedureForm1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.frakciiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2025DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2545DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3550DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5065DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c65100DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vozrastnoisostavnewResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozrastnoisostavnewResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Возрастной состав созыва";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.frakciiDataGridViewTextBoxColumn,
            this.c2025DataGridViewTextBoxColumn,
            this.c2545DataGridViewTextBoxColumn,
            this.c3550DataGridViewTextBoxColumn,
            this.c5065DataGridViewTextBoxColumn,
            this.c65100DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vozrastnoisostavnewResultBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(643, 339);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(708, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(708, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(705, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Созыв";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frakciiDataGridViewTextBoxColumn
            // 
            this.frakciiDataGridViewTextBoxColumn.DataPropertyName = "Frakcii";
            this.frakciiDataGridViewTextBoxColumn.HeaderText = "Фракции";
            this.frakciiDataGridViewTextBoxColumn.Name = "frakciiDataGridViewTextBoxColumn";
            // 
            // c2025DataGridViewTextBoxColumn
            // 
            this.c2025DataGridViewTextBoxColumn.DataPropertyName = "C20_25";
            this.c2025DataGridViewTextBoxColumn.HeaderText = "20-25";
            this.c2025DataGridViewTextBoxColumn.Name = "c2025DataGridViewTextBoxColumn";
            // 
            // c2545DataGridViewTextBoxColumn
            // 
            this.c2545DataGridViewTextBoxColumn.DataPropertyName = "C25_45";
            this.c2545DataGridViewTextBoxColumn.HeaderText = "25-45";
            this.c2545DataGridViewTextBoxColumn.Name = "c2545DataGridViewTextBoxColumn";
            // 
            // c3550DataGridViewTextBoxColumn
            // 
            this.c3550DataGridViewTextBoxColumn.DataPropertyName = "C35_50";
            this.c3550DataGridViewTextBoxColumn.HeaderText = "35-50";
            this.c3550DataGridViewTextBoxColumn.Name = "c3550DataGridViewTextBoxColumn";
            // 
            // c5065DataGridViewTextBoxColumn
            // 
            this.c5065DataGridViewTextBoxColumn.DataPropertyName = "C50_65";
            this.c5065DataGridViewTextBoxColumn.HeaderText = "50-65";
            this.c5065DataGridViewTextBoxColumn.Name = "c5065DataGridViewTextBoxColumn";
            // 
            // c65100DataGridViewTextBoxColumn
            // 
            this.c65100DataGridViewTextBoxColumn.DataPropertyName = "C65_100";
            this.c65100DataGridViewTextBoxColumn.HeaderText = "65-100";
            this.c65100DataGridViewTextBoxColumn.Name = "c65100DataGridViewTextBoxColumn";
            // 
            // vozrastnoisostavnewResultBindingSource
            // 
            this.vozrastnoisostavnewResultBindingSource.DataSource = typeof(WindowsFormsApp1.Vozrastnoi_sostav_new_Result);
            // 
            // ProcedureForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProcedureForm1";
            this.Text = "Возрастной состав созыва";
            this.Load += new System.EventHandler(this.ProcedureForm1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozrastnoisostavnewResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource vozrastnoisostavnewResultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn frakciiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2025DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2545DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3550DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn c5065DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn c65100DataGridViewTextBoxColumn;
    }
}