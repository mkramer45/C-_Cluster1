using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                Random NumberGenerator = new Random ();

                double num01 = NumberGenerator.Next(1,10);
                double num02 = NumberGenerator.Next(1, 10);

                Console.WriteLine("What is " + num01 + " divided by " + num02 + "?" );

                double answer = Convert.ToDouble(Console.ReadLine());

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
}
