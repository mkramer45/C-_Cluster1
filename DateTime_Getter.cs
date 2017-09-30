using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
{
    // properties aka getters and setters
    // allows us how to control how to access and change a variable
    // datetime class
    // DateTime.Now is an example of a getter ... it gets the datetime value of whenever asked to get
    class Program
    {
        static void Main(string[] args)
        {
            DateTime curTime = DateTime.Now; /// read only property, cannot add an argument to DateTime.Now 
            Console.WriteLine(curTime);

            Console.ReadKey ();

        }
    }
}
