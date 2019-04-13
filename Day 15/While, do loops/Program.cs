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

            int index = 1;
            int ben = 0;

            while(index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

            Console.WriteLine("\n");

            do
            {
                Console.WriteLine(ben);
                ben++;
            } while (ben <= 5);

            Console.ReadLine();

      
        }
    }
}
