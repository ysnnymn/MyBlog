using MyBlog.BusinessLayer.Abstract;
using MyBlog.DataAccessLayer.Abstract;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.BusinessLayer.Concrete;

public class CategoryManager:ICategoryService
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public List<Category> TGetAll()
    {
     return _categoryDal.GetAll();
    }

    public Category TGet(int id)
    {
      return _categoryDal.Get(x=>x.CategoryId == id);
    }

    public void TAdd(Category entity)
    {
       _categoryDal.Add(entity);
    }

    public void TUpdate(Category entity)
    {
        _categoryDal.Update(entity);
    }

    public void TDelete(Category entity)
    {
        _categoryDal.Delete(entity);
    }
}