using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            Random NumGen = new Random();
            // default to 0, because we start out with not having attempted anything
            // attempt stores single attempt
            int numberOfAttempts = 0;
            int attempt = 0;

            while (attempt != 6)
            {
                attempt = NumGen.Next(1, 7);
                Console.WriteLine("You Rolled" + attempt + ".");
                numberOfAttempts++;
            }
            Console.WriteLine("It took Tom" + numberOfAttempts + "attempts to roll a 6.");

            Console.ReadKey();
        }
    }
}
