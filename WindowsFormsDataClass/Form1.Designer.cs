﻿namespace WindowsFormsDataClass
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
            this.listBox_Gyumolcsok = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.textBox_GyumolcsNev = new System.Windows.Forms.TextBox();
            this.numericUpDown_Mennyiseg = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Egysegar = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Mennyiseg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Egysegar)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Gyumolcsok
            // 
            this.listBox_Gyumolcsok.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox_Gyumolcsok.FormattingEnabled = true;
            this.listBox_Gyumolcsok.ItemHeight = 24;
            this.listBox_Gyumolcsok.Location = new System.Drawing.Point(749, 0);
            this.listBox_Gyumolcsok.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBox_Gyumolcsok.Name = "listBox_Gyumolcsok";
            this.listBox_Gyumolcsok.Size = new System.Drawing.Size(284, 533);
            this.listBox_Gyumolcsok.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown_Egysegar);
            this.groupBox1.Controls.Add(this.numericUpDown_Mennyiseg);
            this.groupBox1.Controls.Add(this.textBox_GyumolcsNev);
            this.groupBox1.Controls.Add(this.textBox_Id);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(749, 533);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiválasztott gyümölcs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Azonosító";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gyümölcsnév";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mennyiség";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Egységár";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(190, 38);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.ReadOnly = true;
            this.textBox_Id.Size = new System.Drawing.Size(100, 29);
            this.textBox_Id.TabIndex = 4;
            // 
            // textBox_GyumolcsNev
            // 
            this.textBox_GyumolcsNev.Location = new System.Drawing.Point(170, 90);
            this.textBox_GyumolcsNev.Name = "textBox_GyumolcsNev";
            this.textBox_GyumolcsNev.Size = new System.Drawing.Size(155, 29);
            this.textBox_GyumolcsNev.TabIndex = 5;
            // 
            // numericUpDown_Mennyiseg
            // 
            this.numericUpDown_Mennyiseg.DecimalPlaces = 2;
            this.numericUpDown_Mennyiseg.Location = new System.Drawing.Point(205, 138);
            this.numericUpDown_Mennyiseg.Name = "numericUpDown_Mennyiseg";
            this.numericUpDown_Mennyiseg.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown_Mennyiseg.TabIndex = 6;
            this.numericUpDown_Mennyiseg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDown_Egysegar
            // 
            this.numericUpDown_Egysegar.DecimalPlaces = 2;
            this.numericUpDown_Egysegar.Location = new System.Drawing.Point(205, 192);
            this.numericUpDown_Egysegar.Name = "numericUpDown_Egysegar";
            this.numericUpDown_Egysegar.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown_Egysegar.TabIndex = 7;
            this.numericUpDown_Egysegar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 533);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_Gyumolcsok);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Mennyiseg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Egysegar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Gyumolcsok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Egysegar;
        private System.Windows.Forms.NumericUpDown numericUpDown_Mennyiseg;
        private System.Windows.Forms.TextBox textBox_GyumolcsNev;
        private System.Windows.Forms.TextBox textBox_Id;
    }
}

