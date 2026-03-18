using MyBlog.DataAccessLayer.EntityFramework;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.DataAccessLayer.Abstract;

public interface IArticleDal:IEntityRepository<Article>
{
    List<Article> GetArticlesByWriter(int id);
    List<Article> GetArticlesWithCategoryByWriter(int id);
}