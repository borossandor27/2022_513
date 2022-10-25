using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsAppData
{
    public partial class Form1 : Form
    {
        MySqlConnection connection = null;
        MySqlCommand command = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Insert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Nev.Text))
            {
                MessageBox.Show("Hiányzó adat!", "Nem adott meg nevet!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            string nev = textBox_Nev.Text;

            DateTime datum = dateTimePicker_Szuletett.Value;
            int kor = DateTime.Now.Year - datum.Year;
            if (kor>100)
            {
                MessageBox.Show("Öreg vagy már ehhez papa!");
                return;
            }
            if (kor < 18)
            {
                MessageBox.Show("Túl fiatal vagy!");
            }
            Boolean hazas = checkBox_Hazas.Checked;

            Dolgozo dolgozo = new Dolgozo(0, nev, datum, hazas);
            if (ujrekord(dolgozo))
            {
                MessageBox.Show("Sikeres!");
            }
            else
            {
                MessageBox.Show("Sikertelen");
            }
            
        }

        private bool ujrekord(Dolgozo dolgozo)
        {
            try
            {
                command.CommandText= $"INSERT INTO `dolgozo`(`id`, `nev`, `szuletett`, `hazas`) VALUES (null,'@nev','@datum',{checkBox_Hazas.Checked?"true":"false"})"
            }
            catch (MySqlException ex)
            {

                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "dolgozok";
            connection = new MySqlConnection(builder.ConnectionString);
            command = connection.CreateCommand();
        }
    }
}
