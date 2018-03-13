using System;

namespace Web.Models
{
    public class Repository : IRepository
    {
        public Post GetPost(int id)
        {
            throw new NotImplementedException();
        }

        public Post GetPost(string shortLink, string password = null)
        {
            throw new NotImplementedException();
        }

        public Post GetPost(string shortLink)
        {
            throw new NotImplementedException();
        }

        public Post GetLastPost(Author author)
        {
            throw new NotImplementedException();
        }

        public void SavePost(Post post)
        {

        }

        public bool CheckVersion(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
