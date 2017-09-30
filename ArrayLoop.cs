using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            /// number inside array indicates how many numbers in array
            int[] numbers = new int[5];
            numbers[0] = 12;
            numbers[1] = 3;
            numbers[2] = 5;

           for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + ", ");
            }

            Console.ReadKey();
        }
    }
}
