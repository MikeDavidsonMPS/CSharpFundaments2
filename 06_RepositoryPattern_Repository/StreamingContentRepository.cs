using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository
{
    public class StreamingContentRepository
    {
        private List<StreamingContent> _listOfContent = new List<StreamingContent>();

        
        //CRUD

        //CREATE
        public void AddContentToList(StreamingContent content)
        {
            _listOfContent.Add(content);
        }

        //READ
        public List<StreamingContent> GetStreamingContents()
        {
            return _listOfContent;
        }

        //UPDATE: inorder to know the whats been updated - we must included the original content to prove whats been update
        public bool UpdateExistContent(string originalTitle, StreamingContent newContent)
        {
            //Find the original content
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            //Update the content
            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.IsFamilyFriendly = newContent.IsFamilyFriendly;
                oldContent.StarRating = newContent.StarRating;
                oldContent.TypeOfGenre = newContent.TypeOfGenre;

                return true;
            }
            else
            {
                return false;
            }
        }

        //DELETE
        public bool RemoveContentFromList(string title)
        {
            StreamingContent content = GetContentByTitle(title);

            if(content == null)
            {
                return false;
            }

            int intialCount = _listOfContent.Count;
            _listOfContent.Remove(content);

            if(intialCount > _listOfContent.Count)
            {
                return true;   
            }
            else
            {
                return false;
            }
        }


        //HELPER METHOD
        public StreamingContent GetContentByTitle(string title)
        {
            foreach(StreamingContent content in _listOfContent)
            {
                if(content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }

            return null;

        }
    }
}
