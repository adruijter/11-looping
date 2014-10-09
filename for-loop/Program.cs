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


            for (ushort i = 0; i <= 10; i++)
            {
                Console.WriteLine("De variabele i heeft de waarde: {0} {1}", i, extraTekst);
            }
            
            Console.ReadLine();
        }
    }
}
