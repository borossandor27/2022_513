namespace WindowsFormsOrszagok
{
    partial class Form_Orszagok
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
            this.listBox_Orszagok = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_Orszagnev = new System.Windows.Forms.TextBox();
            this.textBox_Fovaros = new System.Windows.Forms.TextBox();
            this.textBox_terulet = new System.Windows.Forms.TextBox();
            this.textBox_Nepesseg = new System.Windows.Forms.TextBox();
            this.textBox_Allamforma = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Orszagok
            // 
            this.listBox_Orszagok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_Orszagok.FormattingEnabled = true;
            this.listBox_Orszagok.ItemHeight = 20;
            this.listBox_Orszagok.Location = new System.Drawing.Point(0, 0);
            this.listBox_Orszagok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox_Orszagok.Name = "listBox_Orszagok";
            this.listBox_Orszagok.Size = new System.Drawing.Size(278, 439);
            this.listBox_Orszagok.TabIndex = 0;
            this.listBox_Orszagok.SelectedIndexChanged += new System.EventHandler(this.listBox_Orszagok_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Allamforma);
            this.groupBox1.Controls.Add(this.textBox_Nepesseg);
            this.groupBox1.Controls.Add(this.textBox_terulet);
            this.groupBox1.Controls.Add(this.textBox_Fovaros);
            this.groupBox1.Controls.Add(this.textBox_Orszagnev);
            this.groupBox1.Controls.Add(this.textBox_id);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(278, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(557, 439);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiválasztott ország adatai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Főváros:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ország neve:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Terület:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Népesség:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Államforma:";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(177, 47);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 26);
            this.textBox_id.TabIndex = 4;
            this.textBox_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_Orszagnev
            // 
            this.textBox_Orszagnev.Location = new System.Drawing.Point(177, 90);
            this.textBox_Orszagnev.Name = "textBox_Orszagnev";
            this.textBox_Orszagnev.Size = new System.Drawing.Size(271, 26);
            this.textBox_Orszagnev.TabIndex = 5;
            // 
            // textBox_Fovaros
            // 
            this.textBox_Fovaros.Location = new System.Drawing.Point(177, 137);
            this.textBox_Fovaros.Name = "textBox_Fovaros";
            this.textBox_Fovaros.Size = new System.Drawing.Size(271, 26);
            this.textBox_Fovaros.TabIndex = 6;
            // 
            // textBox_terulet
            // 
            this.textBox_terulet.Location = new System.Drawing.Point(177, 182);
            this.textBox_terulet.Name = "textBox_terulet";
            this.textBox_terulet.Size = new System.Drawing.Size(271, 26);
            this.textBox_terulet.TabIndex = 7;
            this.textBox_terulet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_Nepesseg
            // 
            this.textBox_Nepesseg.Location = new System.Drawing.Point(177, 229);
            this.textBox_Nepesseg.Name = "textBox_Nepesseg";
            this.textBox_Nepesseg.Size = new System.Drawing.Size(271, 26);
            this.textBox_Nepesseg.TabIndex = 8;
            this.textBox_Nepesseg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_Allamforma
            // 
            this.textBox_Allamforma.Location = new System.Drawing.Point(177, 286);
            this.textBox_Allamforma.Name = "textBox_Allamforma";
            this.textBox_Allamforma.Size = new System.Drawing.Size(271, 26);
            this.textBox_Allamforma.TabIndex = 9;
            // 
            // Form_Orszagok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 439);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_Orszagok);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Orszagok";
            this.Text = "A Föld országai";
            this.Load += new System.EventHandler(this.Form_Orszagok_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Orszagok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Allamforma;
        private System.Windows.Forms.TextBox textBox_Nepesseg;
        private System.Windows.Forms.TextBox textBox_terulet;
        private System.Windows.Forms.TextBox textBox_Fovaros;
        private System.Windows.Forms.TextBox textBox_Orszagnev;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

