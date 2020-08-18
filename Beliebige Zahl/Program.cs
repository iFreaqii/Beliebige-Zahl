using System;

/// <summary>
/// Nico Bauer
/// IS218
/// AWE
/// Eine beliebige Zahl wird eingelesen. Bestimme, ob die Zahl größer, gleich oder kleiner Null ist. Gib weiterhin an, ob die Zahl gerade oder ungerade ist! (Hinweis: modulo-Operator %)
/// </summary>

namespace Beliebige_Zahl
{
    class Program
    {
        static void Main(string[] args)
        {
            double zahl;
            bool groeßer0;
            bool gleich0;
            bool gerade;
            string weitermachen = "";

            do
            {
                Console.WriteLine("Bitte geben Sie eine beliebige Zahl ein.");
                zahl = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ihre Zahl lautet: {0}", zahl);

                groeßer0 = zahl > 0 ? false : zahl < 0 ? false : true;
                gleich0 = zahl > 0 ? true : false;

                if (!gleich0)
                {
                    gerade = zahl % 2 == 0 ? true : false;

                    if (groeßer0)
                    {
                        Console.WriteLine("Der angegebene Wert ist groesser als Null.\n");
                        if (gerade)
                        {
                            Console.WriteLine("Der angegebene Wert ist gerade.\n");
                        }
                        else
                        {
                            Console.WriteLine("Der angegebene Wert ist ungerade.\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Der angegebene Wert ist kleiner als Null.\n");
                        if (gerade)
                        {
                            Console.WriteLine("Der angegebene Wert ist gerade.\n");
                        }
                        else
                        {
                            Console.WriteLine("Der angegebene Wert ist ungerade.\n");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Der angegebene Wert ist Null.\n");
                }

                Console.WriteLine("\nGeben Sie bitte (j) ein, um eine weitere Zahl einzugeben!");
                weitermachen = Console.ReadLine();
            }
            while (weitermachen != "n");
        }
    }
}
