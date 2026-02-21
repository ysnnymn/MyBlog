using MyBlog.EntityLayer.Abstract;

namespace MyBlog.EntityLayer.Concrete;

public class Tag:IEntity
{
    public int TagId { get; set; }
    public string TagTitle { get; set; }
    
    
}