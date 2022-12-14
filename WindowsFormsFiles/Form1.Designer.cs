namespace WindowsFormsFiles
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
            this.richTextBox_szoveg = new System.Windows.Forms.RichTextBox();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button_Open = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // richTextBox_szoveg
            // 
            this.richTextBox_szoveg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox_szoveg.Location = new System.Drawing.Point(0, 113);
            this.richTextBox_szoveg.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.richTextBox_szoveg.Name = "richTextBox_szoveg";
            this.richTextBox_szoveg.Size = new System.Drawing.Size(934, 421);
            this.richTextBox_szoveg.TabIndex = 0;
            this.richTextBox_szoveg.Text = "";
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(128, 66);
            this.textBox_Nev.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(319, 29);
            this.textBox_Nev.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Név";
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(487, 61);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(134, 40);
            this.button_Save.TabIndex = 3;
            this.button_Save.Text = "Mentés";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(662, 61);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(144, 40);
            this.button_Open.TabIndex = 4;
            this.button_Open.Text = "Megnyit";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 534);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Nev);
            this.Controls.Add(this.richTextBox_szoveg);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Szövegfájlok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_szoveg;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

