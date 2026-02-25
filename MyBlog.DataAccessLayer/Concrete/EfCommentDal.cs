using MyBlog.DataAccessLayer.Abstract;
using MyBlog.DataAccessLayer.Context;
using MyBlog.DataAccessLayer.EntityFramework;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.DataAccessLayer.Concrete;

public class EfCommentDal:EfEntityRepositoryBase<Comment,BlogContext>,ICommentDal
{
    public EfCommentDal(BlogContext context) : base(context)
    {
    }
}