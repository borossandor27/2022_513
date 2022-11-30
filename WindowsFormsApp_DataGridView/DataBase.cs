using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp_DataGridView
{
    internal class DataBase
    {
        private MySqlConnection connection;
        private MySqlCommand sqlCommand;
        private string hibaSzoveg = null;
        public DataBase(string host, string user, string password, string db) { 
       MySqlConnectionStringBuilder stringBuilder= new MySqlConnectionStringBuilder();
            stringBuilder.Server=host;
            stringBuilder.UserID=user;
            stringBuilder.Password=password;
            stringBuilder.Database=db;
            connection = new MySqlConnection(stringBuilder.ConnectionString);
            sqlCommand = connection.CreateCommand();
        }
        private bool dbOpen()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (MySqlException ex)
            {
                hibaSzoveg = ex.Message;
                return false;
            }
            return true;
        }
        private bool dbClose()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                hibaSzoveg = ex.Message;
                return false;
            }
            return true;
        }

        public List<Gyumolcs> getAllGyumolcs()
        {
            List<Gyumolcs> gyumolcs = new List<Gyumolcs>();
            sqlCommand.CommandText = "SELECT `id`,`nev`,`egysegar`,`mennyiseg` FROM `gyumolcsok` WHERE 1";
            if (dbOpen())
            {
                using (MySqlDataReader dr = sqlCommand.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Gyumolcs uj = new Gyumolcs(dr.GetInt32("id"), dr.GetString("nev"), dr.GetDouble("egysegar"), dr.GetDouble("mennyiseg"));
                        gyumolcs.Add(uj);
                    }
                }
            }
            else
            {
                MessageBox.Show(hibaSzoveg);
            }
            dbClose();
            return gyumolcs;
        }
    }
}
