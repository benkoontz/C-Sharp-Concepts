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
            try
            {
                Console.WriteLine("enter a number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter another number");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message); // prints the divide by zero error
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally // code always gets executed, it's also optionally
            {
                // complete
            }
            



            Console.ReadLine();


        }
    }
}
