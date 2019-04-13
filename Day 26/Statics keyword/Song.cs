using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Song
    {
        // class attributes (blueprint)
        public string title;
        public string artist;
        public double duration;
        public static int songCount;

        public Song(string title, string artist, double duration)
        {
            this.title = title; // title of the object is equal to the title they passed in
            this.artist = artist;
            this.duration = duration;
            songCount++;
        }


    }
}
