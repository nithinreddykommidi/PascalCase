using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Movies
    {

        public string name;
        public string studio;
        private string rating;
        public Movies(string aName,string aStudio, string aRating) 
        {
            name= aName;
            studio= aStudio;
            rating= aRating;
        }

        public string Rating
        {
            get { return rating; }
            set { 
                if(value == "PG-13" || value == "R")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }

        }
    }
}
