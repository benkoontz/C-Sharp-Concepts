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

            string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();



            Console.WriteLine("Rose are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.Write("I Love " + celebrity);

          //  "Outputs:
          // Rose are red
          // violetes are blue
          // I like Angelina Jolie and that one person from that two and a half men show... uhhh i forgot her name but she was married to Alan.."

            Console.ReadLine();
        }
    }
}
