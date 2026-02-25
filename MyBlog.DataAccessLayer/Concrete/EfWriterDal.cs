using MyBlog.DataAccessLayer.Abstract;
using MyBlog.DataAccessLayer.Context;
using MyBlog.DataAccessLayer.EntityFramework;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.DataAccessLayer.Concrete;

public class EfWriterDal: EfEntityRepositoryBase<Writer, BlogContext>, IWriterDal
{
    public EfWriterDal(BlogContext context) : base(context)
    {
    }
}