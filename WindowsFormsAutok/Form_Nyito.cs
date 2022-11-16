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

namespace WindowsFormsAutok2
{
    public partial class Form_Nyito : Form
    {
        MySqlConnection conn = null;
        MySqlCommand cmd = null;
        public Form_Nyito()
        {
            InitializeComponent();
        }

        private void Form_Nyito_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "autok";
            conn = new MySqlConnection(builder.ConnectionString);
            try
            {
                //-- terv szerint
                conn.Open();
                cmd = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                //-- váratlan hiba!
                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll!");
                Environment.Exit(0);
            } 
            finally
            {
                //-- Hiba és terv szerinti esetén is lefut
                conn.Close();
            }
            Autok_lista_update();
        }

        /**
         * public void Autok_lista_update()
           Autók listájának frissítése az adatbázisból
         */
        private void Autok_lista_update()
        {
            listBox_Autok.Items.Clear();
            cmd.CommandText = "SELECT `id`,`rendszam`,`uzembehelyezve`,`szin` FROM `autok` WHERE 1;";
            conn.Open();
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    Auto uj = new Auto(dr.GetInt32("id"), dr.GetString("rendszam"), dr.GetInt32("uzembehelyezve"), dr.GetString("szin"));
                    listBox_Autok.Items.Add(uj);
                }
            }
            conn.Close();
        }

        private void button_Insert_Click(object sender, EventArgs e)
        {
            if (nincsenek_adatok())
            {
                return;
            }
            //-- Kiírjuk az adatbázisba  -------
            cmd.CommandText = "INSERT INTO `autok` (`id`, `rendszam`, `uzembehelyezve`, `szin`) VALUES (NULL, @rendszam, @ev, @szin);";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@rendszam",textBox_Rendszam.Text);
            cmd.Parameters.AddWithValue("@ev",numericUpDown_Evjarat.Value.ToString());
            cmd.Parameters.AddWithValue("@szin", textBox_Szin.Text);
            conn.Open();
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sikeresen rögzítve!");
                    textBox_Id.Text = "";
                    numericUpDown_Evjarat.Value=numericUpDown_Evjarat.Minimum;
                    textBox_Szin.Text = "";
                    textBox_Rendszam.Text = "";
                }
                else
                {
                    MessageBox.Show("Sikertelen rögzítés!");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            Autok_lista_update();
        }

        private bool nincsenek_adatok()
        {
            //-- szükséges adatok ellenőrzése
            if (string.IsNullOrEmpty(textBox_Rendszam.Text))
            {
                MessageBox.Show("Adjon meg rendszámot!");
                textBox_Rendszam.Focus();
                return true;
            }
            if (numericUpDown_Evjarat.Value > DateTime.Now.Year)
            {
                MessageBox.Show("Érvénytelen évjárat!");
                numericUpDown_Evjarat.Value = DateTime.Now.Year;
                numericUpDown_Evjarat.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(textBox_Szin.Text))
            {
                MessageBox.Show("Nem adott meg színt!");
                textBox_Szin.Focus();
                return true;
            }
            return false;
        }

        private void listBox_Autok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Autok.SelectedIndex < 0)
            {
                return;
            }
            //-- A felhasználó kijelölt egy elemet a listában -------
            Auto kivalasztott_auto = (Auto)listBox_Autok.SelectedItem;
            textBox_Id.Text = kivalasztott_auto.Id.ToString();
            textBox_Rendszam.Text = kivalasztott_auto.Rendszam;
            textBox_Szin.Text = kivalasztott_auto.Szin;
            numericUpDown_Evjarat.Value = kivalasztott_auto.Evjarat;
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (listBox_Autok.SelectedIndex < 0 || nincsenek_adatok())
            {
                MessageBox.Show("Nincs kijelölve autó!");
                return;
            }
            cmd.CommandText = "UPDATE `autok` SET `rendszam`= @rendszam,`uzembehelyezve`=@evjarat,`szin`= @szin WHERE `id`=@id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", textBox_Id.Text);
            cmd.Parameters.AddWithValue("@rendszam", textBox_Rendszam.Text);
            cmd.Parameters.AddWithValue("@evjarat", numericUpDown_Evjarat.Value);
            cmd.Parameters.AddWithValue("@szin", textBox_Szin.Text);
            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Módosítás sikeres!");
                conn.Close();
                textBox_Id.Text = "";
                textBox_Rendszam.Text = "";
                textBox_Szin.Text = "";
                numericUpDown_Evjarat.Value = numericUpDown_Evjarat.Minimum;
                Autok_lista_update();
            }
            else
            {
                MessageBox.Show("Az adatok módosítása sikertelen!");
            }
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
