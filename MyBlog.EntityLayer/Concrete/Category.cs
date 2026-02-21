using MyBlog.EntityLayer.Abstract;

namespace MyBlog.EntityLayer.Concrete;

public class Category:IEntity
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}