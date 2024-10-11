using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagementSystem
{
    internal class Program
    {


        static void Main(string[] args)
        {
            //Movie car1 = new Movie("MOVIE_001", "Titanic ", "James Cameroon", "1.00 ");
            //Console.WriteLine(car1);
            

            Console.WriteLine("Movie Rental Management System :");
            Console.WriteLine("1.Add a movie");
            Console.WriteLine("2.View all movies");
            Console.WriteLine("3.Update a movie");
            Console.WriteLine("4.Delete a movie");
            Console.WriteLine("5.Exit");

            Console.WriteLine("Choose an Option :");
            var option = Console.ReadLine();
            var opt = int.Parse(option);

            do
            {
                switch (opt)
                {
                    case 1:
                        Console.WriteLine("Add a movie Id :");
                        var movieId = Console.ReadLine();
                        Console.WriteLine("Add a movie title :");
                        var tilte = Console.ReadLine();
                        Console.WriteLine("Add a movie director :");
                        var director = Console.ReadLine();
                        Console.WriteLine("Add a movie rentalPrice :");
                        var rentalPrice = Console.ReadLine();
                        CreateMovie(movieId, tilte, director, rentalPrice);

                        break;

                    case 2:

                        Console.WriteLine("list of Movies :");
                        readMovie();
                        break;

                    case 3:

                        Console.WriteLine("Enter the movie ID to update :");
                        var updateId = Console.ReadLine();
                        Console.WriteLine("Enter new Title");
                        var newTitle = Console.ReadLine();
                        Console.WriteLine("Enter new Director : ");
                        var newDirector = Console.ReadLine();
                        Console.WriteLine("Enter new rental price :");
                        var newPrice = Console.ReadLine();
                        updateMovie(updateId, newTitle, newDirector, newPrice);
                        break;

                    case 4:

                        Console.WriteLine("Enter the Movie Id to delete : ");
                        var deleteId = Console.ReadLine();
                        deleteMovie(deleteId);
                        break;

                    case 5:

                        Console.WriteLine("Good Bye !");
                        break;

                    default:
                        Console.WriteLine("Enter number between 1 to 5.");
                        break;

                }


            } while (opt > 5);

            Console.ReadLine();
        }



                }


}
    

    
