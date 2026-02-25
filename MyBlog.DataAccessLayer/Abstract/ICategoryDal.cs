using MyBlog.DataAccessLayer.EntityFramework;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.DataAccessLayer.Abstract;

public interface ICategoryDal:IEntityRepository<Category>
{
    
}