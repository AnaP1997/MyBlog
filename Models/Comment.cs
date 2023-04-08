namespace MyBlog.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual Article? Article { get; set; }
    }
}
