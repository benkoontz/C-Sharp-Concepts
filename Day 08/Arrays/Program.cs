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

            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42};
                                 //0  1  2   3   4    5
            Console.WriteLine(luckyNumbers[0]); // prints 4

            luckyNumbers[1] = 900;

            Console.WriteLine(luckyNumbers[1]); // prints 900 instead of 8

            string[] friends = new string[10]; // array holds 10 values
            friends[0] = "hailey";
            friends[1] = "jess";
            foreach (var i in friends)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
