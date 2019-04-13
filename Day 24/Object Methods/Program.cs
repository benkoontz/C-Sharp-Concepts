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
            Student student1 = new Student("ben", "c.s.", 3.4);


            Console.WriteLine(student1.HasHonors());

            Console.ReadLine();


        }

        
    }
}
