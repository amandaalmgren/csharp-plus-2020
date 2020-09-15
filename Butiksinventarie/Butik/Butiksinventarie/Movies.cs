using System;
using System.Collections.Generic;
using System.Text;

namespace Butiksinventarie
{
    class Movies : Store
    {
        private string name;
        private double rating;
        private int releaseDate;
        private double price;
        private string creator;
        public Movies(string name, double rating, int releaseDate, double price, string creator)
        {
            this.name = name;
            this.rating = rating;
            this.releaseDate = releaseDate;
            this.price = price;
            this.creator = creator;

            List<Movies> MovieList = new List<Movies>();
            MovieList.Add(new Movies("Filmnamn", 8, 20200123, 89, "Alf"));
            MovieList.Add(new Movies("Filmnamn2", 7, 20200120, 79, "Bruno"));

            foreach(var movies in MovieList)
            {
                Console.WriteLine($"Film: {0}, {1}, {2}, {3}, {4}");
            }

        }        
    }
}
