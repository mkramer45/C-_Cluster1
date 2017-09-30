using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Program
    {
        /// inheritence: deriving classes from other classes
        class animal  //// this is our base class
        {
            public string name;
            public int age;
            public float happiness;

            public void PrintBase ()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age :" + age);
                Console.WriteLine("Happiness :" + happiness);
            }
        }

        // this will be our derived class #1 ... inheriting from base
        class dog : animal
        {
            public int spotcount;
            public void bark ()
            {
                Console.WriteLine("Woof!");
            }
        }

        // derived class #1 ... inheriting from base
        class cat : animal
        {
            public float cuteness;
            public void meow()
            {
                Console.WriteLine("Meow!");
            }
        }


        static void Main(string[] args)
        {
            dog spotty = new dog();
            spotty.name = "Spotty";
            spotty.age = 4;
            spotty.happiness = 0.6f;
            spotty.spotcount = 25;
            spotty.PrintBase ();
            spotty.bark();

            Console.ReadKey();
            
        }
    }
}
