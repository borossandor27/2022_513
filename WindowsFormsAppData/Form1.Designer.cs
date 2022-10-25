
namespace WindowsFormsAppData
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
            this.listBox_Dolgozok = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_id = new System.Windows.Forms.NumericUpDown();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Szuletett = new System.Windows.Forms.DateTimePicker();
            this.checkBox_Hazas = new System.Windows.Forms.CheckBox();
            this.button_Insert = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_id)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Dolgozok
            // 
            this.listBox_Dolgozok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_Dolgozok.FormattingEnabled = true;
            this.listBox_Dolgozok.Location = new System.Drawing.Point(0, 0);
            this.listBox_Dolgozok.Name = "listBox_Dolgozok";
            this.listBox_Dolgozok.Size = new System.Drawing.Size(172, 450);
            this.listBox_Dolgozok.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Insert);
            this.groupBox1.Controls.Add(this.checkBox_Hazas);
            this.groupBox1.Controls.Add(this.dateTimePicker_Szuletett);
            this.groupBox1.Controls.Add(this.textBox_Nev);
            this.groupBox1.Controls.Add(this.numericUpDown_id);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(172, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 450);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiválasztott dolgozó";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Azonositó";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Név";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Született";
            // 
            // numericUpDown_id
            // 
            this.numericUpDown_id.Location = new System.Drawing.Point(109, 32);
            this.numericUpDown_id.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_id.Name = "numericUpDown_id";
            this.numericUpDown_id.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_id.TabIndex = 1;
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(109, 74);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(120, 20);
            this.textBox_Nev.TabIndex = 2;
            // 
            // dateTimePicker_Szuletett
            // 
            this.dateTimePicker_Szuletett.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Szuletett.Location = new System.Drawing.Point(109, 118);
            this.dateTimePicker_Szuletett.Name = "dateTimePicker_Szuletett";
            this.dateTimePicker_Szuletett.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker_Szuletett.TabIndex = 3;
            // 
            // checkBox_Hazas
            // 
            this.checkBox_Hazas.AutoSize = true;
            this.checkBox_Hazas.Location = new System.Drawing.Point(109, 180);
            this.checkBox_Hazas.Name = "checkBox_Hazas";
            this.checkBox_Hazas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_Hazas.Size = new System.Drawing.Size(56, 17);
            this.checkBox_Hazas.TabIndex = 4;
            this.checkBox_Hazas.Text = "Házas";
            this.checkBox_Hazas.UseVisualStyleBackColor = true;
            // 
            // button_Insert
            // 
            this.button_Insert.Location = new System.Drawing.Point(31, 232);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(198, 30);
            this.button_Insert.TabIndex = 5;
            this.button_Insert.Text = "Rögzit";
            this.button_Insert.UseVisualStyleBackColor = true;
            this.button_Insert.Click += new System.EventHandler(this.button_Insert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_Dolgozok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_id)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Dolgozok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_Hazas;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Szuletett;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.NumericUpDown numericUpDown_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Insert;
    }
}

