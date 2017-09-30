using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random NumberGenerator = new Random();

            int num01 = NumberGenerator.Next(1, 11);
            int num02 = NumberGenerator.Next(1, 11);

            Console.WriteLine("What is " + num01 + "times" + num02 + "?");

            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == num01 * num02)
            {
                int responseIndex = NumberGenerator.Next(1, 4);

                switch (responseIndex)
                {
                    case 1:
                    Console.WriteLine("Correct, Well Done!");
                        break;

                    case 2:
                        Console.WriteLine("Bingo!");
                        break;

                    default:
                        Console.WriteLine("wowowow!");
                        break;
                

                }
            }
           else
            {
                int diff = Math.Abs(answer - (num01 * num02));
                if (diff == 1)
                {
                    Console.WriteLine("So close!");
                }
                else if (diff <= 10)
                {
                    Console.WriteLine("You can do better!!");
                }
                else
                {
                    Console.WriteLine("Not even close!!");
                }
            }

            Console.ReadKey();
        }

    }
}
