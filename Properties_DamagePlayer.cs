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
            private int _health = 100; // health starts at default 100 ... every player starts with 100 health
            public int health // variable to be calculated
            {
                get
                {
                    return _health; // variable to be calculated
                }
            }

            public void damage(int _dmg) // damage takes the argument of _dmg ... so what's dmg?
            {
                _health -= _dmg; // our real-time health, which starts at 100 is equal to 100 minus the value for _dmg
            }
        }
        static void Main(string[] args)
        {

            Player tom = new Player(); // here is our instance of a player  ... tom is a local variable of the class player
            tom.damage(30); // variable.method
            Console.WriteLine(tom.health); // write tom's health after tom.damage(30)

            Console.ReadKey();
        }
    }
}
