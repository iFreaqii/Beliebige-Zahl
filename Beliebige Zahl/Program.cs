﻿using System;

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
            double gerade;
            
            string weitermachen = "";

            do
            {
                Console.WriteLine("Bitte geben Sie eine beliebige Zahl ein.");
                zahl = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ihre Zahl lautet: {0}", zahl);

                gerade = zahl % 2;

                if ((zahl < 0) && (gerade ==0))
                {
                    Console.WriteLine("Ihre eingegebene Zahl {0} ist kleiner als 0 und gerade", zahl);
                }

                else if ((zahl < 0) && (gerade != 0))
                {
                    Console.WriteLine("Ihre eingegebene Zahl {0} ist kleiner als 0 und ungerade", zahl);
                }
                       
                else if ((zahl > 0) && (gerade==0))
                {                   
                    Console.WriteLine("Ihre eingegebene Zahl {0} ist größer als 0 und gerade", zahl);
                }

                else if((zahl > 0) && (gerade != 0))
                {
                    Console.WriteLine("Ihre eingegebene Zahl {0} ist größer als 0 und ungerade", zahl);
                }

                else if(zahl == 0)
                {
                    Console.WriteLine("Sie haben eine 0 eingegeben.");
                }
                
                else
                {
                    Console.WriteLine("Ein Fehler ist aufgetreten!");
                }

                Console.WriteLine("\nGeben Sie bitte (j) ein, um eine weitere Zahl einzugeben!");
                weitermachen = Console.ReadLine();
            }
            while (weitermachen != "n");
        }
    }
}
