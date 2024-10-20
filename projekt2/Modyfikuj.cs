using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace projekt2
{
    internal class Modyfikuj
    {
        MySqlConnection conn;
        MySqlDataReader cmd = null;
        List<int> ids = new List<int>();
        List<string> content = new List<string>();
        int id;
        string osoba;
        public Modyfikuj(MySqlConnection con)
        {
            conn = con;
            if (Co() == false) { return; }

            Console.Clear();
            Read();
            //Console.WriteLine();
            Write();
            OCo();
            Console.Clear();
        }
        private void OCo()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(osoba);
                Console.WriteLine("______________________");
                Console.WriteLine("co chcesz zmienić");
                Console.WriteLine("1: imie");
                Console.WriteLine("2: nazwisko");
                Console.WriteLine("3: numer telefonu");
                Console.WriteLine("4: adres");
                Console.WriteLine("5: nic :)");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("podaj nowe imie");
                        string name = Console.ReadLine();
                        MySqlCommand cmd = new MySqlCommand();
                        cmd = conn.CreateCommand();
                        cmd.CommandText = $"UPDATE osoby SET imie = '{name}' WHERE id = {id}";
                        Console.WriteLine(cmd.CommandText);
                        cmd.ExecuteNonQuery();
                        break;
                    case "2":
                        Console.WriteLine("podaj nowe nazwisko");
                        string Lname = Console.ReadLine();
                        MySqlCommand cmd2 = new MySqlCommand();
                        cmd2 = conn.CreateCommand();
                        cmd2.CommandText = $"UPDATE osoby SET nazwisko = '{Lname}' WHERE id = {id}";
                        Console.WriteLine(cmd2.CommandText);
                        cmd2.ExecuteNonQuery();
                        break;
                    case "3":
                        Console.WriteLine("podaj nowy numer telefonu");
                        string numer = Console.ReadLine();
                        if (numer.Length > 9) { numer = numer.Substring(0, 9); }
                        MySqlCommand cmd3 = new MySqlCommand();
                        cmd3 = conn.CreateCommand();
                        cmd3.CommandText = $"UPDATE osoby SET numerTelefonu = '{numer}' WHERE id = {id}";
                        Console.WriteLine(cmd3.CommandText);
                        cmd3.ExecuteNonQuery();
                        break;
                    case "4":
                        Console.WriteLine("podaj nowy adres");
                        string adres = Console.ReadLine();
                        MySqlCommand cmd4 = new MySqlCommand();
                        cmd4 = conn.CreateCommand();
                        cmd4.CommandText = $"UPDATE osoby SET adres = '{adres}' WHERE id = {id}";
                        Console.WriteLine(cmd4.CommandText);
                        cmd4.ExecuteNonQuery();
                        break;
                    case "5":
                        return;
                }
            }

        }
        private bool Co()
        {
            Wyszukaj wyszukaj = new Wyszukaj(conn);
            try
            {
                cmd = wyszukaj.GiveReader();
            }
            catch (Exception ex) { return false; }

            return true;

        }
        private void Read()
        {
            while (cmd.Read())
            {
                content.Add(cmd.GetInt32(0) + " " + cmd.GetString(1) + " " + cmd.GetString(2) + " " + cmd.GetString(3) + " " + cmd.GetString(4));
                ids.Add(cmd.GetInt32(0));
            }
            cmd.Close();
        }
        private void choice(ref int i, ref int j)
        {
            Console.WriteLine();
            Console.WriteLine("wybierz numer albo przejdz do następnej");
            Console.Write("następne(n) "); if (i != 0) { Console.Write(" poprzednie(p)"); }
            string input = Console.ReadLine();
            switch (input)
            {
                case "n":
                    j = 0;
                    break;
                case "p":
                    if (i > 5) { i = i - 10; j = 0; }
                    break;
                case "0":
                    id = ids[i - 5];
                    osoba = content[i - 5];
                    break;
                case "1":
                    id = ids[i - 4];
                    osoba = content[i - 4];
                    break;
                case "2":
                    id = ids[i - 3];
                    osoba = content[i - 3];
                    break;
                case "3":
                    id = ids[i - 2];
                    osoba = content[i - 2];
                    break;
                case "4":
                    id = ids[i - 1];
                    osoba = content[i - 1];

                    break;


            }
        }
        private void Write()
        {
            int i = 0;
            int j = 0;
            int c = ids.Count;
            if (ids.Count / 5 > 1)
            {
                while (c > -1)
                {
                    c--;
                    if (i < ids.Count)
                    {
                        Console.WriteLine(j + "| " + content[i]);
                        i++;
                    }
                    j++;
                    if (j > 4)
                    {
                        choice(ref i, ref j);
                    }
                }


            }
            else
            {
                while (i < ids.Count)
                {
                    Console.WriteLine(j + "| " + content[i]);
                    j++;
                    i++;
                }
                Console.WriteLine();
                Console.WriteLine("wybierz numer");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        if (ids.Count >= 1)
                        {
                            id = ids[0];
                            osoba = content[0];
                        }
                        return;
                        break;
                    case "1":
                        if (ids.Count >= 2)
                        {
                            id = ids[1];
                            osoba = content[1];
                        }
                        return;
                        break;
                    case "2":
                        if (ids.Count >= 3)
                        {
                            id = ids[2];
                            osoba = content[2];
                        }
                        return;
                        break;
                    case "3":
                        if (ids.Count >= 4)
                        {
                            id = ids[3];
                            osoba = content[3];
                        }
                        break;
                    case "4":
                        if (ids.Count >= 5)
                        {
                            id = ids[4];
                            osoba = content[4];
                        }
                        Console.Clear();
                        return;
                        break;

                }
            }
        }
        }
    }
