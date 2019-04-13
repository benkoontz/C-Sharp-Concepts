using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Book
    {
        // class attributes (blueprint)
        public string Title;
        public string author;
        public int pages;

        public Book(string aTitle, string aAuthor, int aPages)
        {
            Title = aTitle; // title of the object is equal to the title they passed in
            author = aAuthor;
            pages = aPages;
        }

    }
}
