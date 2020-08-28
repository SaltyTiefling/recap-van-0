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
                Console.WriteLine("kies je oefening:");
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
                        Oefening2();
                        break;
                    case 3:
                        Oefening3();
                        break;
                    case 4:
                        Oefening4();
                        break;
                    case 5:
                        Oefening5();
                        break;
                    case 6:
                        Oefening6();
                        break;
                    case 7:
                        Oefening7();
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
            double doub = 2.2;
            char character = 'a';
            string str = "hallo";

            Console.WriteLine("bool boolean = " + boolean + "\n" +
            "int integer = " + integer + "\n" +
            "double doub = " + doub + "\n" +
            "char character = " + character + "\n" +
            "string str = " + str + "\n"
            );


            Console.WriteLine("\t Een integer deelt door een double:{0}", "Cannot implicitly convert 'double' to 'int'");
            Console.WriteLine("\t Een character optelt met een integer: {0}", "Cannot implicitly convert 'int' to 'chr'");
            Console.WriteLine("\t Een character optelt met een character:{0}", character += character);
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
            "float drifting = " + drifting + "\n" +
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
        private static void Oefening2()
        {
            bool boolean = true;
            int integer = 1;
            double doub = 15.5;
            char character = 'a';
            string str = "hallo";

            Console.WriteLine("bool boolean = " + boolean + "\n" +
            "int integer = " + integer + "\n" +
            "double doub = " + doub + "\n" +
            "char character = " + character + "\n" +
            "string str = " + str + "\n"
            );

            Console.WriteLine("\t If((!a && (b != c)) || (b == c || !(d >= c))) { ... }");
            Console.WriteLine("\t Begrijp jij exact wat hier gebeurd?{0}",
                "als ('a' valse is en b niet gelijk is aan c) of ('b' is gelijk aan 'c') of waneer ('d' kleiner is dan 'c')) dan loopt hij het programma");
            Console.WriteLine("\t Wanneer gebruik je else, wanneer else if? Else if gebruik je enkel als je verder wilt definieren en een andere sidecase maken");
            Console.WriteLine();
            Console.WriteLine("\t Ken jij het verschil tussen while(expression) { ... } en do { ... } while(expression) nog? " +
                "Ja, het verschil is dat \"do while\" het programma minstens een keer door gaat voor het de expressie bekijkt");
            Console.WriteLine("\t Wat doet het keywoord break in een loop? het breekt de loop en stopt het");
            Console.WriteLine();
            Console.WriteLine("Maak een loop in je programma dat je integer variabel optelt en noteert in de console tot dat deze groter is dan de double. Als het groter start dan de double, telt hij dus nooit op. Denk na over welke loop je hier gebruikt.");
            for (; !(integer > doub); integer++)
            {
                Console.Write(integer + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Ga na hoe een for loop werkt. for(statement 1; statement 2; statement 3)");
            Console.WriteLine("\t Weet jij exact wat er in statement 1, 2, en 3 moet staan?\n" +
                "\t\t1: je defineerd je teller\n" +
                "\t\t2: je geeft je statement voor wanneer de loop moet stoppen\n" +
                "\t\t3: hier geef je in wat moet gebeuren elke keer hij loopt bv. te teller optellen");
            Console.WriteLine("\t Is elk statement verplicht ? Welke wel en welke niet ? neen geen van de waarden zijn verplicht maar pas of sinds je snel oneindige loops kan creeren");
            Console.WriteLine("\t Hoe kan je uit je for-loop geraken als je conditie nooit FALSE gaat zijn? als je een 'break' gebruikt");
            Console.WriteLine("\t Kan je meerdere variables initializeren/itereren in een for-loop? Zo ja: Hoe exact? door bv. (int i, j, k = 0) te gebruiken in statement 1");
            Console.WriteLine();
            Console.WriteLine("Maak een for-loop dat tot 10 telt en het noteert in de console.");
            Console.WriteLine("Maak een geneste for-loop dat de tafel van 10 noteert in de console.");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"tafel van {i}:");
                for (int j = 0; j <= 10; j++)
                {
                    Console.WriteLine($"{i} X {j} = {i * j}");

                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t Wat gebeurt er als je meerdere cases onder elkaar zet? hij vloeit door tot hij aan een break komt");
            Console.WriteLine("\t Wat gebeurt er als je een break weg laat? je krijgt de foutmelding \"control cannot fall through from one case to the next\"");
            Console.WriteLine("\t Wat gebeurt er als je default vanboven zet in plaats van vanonder? niets dat werkt");

            switch (integer)
            {
                default:
                    break;
                case 1:
                case 2:
                    break;
                    //case 3:
                    //    Console.WriteLine("test");
                    //case 4:
                    //    break;
            }

            Console.WriteLine("Maak een menutje waar je kan kiezen tussen optellen, aftrekken, vermenigvuldigen, delen, modulo en waar je dan twee getallen kan invullen om deze operatie uit te voeren.");
            bool correct = false;
            double getal1 = 0, getal2 = 0;
            byte keuze = 0;
            while (keuze != 6)
            {

                if ((keuze = (byte)SelectMenu("optellen", "aftrekken", "vermenigvuldigen", "delen", "modulo", "Exit")) == 6) break;

                do
                {
                    Console.Write("geef getal 1 in:");
                    try
                    {
                        getal1 = double.Parse(Console.ReadLine());
                        correct = true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("geef geldig getal in.");
                    }

                } while (!correct);
                correct = false;
                do
                {
                    Console.Write("geef getal 2 in:");
                    try
                    {
                        getal2 = double.Parse(Console.ReadLine());
                        correct = true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("geef geldig getal in.");
                    }

                } while (!correct);



                ConsoleColor selectionForeground = Console.BackgroundColor;
                ConsoleColor selectionBackground = Console.ForegroundColor;

                Console.ForegroundColor = selectionForeground;
                Console.BackgroundColor = selectionBackground;

                switch (keuze)
                {
                    case 1:
                        Console.WriteLine($"{getal1} + {getal2} = {getal1 + getal2}");
                        break;
                    case 2:
                        Console.WriteLine($"{getal1} - {getal2} = {getal1 - getal2}");
                        break;
                    case 3:
                        Console.WriteLine($"{getal1} * {getal2} = {getal1 * getal2}");
                        break;
                    case 4:
                        Console.WriteLine($"{getal1} / {getal2} = {getal1 / getal2}");
                        break;
                    case 5:
                        Console.WriteLine($"{getal1} % {getal2} = {getal1 % getal2}");
                        break;
                }
                Console.ResetColor();
            }
            Console.WriteLine();


            Console.ReadLine();
        }

        private static void Oefening3()
        {
            throw new NotImplementedException();
        }
        private static void Oefening4()
        {
            throw new NotImplementedException();
        }
        private static void Oefening5()
        {
            throw new NotImplementedException();
        }
        private static void Oefening6()
        {
            throw new NotImplementedException();
        }
        private static void Oefening7()
        {
            throw new NotImplementedException();
        }

        static int SelectMenu(params string[] menu)
        {

            Console.CursorVisible = false;

            int selection = 1;
            bool selected = false;
            int cursorTop = Console.CursorTop;

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
                Console.SetCursorPosition(0, cursorTop);
            }
            Console.SetCursorPosition(0, cursorTop + menu.Length - 1);
            Console.CursorVisible = true;
            return selection;
        }
    }
}

