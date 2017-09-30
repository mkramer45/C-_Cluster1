using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Old Are You?");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("Thats too bad kiddo!");

            }

            else if (age == 18)
            {
                Console.WriteLine("Right on the money");

            }

            else
                Console.WriteLine("Right this way!");

        }
    }
}
