using MyBlog.DataAccessLayer.Abstract;
using MyBlog.DataAccessLayer.Context;
using MyBlog.DataAccessLayer.EntityFramework;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.DataAccessLayer.Concrete;

public class EfCategoryDal:EfEntityRepositoryBase<Category,BlogContext>,ICategoryDal
{
    public EfCategoryDal(BlogContext context) : base(context)
    {
    }
}