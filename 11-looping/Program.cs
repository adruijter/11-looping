using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11_looping
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Maak een raadspelletje waarbij de speler een getal moet raden onder de 25.
             * je mag natuurlijk ook een ander getal nemen. De speler geeft ook op hoeveel keer
             * hij /zij mag raden naar het getal.
             * Als het getal niet correct is geraden mag de persoon het nog een beperkt aantal
             * keren proberen. Na dit aantal stopt het spel.
             */            
            short teRadenGetal = 13;
            short getalVanSpeler;
            short aantalMalenGokken;

            Random random = new Random();
            double willekeurigGetal = random.NextDouble() * 25;
            short afgerondGetal = (short)Math.Round(willekeurigGetal);
            string input;

            Console.WriteLine("Voor dit spel moet u een getal raden tussen de 0 en 25\n" +
                              "U mag nu opgeven hoeveel keer u mag raden\n");

            Console.Write("Geef op hoeveel keer u mag raden: ");
            
            // Stop de ingevoerde waarde in een string genaamd input
            input  =  Console.ReadLine();

            // Cast de string naar een short variabele
            aantalMalenGokken = Convert.ToInt16(input);
            
            short i = 0;

            while (i++ < aantalMalenGokken)
            {
                Console.WriteLine("Geef een getal tussen de 0 en 25\n");

                // Stop de ingevoerde waarde in een string genaamd input
                input = Console.ReadLine();

                getalVanSpeler = Convert.ToInt16(input);

                if (getalVanSpeler != teRadenGetal)
                {
                    Console.WriteLine("++++++++++++++++++++++++");
                    Console.WriteLine("U heeft het getal niet goed geraden.\nU heeft {0} ingevoerd," +
                                      "\nGeef opnieuw een getal tussen de 0 en de 25\n", getalVanSpeler);
                }
                else
                {
                    Console.WriteLine("Goed geraden");
                    break;
                }
            }

            Console.ReadLine();  
        }
    }
}
