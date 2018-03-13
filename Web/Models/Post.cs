using System;

namespace Web.Models
{
    public class Post
    {
        // Public
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public string Text { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime DeleteDate { get; set; }
        public string ViewPassword { get; set; }
        public string EditPassword { get; set; }
        public bool IsEditeble { get; set; }
        public bool IsDraft { get; set; }
        public string ShortLink { get; set; }
        public int ViewCount { get; set; }

        // Private
        public bool IsVisible { get; set; }
        public int Version { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
