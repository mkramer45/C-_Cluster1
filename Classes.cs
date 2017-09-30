using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Animal
    {
        public string name = "Spotty";
        public int age = 6;
        public float happiness = .05f;

        public void print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("happiness: " + happiness);
            Console.WriteLine("age: " + age);
        }

        // private = data can only be accessed within class
        // public = cna be referenced outside of class, as long as referenced
        // static = not bound to instance of class, but shared among instances
        // when don't specify class, defaults to private
        // closed parenthesis () means "takes no arguments"
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new ConsoleApplication22.Animal();
            dog.print();

            Console.ReadKey();
        }
    }
}
