using Microsoft.AspNetCore.Identity;
using MyBlog.EntityLayer.Abstract;

namespace MyBlog.EntityLayer.Concrete;

public class AppUser:IdentityUser<int>,IEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string? City { get; set; }
    public string? ImageUrl { get; set; }

    public List<Article> Articles { get; set; }
    
}