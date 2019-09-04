namespace WindowsFormsApp1
{
    partial class MenuForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(369, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Процедуры";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 238);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 66);
            this.button5.TabIndex = 12;
            this.button5.Text = "Результативность созывов";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_2);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 66);
            this.button3.TabIndex = 11;
            this.button3.Text = "Соотношение фракций созыва";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 66);
            this.button1.TabIndex = 10;
            this.button1.Text = "Возрастной состав созыва\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button16);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 326);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Таблицы";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(181, 142);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(144, 66);
            this.button16.TabIndex = 9;
            this.button16.Text = "Законопроекты";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click_1);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(15, 142);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(144, 66);
            this.button9.TabIndex = 6;
            this.button9.Text = "Заседания";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 238);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 66);
            this.button4.TabIndex = 5;
            this.button4.Text = "Созывы";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(15, 46);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 66);
            this.button6.TabIndex = 3;
            this.button6.Text = "Фракции";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "Депутаты";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 355);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuForm";
            this.Text = "Государственная Дума";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}