using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_DataGridView
{
    public partial class Form1 : Form
    {
        DataBase db = new DataBase("localhost","root","","gyumolcsok");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DataGridView_felepitese();
            DataGridView_update();
        }

        private void DataGridView_update()
        {
            dataGridView_Gyumolcsok.Rows.Clear();
            foreach (Gyumolcs rekord in db.getAllGyumolcs())
            {
                //-- rekord adatának beírása egy sor celláiba ---
                int sorIndex = dataGridView_Gyumolcsok.Rows.Add(); //-- üres sort adtuk hozzá
                DataGridViewRow getUjSor= dataGridView_Gyumolcsok.Rows[sorIndex]; //-- kiolvassuk
                getUjSor.Cells["id"].Value = rekord.Id;
                getUjSor.Cells["nev"].Value = rekord.Nev;
                getUjSor.Cells["mennyiseg"].Value = rekord.Mennyiseg;
                getUjSor.Cells["egysegar"].Value = rekord.Egysegar;
            }
        }

        private void DataGridView_felepitese()
        {
            DataGridViewColumn col_ID = new DataGridViewColumn();
            {
                //-- col_ID jellemzőinek a beállításai ----------------
                col_ID.Name = "id";
                col_ID.ReadOnly = true;
                col_ID.CellTemplate = new DataGridViewTextBoxCell();
                col_ID.HeaderText = "Azonosító";
            }
            dataGridView_Gyumolcsok.Columns.Add(col_ID);
            
            DataGridViewColumn col_Nev = new DataGridViewColumn();
            {
                col_Nev.Name = "nev";
                col_Nev.HeaderText = "Gyümölcs neve";
                col_Nev.CellTemplate= new DataGridViewTextBoxCell();
            }
            dataGridView_Gyumolcsok.Columns.Add(col_Nev);

            DataGridViewColumn col_Mennyiseg = new DataGridViewColumn();
            {
                col_Mennyiseg.CellTemplate = new DataGridViewTextBoxCell();
                col_Mennyiseg.HeaderText = "Mennyiség";
                col_Mennyiseg.Name = "mennyiseg";
            }
            dataGridView_Gyumolcsok.Columns.Add(col_Mennyiseg);

            DataGridViewColumn col_Egysegar = new DataGridViewColumn();
            {
                col_Egysegar.CellTemplate = new DataGridViewTextBoxCell();
                col_Egysegar.HeaderText = "Egységár";
                col_Egysegar.Name = "egysegar";
            }
            dataGridView_Gyumolcsok.Columns.Add(col_Egysegar);
            //-- Egész táblázatra vonatkozó beállítások ----------
            dataGridView_Gyumolcsok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridView_Gyumolcsok_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView_Gyumolcsok.SelectedRows[0];
            if (row.Cells["id"].Value == null)
            {
                return;
            }
            textBox_Azonosito.Text = row.Cells["id"].Value.ToString();
            textBox_GyumolcsNev.Text = row.Cells["nev"].Value.ToString();
            numericUpDown_EgysegAr.Value = decimal.Parse(row.Cells["egysegar"].Value.ToString());
            numericUpDown_Mennyiseg.Value = decimal.Parse(row.Cells["mennyiseg"].Value.ToString());
        }
    }
}
