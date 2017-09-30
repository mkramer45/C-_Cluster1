using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num01 = 16;
            int num02 = 4;

            Console.WriteLine("What is " + num01 + " divided by " + num02);

            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == num01 / num02)
            {
                Console.WriteLine(" Good Job Buddy! ");
            }

            else
            {
                Console.WriteLine("Wrong!");
            }

            Console.ReadKey();
             
        }
    }
}
