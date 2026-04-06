using MyBlog.EntityLayer.Concrete;

namespace MyBlog.BusinessLayer.Abstract;

public interface ICommentService:IGenericService<Comment>
{
    List<Comment> TGetCommentByBlog(int id);
    
}