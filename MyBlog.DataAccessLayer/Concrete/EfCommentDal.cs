using MyBlog.DataAccessLayer.Abstract;
using MyBlog.DataAccessLayer.Context;
using MyBlog.DataAccessLayer.EntityFramework;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.DataAccessLayer.Concrete;

public class EfCommentDal:EfEntityRepositoryBase<Comment,BlogContext>,ICommentDal
{
    private readonly BlogContext _context;
    public EfCommentDal(BlogContext context) : base(context)
    {
        _context = context;
    }

    public List<Comment> GetCommentByBlog(int id)
    {
        var values=_context.Comments.Where(x=>x.ArticleId==id).ToList();
        return values;
    }
}