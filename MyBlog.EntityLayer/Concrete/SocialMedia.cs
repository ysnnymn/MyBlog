using MyBlog.EntityLayer.Abstract;

namespace MyBlog.EntityLayer.Concrete;

public class SocialMedia:IEntity
{
    public int SocialMediaId { get; set; }
    public string Title { get; set; }
    public string IconUrl { get; set; }
    public string LinkUrl { get; set; }
    
            
}