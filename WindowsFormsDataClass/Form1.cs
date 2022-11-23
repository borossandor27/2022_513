using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDataClass
{
    public partial class Form1 : Form
    {
        AdatBazis adatBazis = new AdatBazis();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GyumolcsokBetoltese();
        }

        private void GyumolcsokBetoltese()
        {
            listBox_Gyumolcsok.Items.Clear();
            var lista = adatBazis.getAllGyumolcs();
            foreach (Gyumolcs item in adatBazis.getAllGyumolcs())
            {
                listBox_Gyumolcsok.Items.Add(item);
            }
        }
    }
}
