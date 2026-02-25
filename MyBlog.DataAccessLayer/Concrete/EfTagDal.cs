using MyBlog.DataAccessLayer.Abstract;
using MyBlog.DataAccessLayer.Context;
using MyBlog.DataAccessLayer.EntityFramework;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.DataAccessLayer.Concrete;

public class EfTagDal:EfEntityRepositoryBase<Tag,BlogContext>,ITagDal
{
    public EfTagDal(BlogContext context) : base(context)
    {
    }
}