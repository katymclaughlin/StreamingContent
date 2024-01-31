using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreamingContent_Repository

{
    public class MovieRepository
    {
    protected readonly List<Movie> _contentDirectory = new List<Movie>();

       //Create
       public bool AddMovie(Movie content)
       {
        int startingCount = _contentDirectory.Count;
        _contentDirectory.Add(content);
        bool wasAdded = (_contentDirectory.Count >startingCount) ? true : false;
        return wasAdded;
       } 
       //Read
       public List<Movie> GetContents()
       {
        return _contentDirectory;
       }
       public Movie GetContentByDirector (string director)
       {
        foreach (Movie content in _contentDirectory)
        {
            if (content.Director.ToLower() == director.ToLower())
            {
                return content;
            }
        }
        return null;
       }
       //update
       public bool UpdateMovie(int movieId, int fieldId, string updatedValue)
       {
        Movie oldContent = _contentDirectory[movieId];
            if (fieldId == 1)
            {
                oldContent.Title = updatedValue;
            }
            else if (fieldId == 2)
            {
                oldContent.Director = updatedValue;
            }
            else if (fieldId ==3)
            {
                oldContent.RunTime = Convert.ToDouble(updatedValue);
            }
        
            _contentDirectory[movieId] = oldContent;

            return true;
       }

       //delete
       public bool DeleteMovie(Movie existingContent)
       {
        bool deleteResult = _contentDirectory.Remove(existingContent);
        return deleteResult;
       }

        public bool DeleteMoviebyId(int MovieIndexRemove)
       {
        int startingCount = _contentDirectory.Count;
        _contentDirectory.RemoveAt(MovieIndexRemove);
        bool wasDeleted = (_contentDirectory.Count <startingCount) ? true : false;
        return wasDeleted;
       }
       
    }
}