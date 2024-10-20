using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;


namespace projekt2
{
    internal class Wyswietl
    {
        public Wyswietl(MySqlConnection connection)
        {
            MySqlCommand command1 = connection.CreateCommand();
            command1.CommandText = "select * from osoby";
            var reader1 = command1.ExecuteReader();
            Console.WriteLine("tabela osoby");
            int i = 0;
            int j = 1;
            while (reader1.Read())
            {
                i++;
                if (j > 10)
                {
                    Console.Write("następne(n) ");
                    Console.WriteLine("E: exit");
                    string input = Console.ReadLine();
                    switch (input)
                    {
                        case "n":
                            j = 1;
                            Console.Clear();
                            break;
                        case "e":
                            Console.Clear();
                            return;

                    }

                }
                Console.WriteLine(j + "| " + reader1.GetInt32(0) + " " + reader1.GetString(1) + " " + reader1.GetString(2) + " " + reader1.GetString(3) + " " + reader1.GetString(4));
                j++;
            }
        }
    }
}
