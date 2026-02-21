using MyBlog.EntityLayer.Abstract;

namespace MyBlog.EntityLayer.Concrete;

public class Writer:IEntity
{
    public int WriterId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    
}