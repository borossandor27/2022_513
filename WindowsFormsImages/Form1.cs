using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsImages
{
    public partial class Form1 : Form
    {
        List<Image> images; 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.png|*.png|*.jpg|*.jpg|*.webp|*.webp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string kepFajl = openFileDialog1.FileName;
                pictureBox1.Image=Image.FromFile(kepFajl);
            }
        }
    }
}
