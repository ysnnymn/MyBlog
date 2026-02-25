using MyBlog.BusinessLayer.Abstract;
using MyBlog.DataAccessLayer.Abstract;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.BusinessLayer.Concrete;

public class WriterManager:IWriterService
{
    private readonly IWriterDal _writerDal;

    public WriterManager(IWriterDal writerDal)
    {
        _writerDal = writerDal;
    }

    public List<Writer> TGetAll()
    {
        return _writerDal.GetAll();
    }

    public Writer TGet(int id)
    {
        return _writerDal.Get(x=>x.WriterId == id);
    }

    public void TAdd(Writer entity)
    {
        _writerDal.Add(entity);
    }

    public void TUpdate(Writer entity)
    {
        _writerDal.Update(entity);
    }

    public void TDelete(Writer entity)
    {
      _writerDal.Delete(entity);
    }
}