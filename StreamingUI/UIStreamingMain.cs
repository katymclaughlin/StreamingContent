//using Internal;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StreamingContent_Repository;

namespace Streaming_UI
{
    public class UIHelper {
        ShowRepository showList = new ShowRepository();
        MovieRepository movieList = new MovieRepository();
        public void ListofMovies()
        {
            List<Movie> MovieList = movieList.GetContents();
            Console.WriteLine ("Movie List Amount = " + MovieList.Count);
            Console.WriteLine("Movie Title           | Director          | RunTime");
            Console.WriteLine("===================================================");
            for (int i = 0; i < MovieList.Count; i++ )
            {
            Console.WriteLine(MovieList[i].Title + "                " + MovieList[i].Director + "              " + MovieList[i].RunTime);
            }
        }
        public void AddMovies()
        {
            //NOTE - The application will provide a way for the user to input all of the data for a Movie
            Movie NewMovie = new Movie();
            Console.WriteLine("Please type a movie title you would like to add.");
            string addMovieInput = Console.ReadLine();
            Console.WriteLine("Please provide the director for this movie.");
            string addDirectorInput = Console.ReadLine();
            Console.WriteLine("Please add the movie run time.");
            double addMovieRunTime = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("We have added the movie " + addMovieInput + " " + "with director " + addDirectorInput + " " + "and a runtime of " + addMovieRunTime);
            NewMovie.Title = addMovieInput;
            NewMovie.Director = addDirectorInput;
            NewMovie.RunTime = addMovieRunTime;
            bool AddMovie = movieList.AddMovie(NewMovie);
        }
        public void UpdateMovies()
        {
            Console.WriteLine("Please type the number next to the movie you would like to update.");
            List<Movie> MovieList = movieList.GetContents();
            for (int i = 0; i < MovieList.Count; i++ )
            {
            Console.WriteLine(i + " " + MovieList[i].Title);  
            }
            int updateUserInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type 1 to udpate the Movie Title");
            Console.WriteLine("Type 2 to update the Movie Director");
            Console.WriteLine("Type 3 to update the RunTime"); 
            int updateMovieUserInput = Convert.ToInt32(Console.ReadLine());
            if (updateMovieUserInput == 1)
            {
                Console.WriteLine ("Updating the Title");
            }
            else if (updateMovieUserInput == 2)
            {
                Console.WriteLine ("Updating the Movie Director");
            }
            else if (updateMovieUserInput == 3)
            {
                Console.WriteLine ("Updating the RunTime");
            }
            else 
            {
                return;
            }
            string UserUpdateChoice = Console.ReadLine();
            bool UpdateMovie = movieList.UpdateMovie(updateUserInput, updateMovieUserInput, UserUpdateChoice);
        }

        public void DeleteMovies()
        {
            Console.WriteLine("Please type the number next to the movie you would like to delete.");
            List<Movie> MovieList = movieList.GetContents();
            for (int i = 0; i < MovieList.Count; i++ )
            {
            Console.WriteLine(i + " " + MovieList[i].Title);  
            }
            int deleteUserInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Deleting Movie # " + deleteUserInput);
            bool DeleteMoviebyId = movieList.DeleteMoviebyId(deleteUserInput);
        }
            //NOTE - The application will provide a way for the user to input all of the data for a Show
        
        public void ListofShows()
        {
            List<Show> ShowList = showList.GetContents();
            Console.WriteLine ("Show List Amount = " + ShowList.Count);
            Console.WriteLine("Show Title         | Average RunTime");
            Console.WriteLine("====================================");
            for (int i = 0; i < ShowList.Count; i++ )
            {
            Console.WriteLine(ShowList[i].Title + "                    " + ShowList[i].AverageRunTime);
            }
        }
        public void AddShows()
        {
            Show NewShow = new Show();
            Console.WriteLine("Please type a show title you would like to add.");
            string addShowInput = Console.ReadLine();
            Console.WriteLine("Please add the show run time.");
            double addShowRunTime = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("We have added the show " + addShowInput + " " + "with a runtime of " + addShowRunTime);
            NewShow.Title = addShowInput;
            NewShow.AverageRunTime = addShowRunTime;
            bool AddShow = showList.AddShow(NewShow);
        }
        public void DeleteShows()
        {
            Console.WriteLine("Please type the number next to the show you would like to delete.");
            List<Show> ShowList = showList.GetContents();
            for (int i = 0; i < ShowList.Count; i++ )
            {
            Console.WriteLine(i + " " + ShowList[i].Title);  
            }
            int deleteUserInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Deleting Movie # " + deleteUserInput);
            bool DeleteShowbyId = showList.DeleteShowById(deleteUserInput);
        }
    }
    public class UIStreamingMain
    { 
        public static void Main(string[] args)
        {
            UIHelper uih = new UIHelper();
            //NOTE - The application should offer the user a text-based menu:
            while (true)
            {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" ");
            Console.WriteLine("------> STREAMING CONTENT APPLICATION <-----");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("============================================");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter the letter next to preferred menu item");
            Console.WriteLine(" ");

            //NOTE - Create/Read/Update/Delete/Movies
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("MOVIES");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("A. Add a Movie");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("B. List of Movies");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("C. Update a Movie");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("D. Delete a Movie");
            
            //NOTE - Create/Read/Update/Delete Shows
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("SHOWS");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("E. Add a Show");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("F. List of Shows");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("G. Update a Show");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("H. Delete a Show");
            Console.WriteLine(" ");
            
            //NOTE - The application's text-based menu should have an exit option that ends the program
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("EXIT");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("X. EXIT THE APPLICATION");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("============================================");
            
            //NOTE - Application display page with options for user
            string menuUserInput = Console.ReadLine().ToLower();
            //Console.WriteLine("menu input = "+menuUserInput);
            switch(menuUserInput)
            {
                case "a":
                    uih.AddMovies();
                    break;
                case "b": 
                    uih.ListofMovies();
                    break;
                case "c":
                    uih.UpdateMovies();
                    break;
                case "d":
                    uih.DeleteMovies();
                    break;
                case "e":
                    uih.AddShows();
                    break;   
                case "f":
                    uih.ListofShows();
                    break; 
                case "h":
                    uih.DeleteShows();
                    break;        
                case "x":
                    return;
                    break;
            }
            }
        }
    }
}