using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game");

            Console.Write("What's your first name?");
            string firstname = Console.ReadLine();

            Console.Write("What's your last name?");
            string lastname = Console.ReadLine();

            Console.Write("In what city were you born?");
            string city = Console.ReadLine();

            Console.Write("Results: ");
            ReverseString(firstname);
            ReverseString(lastname);
            ReverseString(city);

            Console.ReadLine();
        }

        private static void ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            foreach (char item in messageArray)

            {
                Console.Write(item);

            }
        }
    }
}
