using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartLab.Models
{
    public class CartModel
    {
        //        public Dictionary<long, MovieModel> movies = new Dictionary<long, MovieModel>();
        public List<MovieModel> moviesList = new List<MovieModel>();

        public double total = 0;

        public string GetTotal()
        {
            total = 0;
            foreach (MovieModel mm in moviesList)
            {
                total += mm.Price;
            }

            return total.ToString("C2");
        }
        public bool AddMovie(MovieModel other)
        {
            if (moviesList.Contains(other))
                return false;

            moviesList.Add(other);

            return true;
        }
    }
}
