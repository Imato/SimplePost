using System.Collections.Generic;

namespace Web.Models
{
    public interface IRepository
    {
        Post GetLastPost(Author author);
        Post GetPost(int id);
        Post GetPost(string shortLink);
        Post GetPost(string shortLink, string password = null);
        void SavePost(Post post);
        bool CheckVersion(Post post);
    }
}