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
            Movie movie1 = new Movie("ben's life", "ben as the actor", "PG");

            Console.WriteLine(movie1.Rating);


            Console.ReadLine();

        }

        
    }
}
