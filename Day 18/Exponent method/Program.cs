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
            Console.WriteLine(GetPow(2, 3)); // prints 8
            Console.ReadLine();
      
        }

        static int GetPow(int baseNum, int PowNum)
        {
            int result = 1;

            for(int i = 0; i < PowNum; i++)
            {
                result = result * baseNum;
            }
            return result;
        }
    }
}
