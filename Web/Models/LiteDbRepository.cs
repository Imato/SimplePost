using LiteDB;
using System;
using System.Linq;
using System.Collections.Generic;
using Web.Services;

namespace Web.Models
{
    public class LiteDbRepository : IRepository
    {
        private string _connection;
        private const string _postCollection = "posts";
        private IConfigurationService _configurationService;

        public LiteDbRepository(IConfigurationService configurationService)
        {
            _configurationService = configurationService;
            _connection = _configurationService.GetConfiguration().LeteDbConnectionString;

            using (var db = new LiteDatabase(_connection))
            {
                var posts = db.GetCollection(_postCollection);
                posts.EnsureIndex("Id", true);
                posts.EnsureIndex("ShortLink");
                posts.EnsureIndex("AuthorId");
            }
        }

        private LiteCollection<Post> GetPosts()
        {
            using (var db = new LiteDatabase(_connection))
            {
                return db.GetCollection<Post>(_postCollection);
            }
        }
        public Post GetPost(int id)
        {
            return GetPosts().FindById(id);
        }

        public Post GetPost(string shortLink, string password = null)
        {
            var post = GetPost(shortLink);
            if (password == null || post.ViewPassword == null)
                return post;
            if (post.ViewPassword == password && post.EditPassword != password)
            {
                post.IsEditeble = false;
                return post;
            }
            if (post.EditPassword == password)
                return post;

            return new Post();
        }

        public Post GetPost(string shortLink)
        {
            return GetPosts().FindOne(p => p.ShortLink == shortLink) ?? new Post();
        }

        public Post GetLastPost(Author author)
        {
            return GetPosts().FindOne(p => p.AuthorId == author.Id);
        }

        public void SavePost(Post post)
        {
            using (var db = new LiteDatabase(_connection))
            {
                var posts = db.GetCollection<Post>(_postCollection);
                posts.Upsert(post);
            }
        }

        public bool CheckVersion(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
