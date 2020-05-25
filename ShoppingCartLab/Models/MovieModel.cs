using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartLab.Models
{
    public class MovieModel : IEquatable<MovieModel>
    {
        public MovieModel()
        {
        }
        public MovieModel(long ID, string Title, string Genre)
        {
            this.ID = ID;
            this.Title = Title;
            this.Genre = Genre;
        }

        public bool Equals(MovieModel other)
        {
            Console.WriteLine("Equals " + this.ID + " to " + other.ID);
            if (other == null) return false;
            return (this.ID.Equals(other.ID));
        }

        public override int GetHashCode()
        {
            return (int) this.ID;
        }

        public long ID { set; get; }
        public string Title { set; get; }
        public string Genre { set; get; }
        public double Price { set; get; } = 6.99;
    }
}
