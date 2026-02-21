using Microsoft.EntityFrameworkCore;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.DataAccessLayer.Context;

public class BlogContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Data Source=localhost;Initial Catalog=DbMyBlog;User ID=SA;Password=Yasinyaman.43;Encrypt=False;TrustServerCertificate=True"
        );
    }

    public DbSet<Article> Articles { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Writer> Writers { get; set; }
    
}