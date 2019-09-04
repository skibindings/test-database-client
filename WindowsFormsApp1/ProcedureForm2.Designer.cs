namespace WindowsFormsApp1
{
    partial class ProcedureForm2
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.factionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factionsPercentageResultBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.factionsPercentageResultBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.factionsPercentageResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factionsPercentageResultBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factionsPercentageResultBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factionsPercentageResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 425);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Соотношений фракций созыва";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Созыв";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(417, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.factionDataGridViewTextBoxColumn,
            this.percentageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.factionsPercentageResultBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(37, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(336, 356);
            this.dataGridView1.TabIndex = 4;
            // 
            // factionDataGridViewTextBoxColumn
            // 
            this.factionDataGridViewTextBoxColumn.DataPropertyName = "Faction";
            this.factionDataGridViewTextBoxColumn.HeaderText = "Фракция";
            this.factionDataGridViewTextBoxColumn.Name = "factionDataGridViewTextBoxColumn";
            // 
            // percentageDataGridViewTextBoxColumn
            // 
            this.percentageDataGridViewTextBoxColumn.DataPropertyName = "Percentage";
            this.percentageDataGridViewTextBoxColumn.HeaderText = "Процент";
            this.percentageDataGridViewTextBoxColumn.Name = "percentageDataGridViewTextBoxColumn";
            // 
            // factionsPercentageResultBindingSource2
            // 
            this.factionsPercentageResultBindingSource2.DataSource = typeof(WindowsFormsApp1.FactionsPercentage_Result);
            // 
            // factionsPercentageResultBindingSource1
            // 
            this.factionsPercentageResultBindingSource1.DataSource = typeof(WindowsFormsApp1.FactionsPercentage_Result);
            // 
            // factionsPercentageResultBindingSource
            // 
            this.factionsPercentageResultBindingSource.DataSource = typeof(WindowsFormsApp1.FactionsPercentage_Result);
            // 
            // ProcedureForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 447);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProcedureForm2";
            this.Text = "Соотношение фракций созыва";
            this.Load += new System.EventHandler(this.ProcedureForm2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factionsPercentageResultBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factionsPercentageResultBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factionsPercentageResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource factionsPercentageResultBindingSource;
        private System.Windows.Forms.BindingSource factionsPercentageResultBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn factionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource factionsPercentageResultBindingSource2;
    }
}