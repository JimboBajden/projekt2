using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace projekt2
{
    internal class Menu
    {
        public MySqlConnection connection = new MySqlConnection("Database=projekt;Server=localhost;user=root;password=");
        public Menu()
        {
            connection.Open();
            while (true)
            {
                //SQLiteCommand command = connection.CreateCommand();
                //command.CommandText = "INSERT INTO osoby (imie, nazwisko, numerTelefonu, adres) VALUES\r\n('Jan', 'Kowalski', '123456789', 'ul. Nowa 5, Warszawa'),\r\n('Anna', 'Nowak', '987654321', 'ul. Stara 12, Kraków'),\r\n('Piotr', 'Wiśniewski', '654321987', 'ul. Zielona 8, Gdańsk'),\r\n('Maria', 'Lewandowska', '111222333', 'ul. Słoneczna 9, Poznań'),\r\n('Tomasz', 'Kamiński', '444555666', 'ul. Wesoła 2, Wrocław'),\r\n('Katarzyna', 'Zielińska', '777888999', 'ul. Jasna 10, Łódź'),\r\n('Michał', 'Szymański', '999888777', 'ul. Krótka 3, Lublin'),\r\n('Agnieszka', 'Wójcik', '555666777', 'ul. Długa 15, Szczecin'),\r\n('Robert', 'Kozłowski', '333444555', 'ul. Spokojna 7, Bydgoszcz'),\r\n('Paweł', 'Jankowski', '222333444', 'ul. Leśna 11, Katowice');\r\n";
                //command.ExecuteNonQuery();

                Console.WriteLine("opcje: ");
                Console.WriteLine("1: zobacz osoby");
                Console.WriteLine("2: dodaj osoby");
                Console.WriteLine("3: usuń osoby");
                Console.WriteLine("4: wyszukaj osoby");
                Console.WriteLine("5: modyfikuj rekord");
                string option = Console.ReadLine();
                Console.Clear();

                switch (option)
                {
                    case "1":
                        Wyswietl wyswietl = new Wyswietl(connection);
                        break;
                    case "2":
                        Dodaj dodaj = new Dodaj(connection);
                        break;
                    case "3":
                        Usuwanie usuwanie = new Usuwanie(connection);
                        break;
                    case "4":
                        Wyszukaj wyszukaj = new Wyszukaj(connection);
                        break;
                    case "5":
                        Modyfikuj modyfikuj = new Modyfikuj(connection);
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
        
