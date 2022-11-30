namespace WindowsFormsApp_DataGridView
{
    partial class Form1
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
            this.dataGridView_Gyumolcsok = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Azonosito = new System.Windows.Forms.TextBox();
            this.textBox_GyumolcsNev = new System.Windows.Forms.TextBox();
            this.numericUpDown_EgysegAr = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Mennyiseg = new System.Windows.Forms.NumericUpDown();
            this.button_Insert = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Gyumolcsok)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_EgysegAr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Mennyiseg)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Gyumolcsok
            // 
            this.dataGridView_Gyumolcsok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Gyumolcsok.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_Gyumolcsok.Location = new System.Drawing.Point(0, 152);
            this.dataGridView_Gyumolcsok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_Gyumolcsok.Name = "dataGridView_Gyumolcsok";
            this.dataGridView_Gyumolcsok.Size = new System.Drawing.Size(1175, 365);
            this.dataGridView_Gyumolcsok.TabIndex = 0;
            this.dataGridView_Gyumolcsok.SelectionChanged += new System.EventHandler(this.dataGridView_Gyumolcsok_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Delete);
            this.groupBox1.Controls.Add(this.button_Update);
            this.groupBox1.Controls.Add(this.button_Insert);
            this.groupBox1.Controls.Add(this.numericUpDown_Mennyiseg);
            this.groupBox1.Controls.Add(this.numericUpDown_EgysegAr);
            this.groupBox1.Controls.Add(this.textBox_GyumolcsNev);
            this.groupBox1.Controls.Add(this.textBox_Azonosito);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1175, 152);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiválasztott gyümölcs adatai";
            // 
            // textBox_Azonosito
            // 
            this.textBox_Azonosito.Location = new System.Drawing.Point(12, 73);
            this.textBox_Azonosito.Name = "textBox_Azonosito";
            this.textBox_Azonosito.ReadOnly = true;
            this.textBox_Azonosito.Size = new System.Drawing.Size(121, 26);
            this.textBox_Azonosito.TabIndex = 0;
            // 
            // textBox_GyumolcsNev
            // 
            this.textBox_GyumolcsNev.Location = new System.Drawing.Point(159, 73);
            this.textBox_GyumolcsNev.Name = "textBox_GyumolcsNev";
            this.textBox_GyumolcsNev.Size = new System.Drawing.Size(227, 26);
            this.textBox_GyumolcsNev.TabIndex = 1;
            // 
            // numericUpDown_EgysegAr
            // 
            this.numericUpDown_EgysegAr.Location = new System.Drawing.Point(440, 73);
            this.numericUpDown_EgysegAr.Name = "numericUpDown_EgysegAr";
            this.numericUpDown_EgysegAr.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_EgysegAr.TabIndex = 2;
            // 
            // numericUpDown_Mennyiseg
            // 
            this.numericUpDown_Mennyiseg.Location = new System.Drawing.Point(643, 73);
            this.numericUpDown_Mennyiseg.Name = "numericUpDown_Mennyiseg";
            this.numericUpDown_Mennyiseg.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_Mennyiseg.TabIndex = 3;
            // 
            // button_Insert
            // 
            this.button_Insert.Location = new System.Drawing.Point(822, 28);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(196, 28);
            this.button_Insert.TabIndex = 4;
            this.button_Insert.Text = "Új gyümölcs";
            this.button_Insert.UseVisualStyleBackColor = true;
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(822, 73);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(196, 26);
            this.button_Update.TabIndex = 5;
            this.button_Update.Text = "Módosítás";
            this.button_Update.UseVisualStyleBackColor = true;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(822, 117);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(196, 27);
            this.button_Delete.TabIndex = 6;
            this.button_Delete.Text = "Törlés";
            this.button_Delete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 517);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_Gyumolcsok);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Gyumolcsok)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_EgysegAr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Mennyiseg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Gyumolcsok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Insert;
        private System.Windows.Forms.NumericUpDown numericUpDown_Mennyiseg;
        private System.Windows.Forms.NumericUpDown numericUpDown_EgysegAr;
        private System.Windows.Forms.TextBox textBox_GyumolcsNev;
        private System.Windows.Forms.TextBox textBox_Azonosito;
    }
}

