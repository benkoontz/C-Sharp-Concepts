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

            int [] luckyNumbers = { 4, 2, 3, 1, 5};

            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i); // prints 1 through 5
            }

            Console.WriteLine("\n");

            for(int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }

            Console.ReadLine();
      
        }
    }
}
