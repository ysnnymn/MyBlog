using MyBlog.BusinessLayer.Abstract;
using MyBlog.DataAccessLayer.Abstract;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.BusinessLayer.Concrete;

public class CommentManager:ICommentService
{
    private readonly ICommentDal _commentDal;

    public CommentManager(ICommentDal commentDal)
    {
        _commentDal = commentDal;
    }

    public List<Comment> TGetAll()
    {
        return _commentDal.GetAll();
    }

    public Comment TGet(int id)
    {
       return _commentDal.Get(x=>x.CommentId == id);
    }

    public void TAdd(Comment entity)
    {
       _commentDal.Add(entity);
    }

    public void TUpdate(Comment entity)
    {
       _commentDal.Update(entity);
    }

    public void TDelete(Comment entity)
    {
       _commentDal.Delete(entity);
    }
}