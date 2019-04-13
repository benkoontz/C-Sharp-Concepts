using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Movie
    {
        // class attributes (blueprint)
        public string title;
        public string actor;
        private string rating;

        public Movie(string title, string actor, string rating)
        {
            this.title = title; // title of the object is equal to the title they passed in
            this.actor = actor;
            this.rating = rating;
        }

        public string Rating
        {
            get { return rating; }
            set {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R")
                    rating = value;

                else
                {
                    rating = "NR";
                }

            }
        }


    }
}
