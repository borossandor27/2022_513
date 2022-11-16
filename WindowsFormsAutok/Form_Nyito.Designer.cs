namespace WindowsFormsAutok2
{
    partial class Form_Nyito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Nyito));
            this.listBox_Autok = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Insert = new System.Windows.Forms.Button();
            this.textBox_Szin = new System.Windows.Forms.TextBox();
            this.numericUpDown_Evjarat = new System.Windows.Forms.NumericUpDown();
            this.textBox_Rendszam = new System.Windows.Forms.TextBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Evjarat)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Autok
            // 
            this.listBox_Autok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_Autok.FormattingEnabled = true;
            this.listBox_Autok.ItemHeight = 25;
            this.listBox_Autok.Location = new System.Drawing.Point(0, 0);
            this.listBox_Autok.Name = "listBox_Autok";
            this.listBox_Autok.Size = new System.Drawing.Size(228, 576);
            this.listBox_Autok.TabIndex = 0;
            this.listBox_Autok.SelectedIndexChanged += new System.EventHandler(this.listBox_Autok_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Delete);
            this.groupBox1.Controls.Add(this.button_Update);
            this.groupBox1.Controls.Add(this.button_Insert);
            this.groupBox1.Controls.Add(this.textBox_Szin);
            this.groupBox1.Controls.Add(this.numericUpDown_Evjarat);
            this.groupBox1.Controls.Add(this.textBox_Rendszam);
            this.groupBox1.Controls.Add(this.textBox_Id);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(228, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 576);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiválasztott autó adatai";
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(29, 450);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(370, 48);
            this.button_Delete.TabIndex = 10;
            this.button_Delete.Text = "Törlés";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(29, 371);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(370, 48);
            this.button_Update.TabIndex = 9;
            this.button_Update.Text = "Módosít";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Insert
            // 
            this.button_Insert.Location = new System.Drawing.Point(29, 290);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(370, 50);
            this.button_Insert.TabIndex = 8;
            this.button_Insert.Text = "Új";
            this.button_Insert.UseVisualStyleBackColor = true;
            this.button_Insert.Click += new System.EventHandler(this.button_Insert_Click);
            // 
            // textBox_Szin
            // 
            this.textBox_Szin.Location = new System.Drawing.Point(171, 204);
            this.textBox_Szin.Name = "textBox_Szin";
            this.textBox_Szin.Size = new System.Drawing.Size(188, 31);
            this.textBox_Szin.TabIndex = 7;
            // 
            // numericUpDown_Evjarat
            // 
            this.numericUpDown_Evjarat.Location = new System.Drawing.Point(171, 151);
            this.numericUpDown_Evjarat.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDown_Evjarat.Name = "numericUpDown_Evjarat";
            this.numericUpDown_Evjarat.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown_Evjarat.TabIndex = 6;
            this.numericUpDown_Evjarat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_Rendszam
            // 
            this.textBox_Rendszam.Location = new System.Drawing.Point(171, 98);
            this.textBox_Rendszam.Name = "textBox_Rendszam";
            this.textBox_Rendszam.Size = new System.Drawing.Size(188, 31);
            this.textBox_Rendszam.TabIndex = 5;
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(171, 45);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.ReadOnly = true;
            this.textBox_Id.Size = new System.Drawing.Size(100, 31);
            this.textBox_Id.TabIndex = 4;
            this.textBox_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Szín";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Évjárat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rendszám";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // Form_Nyito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 576);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_Autok);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form_Nyito";
            this.Text = "Autók nyilvántartása";
            this.Load += new System.EventHandler(this.Form_Nyito_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Evjarat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Autok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Insert;
        private System.Windows.Forms.TextBox textBox_Szin;
        private System.Windows.Forms.NumericUpDown numericUpDown_Evjarat;
        private System.Windows.Forms.TextBox textBox_Rendszam;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

