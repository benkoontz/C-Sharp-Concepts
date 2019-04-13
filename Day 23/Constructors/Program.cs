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
            Book book1 = new Book("ben's book", "ben", 300);

            Book book2 = new Book("ben's book 2", "ben", 600);

            Console.WriteLine(book2.Title);

            Console.ReadLine();


        }
    }
}
