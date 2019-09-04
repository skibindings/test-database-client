namespace WindowsFormsApp1
{
    partial class ProcedureForm3
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
            this.label1 = new System.Windows.Forms.Label();
            this.getSozyvyStatusResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomersozyvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvozasedaniyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvorassmotreniyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvogrupprabotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSozyvyStatusResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 478);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Результативность созывов";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomersozyvaDataGridViewTextBoxColumn,
            this.kolvozasedaniyDataGridViewTextBoxColumn,
            this.kolvorassmotreniyDataGridViewTextBoxColumn,
            this.kolvogrupprabotDataGridViewTextBoxColumn,
            this.resultsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getSozyvyStatusResultBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(643, 339);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Самый результативный созыв : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // getSozyvyStatusResultBindingSource
            // 
            this.getSozyvyStatusResultBindingSource.DataSource = typeof(WindowsFormsApp1.GetSozyvyStatus_Result);
            // 
            // nomersozyvaDataGridViewTextBoxColumn
            // 
            this.nomersozyvaDataGridViewTextBoxColumn.DataPropertyName = "Nomer_sozyva_";
            this.nomersozyvaDataGridViewTextBoxColumn.HeaderText = "Созыв";
            this.nomersozyvaDataGridViewTextBoxColumn.Name = "nomersozyvaDataGridViewTextBoxColumn";
            // 
            // kolvozasedaniyDataGridViewTextBoxColumn
            // 
            this.kolvozasedaniyDataGridViewTextBoxColumn.DataPropertyName = "Kolvo_zasedaniy_";
            this.kolvozasedaniyDataGridViewTextBoxColumn.HeaderText = "Кол-во заседаний";
            this.kolvozasedaniyDataGridViewTextBoxColumn.Name = "kolvozasedaniyDataGridViewTextBoxColumn";
            // 
            // kolvorassmotreniyDataGridViewTextBoxColumn
            // 
            this.kolvorassmotreniyDataGridViewTextBoxColumn.DataPropertyName = "Kolvo_rassmotreniy_";
            this.kolvorassmotreniyDataGridViewTextBoxColumn.HeaderText = "Кол-во рассмотрений";
            this.kolvorassmotreniyDataGridViewTextBoxColumn.Name = "kolvorassmotreniyDataGridViewTextBoxColumn";
            // 
            // kolvogrupprabotDataGridViewTextBoxColumn
            // 
            this.kolvogrupprabotDataGridViewTextBoxColumn.DataPropertyName = "Kolvo_grupp_rabot_";
            this.kolvogrupprabotDataGridViewTextBoxColumn.HeaderText = "Кол-во групповых работ";
            this.kolvogrupprabotDataGridViewTextBoxColumn.Name = "kolvogrupprabotDataGridViewTextBoxColumn";
            // 
            // resultsDataGridViewTextBoxColumn
            // 
            this.resultsDataGridViewTextBoxColumn.DataPropertyName = "Results";
            this.resultsDataGridViewTextBoxColumn.HeaderText = "Результативность";
            this.resultsDataGridViewTextBoxColumn.Name = "resultsDataGridViewTextBoxColumn";
            // 
            // ProcedureForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 502);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProcedureForm3";
            this.Text = "Результативность созывов";
            this.Load += new System.EventHandler(this.ProcedureForm3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSozyvyStatusResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomersozyvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvozasedaniyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvorassmotreniyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvogrupprabotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getSozyvyStatusResultBindingSource;
    }
}