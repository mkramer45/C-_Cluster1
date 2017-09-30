using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateGrid();
            Console.ReadKey();
        }
        public static void CreateGrid ()
        {
            int width = 5;
            int height = 5;
            int[,] grid = new int[5, 5];
            grid[2, 3] = 3;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Console.Write(grid[x, y] + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
