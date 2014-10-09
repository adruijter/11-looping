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
            /*  Voorbeeld van een do.. while lus */
            ConsoleKeyInfo cki;
            bool characterFound = false;           
            
            Console.WriteLine("Voer een toetsenbord letter in!");
            Console.WriteLine("+++++++++++++++++++++++++++++++");

            do
            {
                
                if (characterFound)
                Console.WriteLine("\nU heeft niet de goede toets ingedrukt. \nProbeer nog eens!");
               
                Console.Write("\nNieuwe letter: ");
                cki = Console.ReadKey();
                Console.WriteLine("\n++++++++++++++++");

                // Als de invoer fout is (niet B) dan wordt characterFound true
                characterFound = cki.KeyChar != (char)ConsoleKey.B;

            } while(characterFound);


            Console.WriteLine("\nGefeliciteerd! \nU heeft de goede letter ingevoerd");
            Console.Write("De letter was: {0}", cki.KeyChar.ToString());

            Console.ReadLine();
        }
    }
}
