using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ", ");
                }
            }
            // explaination
            //for loop is a way to do something certain # times
            // first i = starting number ... start at 1
            // second, as long as i is equal to or LESS than 10, do the loop
            // last, positive increment of the value of i, so in this case 1
            // i % 2 = if i is evenly divded by 0 aka an EVEN ... if divided by odd, then we will have decimals (making it an odd)


            Console.ReadKey();
        }
    }
}
