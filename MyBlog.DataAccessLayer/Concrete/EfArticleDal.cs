using MyBlog.DataAccessLayer.Abstract;
using MyBlog.DataAccessLayer.Context;
using MyBlog.DataAccessLayer.EntityFramework;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.DataAccessLayer.Concrete;

public class EfArticleDal:EfEntityRepositoryBase<Article,BlogContext>,IArticleDal
{
    public EfArticleDal(BlogContext context) : base(context)
    {
    }
}