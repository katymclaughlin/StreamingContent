using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreamingContent_Repository
{
    public class ShowRepository
    {
        protected readonly List<Show> _contentDirectory = new List<Show>();

        //Create
        public bool AddShow(Show content)
        {
            int startingCount = _contentDirectory.Count;
            _contentDirectory.Add(content);
            bool wasAdded = (_contentDirectory.Count > startingCount) ? true: false;
            return wasAdded;
        }
        //Read
       public List<Show> GetContents()
       {
        return _contentDirectory;
       }
       public Show GetContent (string title)
       {
        foreach (Show content in _contentDirectory)
        {
            if (content.Title.ToLower() == title.ToLower())
            {
                return content;
            }
        }
        return null;
       }
       //update
       public bool UpdateShow(int showId, int fieldId, string updatedValue)
       {
        Show oldContent = _contentDirectory[showId];
            if (fieldId == 1)
            {
                oldContent.Title = updatedValue;
            }
            else if (fieldId == 2)
            {
                oldContent.AverageRunTime = Convert.ToDouble(updatedValue);
            }
        
            _contentDirectory[showId] = oldContent;

            return true;
       }
       
       //delete
       public bool DeleteShow(Show existingContent)
       {
        bool deleteResult = _contentDirectory.Remove(existingContent);
        return deleteResult;
       }
       public bool DeleteShowById(int ShowIndexRemove)
       {
        int startingCount = _contentDirectory.Count;
        _contentDirectory.RemoveAt(ShowIndexRemove);
        bool wasDeleted = (_contentDirectory.Count <startingCount) ? true : false;
        return wasDeleted;
       }
    }
}