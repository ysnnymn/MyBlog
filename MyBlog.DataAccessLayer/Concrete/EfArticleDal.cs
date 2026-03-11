using MyBlog.DataAccessLayer.Abstract;
using MyBlog.DataAccessLayer.Context;
using MyBlog.DataAccessLayer.EntityFramework;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.DataAccessLayer.Concrete;

public class EfArticleDal:EfEntityRepositoryBase<Article,BlogContext>,IArticleDal
{
    private readonly BlogContext _context;
    public EfArticleDal(BlogContext context) : base(context)
    {
        _context = context;
    }

    public List<Article> GetArticlesByWriter(int id)
    {
       var values=_context.Articles.Where(x=>x.AppUserId==id).ToList();
       return values;
    }
}