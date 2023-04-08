namespace MyBlog.Models.ViewModels
{
    public class ArticleAndComments
    {
        public Article Article { get; set; }
        public List<Comment> Comments { get; set; }

        public int CommentsCount { get { return Comments.Count; } }

        public int addLike
        {
            get
            {
                Article.Likes = Article.Likes + 1;
                return Article.Likes;
            }
        }

    }
}
