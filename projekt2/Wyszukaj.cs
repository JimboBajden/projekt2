using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace projekt2
{
    internal class Wyszukaj
    {
        MySqlConnection conn;
        MySqlCommand command;
        bool check = false;
        public Wyszukaj(MySqlConnection connection)
        {
            this.conn = connection;
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM osoby WHERE ";
            PoCzym();
            Console.Clear();

        }
        private void PoCzym()
        {
            Console.WriteLine(command.CommandText);
            Console.WriteLine("po czym szukać: ");
            Console.WriteLine("1: id");
            Console.WriteLine("2: imie");
            Console.WriteLine("3: nazwiko");
            Console.WriteLine("4: numer telefonu");
            Console.WriteLine("5: adres");
            Console.WriteLine("6: Wyszukaj");
            Console.WriteLine("8: wyjdz");
            string opcja = Console.ReadLine();

            switch (opcja)
            {
                case "1":
                    Id();
                    break;
                case "2":
                    imie();
                    break;
                case "3":
                    nazwisko();
                    break;
                case "4":
                    numer();
                    break;
                case "5":
                    adres();
                    break;
                case "6":
                    if (command.CommandText == "SELECT * FROM osoby WHERE ")
                    {
                        command.CommandText = "SELECT * FROM osoby";
                    }
                    var reader1 = command.ExecuteReader();
                    Console.WriteLine("tabela osoby");
                    int i = 0;
                    while (reader1.Read())
                    {
                        i++;
                        Console.WriteLine(reader1.GetInt32(0) + " " + reader1.GetString(1) + " " + reader1.GetString(2) + " "
                        + reader1.GetString(3) + " " + reader1.GetString(4));
                    }
                    if (i == 0) { Console.WriteLine("nie ma takiego / takich"); }
                    reader1.Close();
                    Console.WriteLine("nacisnij coś");
                    Console.ReadKey();
                    break;
                case "8":
                    Console.Clear();
                    return;
            }

        }

        public MySqlCommand GiveCommand()
        {

            return command;
        }

        private void Id()
        {
            if (check == true)
            {
                command.CommandText += " AND  ";
            }
            Console.WriteLine("podaj id: "); string id = Console.ReadLine();
            command.CommandText += $" id = {id} ";
            check = true;
            PoCzym();

        }

        private void imie()
        {
            if (check == true)
            {
                command.CommandText += " AND  ";
            }
            Console.WriteLine("podaj imie (albo fragment + '%'): "); string imie = Console.ReadLine();
            command.CommandText += $" imie LIKE('{imie}') ";
            check = true;
            PoCzym();
        }
        private void nazwisko()
        {
            if (check == true)
            {
                command.CommandText += " AND  ";
            }
            Console.WriteLine("podaj nazwisko (albo fragment + '%'): "); string nazwisko = Console.ReadLine();
            command.CommandText += $" nazwisko LIKE ('{nazwisko}') ";
            check = true;
            PoCzym();
        }
        private void numer()
        {
            if (check == true)
            {
                command.CommandText += " AND  ";
            }
            Console.WriteLine("podaj numer (albo fragment + '%'): "); string numer = Console.ReadLine();
            command.CommandText += $"numerTelefonu LIKE '{numer}' ";
            check = true;
            PoCzym();
        }
        private void adres()
        {
            if (check == true)
            {
                command.CommandText += " AND  ";
            }
            Console.WriteLine("podaj adres (albo fragment + '%'): "); string adres = Console.ReadLine();
            command.CommandText += $" adres LIKE('{adres}') ";
            check = true;
            PoCzym();
        }
    }
}

