using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Add(1, 0);
            if (result > 10)
            {
                Console.WriteLine("Result is larger than 10!");
            }
            else
            {
                Console.WriteLine("Result is smaller or equal to 10!");
            }

            Console.ReadKey();
            // methods: way to group together code, easier to read
            // methods are a useful way to re-use code, organizing, making code more flexible
            // methods are also known as function ... interchange-able
            // By calling the method above on line 13, it executes the code where the method is defined below
        }
        public static int Add (int num01, int num02)
        {
            return num01 + num02;
        }
    }
} 
