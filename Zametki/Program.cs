using System.Data;

namespace Zametki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            data13vibor();
        }
        static void data13vibor()
        {
            Zametka zametka = new Zametka();
            zametka.Name = "Покушать";
            zametka.Description = "Макарошки";
            zametka.Date = new DateTime(2022, 10, 13);

            Zametka zametka2 = new Zametka();
            zametka2.Name = "Сделать философию";
            zametka2.Description = "Написать практическую 2";
            zametka2.Date = new DateTime(2022, 10, 13);

            Zametka[] allNotes = new Zametka[] { zametka, zametka2 };



            DateTime date = new DateTime(2022, 10, 13);
            Console.Clear();
            int position = 1;
            date13menu(allNotes);
            while (true)
            {
                ConsoleKeyInfo Key = Console.ReadKey();
                if (Key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    date13viborCycle(position, allNotes);
                }
                else if (Key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    date13viborCycle(position, allNotes);
                }
                else if (Key.Key == ConsoleKey.RightArrow)
                {
                    data14vibor();
                }
                else if (Key.Key == ConsoleKey.Enter)
                {
                    if (position == 1)
                    {
                        vivod(allNotes[0], 13);
                    }
                    else if (position == 2)
                    {
                        vivod(allNotes[1], 13);
                    }
                }

            }

            static void date13viborCycle(int position, Zametka[] allNotes)
            {
                Console.Clear();
                date13menu(allNotes);
                Console.SetCursorPosition(0, position);
                Console.WriteLine("-->");
            }
        }

        private static void date13viborCycle(int position, Zametka[] allNotes, DateTime date)
        {
            throw new NotImplementedException();
        }

        static void data14vibor()
        {
            Zametka zametka = new Zametka();
            zametka.Name = "Жоска купить еды";
            zametka.Description = "Купить макарошек потому что вчера закончились и липтон";
            zametka.Date = new DateTime(2022, 10, 14);

            Zametka zametka2 = new Zametka();
            zametka2.Name = "Жоска поесть макарошек";
            zametka2.Description = "Поесть купленные макарошки";
            zametka2.Date = new DateTime(2022, 10, 14);

            Zametka[] allNotes = new Zametka[] { zametka, zametka2 };



            DateTime date = new DateTime(2022, 10, 14);
            Console.Clear();
            int position = 1;
            date14menu(allNotes);
            while (true)
            {
                ConsoleKeyInfo Key = Console.ReadKey();
                if (Key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    date14viborCycle(position, allNotes);
                }
                else if (Key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    date14viborCycle(position, allNotes);
                }
                else if (Key.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    data15vibor();
                }
                else if (Key.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    data13vibor();
                }
                else if (Key.Key == ConsoleKey.Enter)
                {
                    if (position == 1)
                    {
                        vivod(allNotes[0], 14);
                    }
                    else if (position == 2)
                    {
                        vivod(allNotes[1], 14);
                    }
                }

            }

            static void date14viborCycle(int position, Zametka[] allNotes)
            {
                Console.Clear();
                date14menu(allNotes);
                Console.SetCursorPosition(0, position);
                Console.WriteLine("-->");
            }
        }
        static void data15vibor()
        {
            Zametka zametka = new Zametka();
            zametka.Name = "Выпить";
            zametka.Description = "Липтона выпить";
            zametka.Date = new DateTime(2022, 10, 15);

            Zametka zametka2 = new Zametka();
            zametka2.Name = "Сделать чето";
            zametka2.Description = "Придумать че сделать и сделать";
            zametka2.Date = new DateTime(2022, 10, 15);

            Zametka[] allNotes = new Zametka[] { zametka, zametka2 };



            DateTime date = new DateTime(2022, 10, 15);
            int data = 15;
            Console.Clear();
            int position = 1;
            date15menu(allNotes);
            while (true)
            {
                ConsoleKeyInfo Key = Console.ReadKey();
                if (Key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    date15viborCycle(position, allNotes);
                }
                else if (Key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    date15viborCycle(position, allNotes);
                }
                else if (Key.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    data14vibor();
                }
                else if (Key.Key == ConsoleKey.Enter)
                {
                    if (position == 1)
                    {
                        vivod(allNotes[0], data);
                    }
                    else if (position == 2)
                    {
                        vivod(allNotes[1], data);
                    }
                }

            }

            static void date15viborCycle(int position, Zametka[] allNotes)
            {
                Console.Clear();
                date15menu(allNotes);
                Console.SetCursorPosition(0, position);
                Console.WriteLine("-->");
            }
        }
        static void date13menu(Zametka[] allNotes)
        {
            Console.WriteLine("   Выбрана дата 13.10.2022");
            for (int i = 0; i < allNotes.Length; i++)
            {
                Console.WriteLine("   " + allNotes[i].Name);
            }
        }
        static void date14menu(Zametka[] allNotes)
        {
            {
                Console.WriteLine("   Выбрана дата 14.10.2022");
                for (int i = 0; i < allNotes.Length; i++)
                {
                    Console.WriteLine("   " + allNotes[i].Name);
                }
            }
        }
        static void date15menu(Zametka[] allNotes)
        {
            {
                Console.WriteLine("   Выбрана дата 15.10.2022");
                for (int i = 0; i < allNotes.Length; i++)
                {
                    Console.WriteLine("   " + allNotes[i].Name);
                }
            }
        }
        static void vivod(Zametka zametka, int date)
        {

            
         Console.Clear();
         Console.WriteLine(zametka.Name);
         Console.WriteLine(zametka.Description);
         Console.WriteLine(zametka.Date);
         ConsoleKeyInfo Key = Console.ReadKey();
            if (Key.Key == ConsoleKey.Escape)
            {
                if (date == 13)
                {
                    data13vibor();
                }
                if (date == 14)
                {
                    data14vibor();
                }
                if (date == 15)
                {
                    data15vibor();
                }
            }
        }
    }
}