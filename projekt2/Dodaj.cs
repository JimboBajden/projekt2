using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace projekt2
{
    internal class Dodaj
    {
        public Dodaj(MySqlConnection connection)
        {
            MySqlCommand command2 = connection.CreateCommand();

            Console.Write("imie: "); string imie = Console.ReadLine();
            Console.WriteLine("nazwisko: "); string nazwisko = Console.ReadLine();
            Console.WriteLine("numer telefonu: "); string numer = Console.ReadLine();
            if (numer.Length > 9) { numer = numer.Substring(0, 9); }

            Console.WriteLine("adres: "); string adres = Console.ReadLine();

            command2.CommandText = $"insert into osoby (imie , nazwisko , numerTelefonu , adres) values ('{imie}' , '{nazwisko}' , '{numer}' , '{adres}')";

            var numberOfRows = command2.ExecuteNonQuery();
            Console.Clear();
            Console.WriteLine($"dodano osobe : {imie} {nazwisko} {numer} {adres}");

        }
    }
}
