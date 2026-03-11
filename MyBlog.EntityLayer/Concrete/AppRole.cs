using Microsoft.AspNetCore.Identity;
using MyBlog.EntityLayer.Abstract;

namespace MyBlog.EntityLayer.Concrete;

public class AppRole:IdentityRole<int>,IEntity
{
    public string? RoleDetail { get; set; }
}