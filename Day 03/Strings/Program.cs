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
            string phrase = "girrafe animal";
            Console.WriteLine("Hello \n Ben");

            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.Contains("girr")); // returns true
            Console.WriteLine(phrase[5]); // prints f
            Console.WriteLine(phrase.IndexOf("ir")); // tells location which is 1
            Console.WriteLine(phrase.Substring(8)); // prints animal
            Console.WriteLine(phrase.Substring(4, 2)); // prints af


            Console.ReadLine();
        }
    }
}
