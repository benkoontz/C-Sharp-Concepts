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
            int cubedNumber = cube(6);
            Console.WriteLine(cube(5)); // prints 125
            Console.WriteLine(cubedNumber); // prints 216

            Console.ReadLine();
        }

        static int cube(int num)
        {
            int result = num * num * num;
            return result;

        }
    }
}
