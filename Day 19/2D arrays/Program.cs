using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] numberGrid = {
                {1, 2 },
                {3, 4 },
                {5, 5 }

            };

            Console.WriteLine(numberGrid[0 , 1]); // prints 2
            Console.WriteLine(numberGrid[1, 0]); // prints 3

            Console.ReadLine();


        }
    }
}
