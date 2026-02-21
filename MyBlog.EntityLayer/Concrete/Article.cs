using MyBlog.EntityLayer.Abstract;

namespace MyBlog.EntityLayer.Concrete;

public class Article:IEntity
{
    public int ArticleId { get; set; }
    public string Title { get; set; }
    public string CoverImageUrl { get; set; }
    public string ThumbImageUrl { get; set; }
    public string Detail { get; set; }
    public DateTime CreatedDate { get; set; }
    
}