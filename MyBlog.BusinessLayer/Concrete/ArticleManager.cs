using MyBlog.BusinessLayer.Abstract;
using MyBlog.DataAccessLayer.Abstract;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.BusinessLayer.Concrete;

public class ArticleManager:IArticleService
{
    private readonly IArticleDal _articleDal;

    public ArticleManager(IArticleDal articleDal)
    {
        _articleDal = articleDal;
    }

    public List<Article> TGetAll()
    {
        return _articleDal.GetAll();
    }

    public Article TGet(int id)
    {
        return _articleDal.Get(x => x.ArticleId == id);
    }

    public void TAdd(Article entity)
    {
        _articleDal.Add(entity);

    }

    public void TUpdate(Article entity)
    {
       _articleDal.Update(entity);
    }

    public void TDelete(Article entity)
    {
        _articleDal.Delete(entity);
    }

    public List<Article> TGetArticlesByWriter(int id)
    {
       return _articleDal.GetArticlesByWriter(id);
       
    }

    public List<Article> TGetArticlesWithCategoryByWriter(int id)
    {
       return _articleDal.GetArticlesWithCategoryByWriter(id);
    }

    public List<Article> TGetArticlesWithCategory()
    {
        return _articleDal.GetArticlesWithCategory();
    }

    public Article TGetArticleWithCategoryByArticleId(int id)
    {
        return _articleDal.GetArticleWithCategoryByArticleId(id);
    }

    public List<Article> TGetAllArticlesWithCategory()
    {
        return _articleDal.GetAllArticlesWithCategory();
    }
}