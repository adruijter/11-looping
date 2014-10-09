using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Maak een for-loop die de getallen van 0 t/m 10
             * onder elkaar afbeeld.
             */
            string extraTekst = "Goed Hoor!";
            ushort breakPoint = 3;

            Console.WriteLine("Dit is een voorbeeld van het gebruik van break in een loop");
            Console.WriteLine("-----------------------------------------------------------\n");

            for (ushort i = 0; i <= 10; i++)
            {
                if (i != breakPoint)
                {
                    Console.WriteLine("De variabele i heeft de waarde: {0} {1}", i, extraTekst);
                }
                else
                {
                    Console.WriteLine("We hebben het getal gevonden namelijk: {0}", i);
                    break;
                }
            }

            Console.WriteLine("Dit is een voorbeeld van het gebruik van continue in een loop");
            Console.WriteLine("-----------------------------------------------------------\n");

            for (ushort i = 0; i <= 10; i++)
            {
                int evenGetal = i * 2;
                if (evenGetal <= 10)
                    Console.WriteLine("Dit is een even getal onder de tien {0}", evenGetal);
                else
                    break;
            }

            Console.ReadLine();
        }
    }
}
