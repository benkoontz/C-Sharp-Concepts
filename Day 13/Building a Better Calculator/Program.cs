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

            Console.WriteLine("enter a number");
            double num1 = Convert.ToDouble(Console.ReadLine()); // since readline is for strings

            Console.WriteLine("enter operator: ");
            string op = Console.ReadLine();

            Console.WriteLine("enter another number");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.Write(num1 + num2);
            }
            else if (op == "-")
            {
                Console.Write(num1 - num2);
            }
            else if (op == "/")
            {
                Console.Write(num1 / num2);
            }
            else if (op == "*")
            {
                Console.Write(num1 * num2);
            }
            else
            {
                Console.WriteLine("invalid operator");
            }

            Console.ReadLine();
        }
    }
}
