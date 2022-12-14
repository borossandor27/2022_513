using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Nev.Text))
            {
                MessageBox.Show("Nem adott meg nevet");
                return;
            }
            if (string.IsNullOrEmpty(richTextBox_szoveg.Text))
            {
                MessageBox.Show("Nem adott meg szöveget!");
                return;
            }

            saveFileDialog1.Filter = "Egyszerű szöveg fájl|*.txt|Vesszővel tagolt szövegfájl (*.csv)|*.csv|Minden fájl|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string szoveg = string.Join(";", textBox_Nev.Text, richTextBox_szoveg.Text);
                string kivFile= saveFileDialog1.FileName;
                File.WriteAllText(kivFile, szoveg);
                textBox_Nev.Text = "";
                richTextBox_szoveg.Text = "";
            } else
            {
                MessageBox.Show("Nincs kiválasztva!");
            }
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string kivFile = openFileDialog1.FileName;
                string beolvasottSzoveg = File.ReadAllText(kivFile);
                string[] adatok = beolvasottSzoveg.Split(';');
                textBox_Nev.Text = adatok[0];
                richTextBox_szoveg.Text = adatok[1];
            }
        }
    }
}
