using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsMultiForms
{
    public partial class FormTanuloUpdate : Form
    {
        public FormTanuloUpdate()
        {
            InitializeComponent();
        }

        private void FormTanuloUpdate_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Program.form_Nyito.textBox_Nev.Text + " adatainak a módosítása");
        }
    }
}
