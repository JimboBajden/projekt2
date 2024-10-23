using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt2
{
    internal class DataBase
    {
        public DataBase() 
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Database=projekt;Server=localhost;user=root;password=");
                connection.Open();
            }
            catch (Exception ex) 
            {
                MySqlConnection connection = new MySqlConnection("Server=localhost;user=root;password=;");
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "CREATE DATABASE `projektt` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;";
                command.ExecuteNonQuery();
                MySqlConnection conn = new MySqlConnection("Database=projekt;Server=localhost;user=root;password=");conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "CREATE TABLE `osoby` (\r\n  `id` int(11) NOT NULL,\r\n  `imie` varchar(255) DEFAULT NULL,\r\n  `nazwisko` varchar(255) DEFAULT NULL,\r\n  `numerTelefonu` varchar(255) DEFAULT NULL,\r\n  `adres` varchar(255) DEFAULT NULL\r\n) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;";
                cmd.ExecuteNonQuery();
                  

            }
            
        }
    }
}
