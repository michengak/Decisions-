using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            Console.WriteLine("Bob's Big Giveaway");
            Console.WriteLine("Choose a door: 1, 2, or 3: ");
            string userVAlue = Console.ReadLine();

            string message = " ";

            if (userVAlue == "1")
            {
                 message = "You won a new car!";
            
            }
            else if (userVAlue == "2")
            {
                 message = "You won a new boat!";
            
            }
            else if (userVAlue == "3")
            {
                 message = "You won a new cat!";
            }
            else
            {
                 message = "Sorry, we didn't understand.";
    
            }

            Console.WriteLine(message);
            Console.ReadLine();

         */

            Console.WriteLine("Bob's Big Giveaway");
            Console.WriteLine("Choose a door: 1, 2, or 3: ");
            string userVAlue = Console.ReadLine();

            string message = (userVAlue == "1") ? "boat" : "strand of lint";

            //Console.WriteLine("You won a ");
            //Console.WriteLine(message);
            //Console.Write(".");

            // replacement of the three consoles Write with ==>

            // Console.WriteLine("You won a {0}.", message);

            //same idea with two replacement.

            Console.WriteLine("You entered: {0}, therefore you won a {1}.", userVAlue, message);

            Console.ReadLine();


        }   


    }


}
