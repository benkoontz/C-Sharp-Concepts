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
            Book book1 = new Book();
            book1.Title = "bens book";
            book1.author = "ben";
            book1.pages = 300;

            Book book2 = new Book();
            book2.Title = "bens book 2";
            book2.author = "ben 2";
            book2.pages = 600;

            Console.WriteLine(book1.Title);
            Console.WriteLine(book1.pages);

            Console.WriteLine(book2.Title);
            Console.WriteLine(book2.pages);

            Console.ReadLine();


        }
    }
}
