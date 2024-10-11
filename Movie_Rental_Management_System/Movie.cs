using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagementSystem
{
    internal class Movie
    {
        private string movieId { get; set; }
        private string title { get; set; }
        private string director { get; set; }
        private string rentalPrice { get; set; }

        public Movie() { }
        public Movie(string movieId, string title, string director, string rentalPrice)
        {
            this.movieId = movieId;
            this.title = title;
            this.director = director;
            this.rentalPrice = rentalPrice;
        }
        public override string ToString() 
        {
            return $"Movie ID: {movieId} , Title : {title} , Director : {director} , Rental Price : {rentalPrice}";
        }

       
    }

 
}
