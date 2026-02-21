using MyBlog.EntityLayer.Abstract;

namespace MyBlog.EntityLayer.Concrete;

public class Comment:IEntity
{
    public int CommentId { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; set; }
    public bool Status { get; set; }
    
    
}