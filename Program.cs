using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace recap_van_0
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey keyboard;
            int cursorspot = 1;
            int choice = 0;
            do
            {
                Console.Clear();
                choice = SelectMenu("Datatypes",
                    "Logische structuren",
                    "Math en Random",
                    "Arrays",
                    "Dates en Stringfuncties ",
                    "Bestanden",
                    "Methodes",
                    "exit");

                switch (choice)
                {
                    case 1:
                        Oefening1();
                        break;
                    case 2:

                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    default:
                        break;
                }

                Console.ReadLine();
            } while (choice != 8);
        }

        private static void Oefening1()
        {
            bool boolean = true;
            int integer = 1;
            double doub = 2;
            char character = 'a';
            string str = "hallo";

            Console.WriteLine("bool boolean = " +  boolean + "\n"+
            "int integer = "+ integer + "\n"+
            "double doub = " + doub + "\n" + 
            "char character = " + character + "\n" +
            "string str = " + str +"\n"
            );

            
            Console.WriteLine("\t Een integer deelt door een double:{0}", "Cannot implicitly convert 'double' to 'int'");
            Console.WriteLine("\t Een character optelt met een integer: {0}", "Cannot implicitly convert 'int' to 'chr'");
            Console.WriteLine("\t Een character optelt met een character:{0}",  character += character);
            Console.WriteLine($"\t Een string optelet met een andere string: {str += str}");
            Console.WriteLine($"\t Een boolean displayed in een string: {boolean}");
            Console.WriteLine();

            byte bite = 1;
            short shorty = 2;
            long lenthy = 3;
            float drifting = 4;
            decimal decim = 5;

            Console.WriteLine("byte bite = " + bite + "\n" +
            "short shorty = " + shorty + "\n" +
            "long lenthy = " + lenthy + "\n" +
            "float drifting = " + drifting+ "\n" +
            "decimal decim = " + decim + "\n"
            );

            Console.WriteLine("\t Wat gebeurt er als je 300 optelt bij een byte?{0}", "Constant Value '300' cannot be converted too 'byte'");
            Console.WriteLine("\t Wanneer zou je een decimal gebruiken over een double? {0}", "waneer het over geld gaat");
            Console.WriteLine("\t Waarom zou je ooit een byte over een integer kiezen?{0}", "waneer je weet dat het getal nooit hoger zal gaan dan 255 want het neemt minder geheugen dan");
            Console.WriteLine("\t Handige link is https://www.tutorialsteacher.com/csharp/csharp-data-types");
            Console.WriteLine();
            Console.WriteLine("\t S = signed and U = unsigned. de sign gaat over het gebruik van -/+ dus met unsigned variabelen kan je niet negatief gaan");
            Console.WriteLine();

        }

        static int SelectMenu(params string[] menu)
        {
            Console.CursorVisible = false;
            Console.Clear();

            int selection = 1;
            bool selected = false;

            ConsoleColor selectionForeground = Console.BackgroundColor;
            ConsoleColor selectionBackground = Console.ForegroundColor;

            while (!selected)
            {
                int teller = 0;
                foreach (var item in menu)
                {
                    teller++;

                    if (selection == teller)
                    {
                        Console.ForegroundColor = selectionForeground;
                        Console.BackgroundColor = selectionBackground;
                    }

                    Console.WriteLine(teller + "." + item);
                    Console.ResetColor();
                }

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        selection--;
                        break;
                    case ConsoleKey.DownArrow:
                        selection++;
                        break;
                    case ConsoleKey.Enter:
                        selected = true;
                        break;
                }

                selection = Math.Min(Math.Max(selection, 1), menu.Length);
                Console.SetCursorPosition(0, 0);
            }
            Console.Clear();
            Console.CursorVisible = true;
            return selection;
        }
    }
}

