using MyBlog.BusinessLayer.Abstract;
using MyBlog.DataAccessLayer.Abstract;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.BusinessLayer.Concrete;

public class TagManager:ITagService
{
    private readonly ITagDal _tagDal;

    public TagManager(ITagDal tagDal)
    {
        _tagDal = tagDal;
    }

    public List<Tag> TGetAll()
    {
        return _tagDal.GetAll();
    }

    public Tag TGet(int id)
    {
        return _tagDal.Get(x=>x.TagId == id);
    }

    public void TAdd(Tag entity)
    {
      _tagDal.Add(entity);
    }

    public void TUpdate(Tag entity)
    {
        _tagDal.Update(entity);
    }

    public void TDelete(Tag entity)
    {
       _tagDal.Delete(entity);
    }
}