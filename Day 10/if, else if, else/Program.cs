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
            bool isMale = true;
            bool isTall = false;

            if(isMale && isTall)
            {
                Console.WriteLine("you are a tale male");
            }
            else if(isMale || isTall)
            {
                Console.WriteLine("you are either a male or tall");
            }
            else if (!isMale)
            {
                Console.WriteLine("you are female");
            }
            else
            {
                Console.WriteLine("you are either not male or not tall or both");
            }

            Console.ReadLine();
        }
    }
}
