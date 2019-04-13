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

            // static is information about the whole class

            Song song1 = new Song("ben's song", "ben", 100);
            Song song2 = new Song("ben's song 2", "ben 2", 100);

            Console.WriteLine(Song.songCount); // prints 2



            Console.ReadLine();

        }

        
    }
}
