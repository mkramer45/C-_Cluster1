using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication27
{
    class Program
    {
        class Player /// lets create a class for player, containing all info for player, health + name + country + etc
        {
            public int health = 100; /// variable of health, lets set it equal to 100
        }
        static void Main(string[] args)
        {
            /// lets create an instance of a player

            Player tom = new Player();
            Console.WriteLine (tom.health);
            tom.health = 40;
            Console.WriteLine (tom.health);

            Console.ReadKey();
        }
    }
}
