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
            Console.WriteLine("Bob's Big Giveaway");
            Console.WriteLine("Choose a door: 1, 2, or 3: ");
            string userVAlue = Console.ReadLine();

            if (userVAlue == "1")
            {
                string message = "You won a new car!";
                Console.WriteLine(message);

            }
            Console.ReadLine();

        }   



    }
}
