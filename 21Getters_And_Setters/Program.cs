using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Getters_And_Setters
{
  
        internal class Program
        {
            static void Main(string[] args)
            {
                Movie movie1 = new Movie("Titanic", "Jim", "PG-13");
                Movie movie2 = new Movie("Unreleased", "Kim", "PG");

                Console.WriteLine(movie1.Rating);

                // Console.ReadLine(); // You may choose to uncomment this if you want to pause the console before it closes.
            }
        }

        class Movie
        {
            public string title;
            public string director;
            private string rating;

            // Constructor
            public Movie(string aTitle, string aDirector, string aRating)
            {
                title = aTitle;
                director = aDirector;
                Rating = aRating;
            }

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
        }
    

}
    

