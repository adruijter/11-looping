using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Voorbeeld van een do.. while lus
             */
            ConsoleKeyInfo cki;
            Console.WriteLine("Voer een toetsenbord letter in!");
            Console.WriteLine("+++++++++++++++++++++++++++++++");
            do
            {
                Console.WriteLine("\nU heeft niet de goede toets ingedrukt. \nProbeer nog eens!");
                Console.Write("Nieuwe letter: ");
                cki = Console.ReadKey();
                Console.WriteLine("\n++++++++++++++++++++++++++++++++");
                

            } while( cki.KeyChar != (char)ConsoleKey.H);
            Console.WriteLine("\nGefeliciteerd! \nU heeft de goede letter ingevoerd");
            Console.Write("De letter was: {0}", cki.KeyChar.ToString());

            Console.ReadLine();
        }
    }
}
