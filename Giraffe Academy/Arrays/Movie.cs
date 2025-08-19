using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arrays
{
    public class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }

        private string rating;
        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
                
            }
            
            
        }

        public Movie(string title, string director, string rating)
        {
            Title = title;
            Director = director;
            Rating = rating;
        }
    }
}