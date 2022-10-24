using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConsoleAdatbazis
{
    internal class Program
    {

        static void Main(string[] args)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "pizza";

            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT `pazon`, `pnev`, `par` FROM `pizza`;";
                //-- Adatok lekérdezése ---
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int pazon = dr.GetInt32("pazon");
                        string pnev = dr.GetString("pnev");
                        int par = dr.GetInt32("par");
                        Console.WriteLine($"{pazon}. {pnev,-15} - {par.ToString("#,##0 Ft/db"),12}");
                    }
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
            Console.WriteLine("\nProgram vége!");
            Console.Read();
        }
    }
}
