using MyBlog.BusinessLayer.Abstract;
using MyBlog.DataAccessLayer.Abstract;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.BusinessLayer.Concrete;

public class SocialMediaManager:ISocialMediaService
{
    private readonly ISocialMediaDal _socialMediaDal;

    public SocialMediaManager(ISocialMediaDal socialMediaDal)
    {
        _socialMediaDal = socialMediaDal;
    }

    public List<SocialMedia> TGetAll()
    {
        return _socialMediaDal.GetAll();
    }

    public SocialMedia TGet(int id)
    {
        return _socialMediaDal.Get(x=>x.SocialMediaId == id);
    }

    public void TAdd(SocialMedia entity)
    {
       _socialMediaDal.Add(entity);
    }

    public void TUpdate(SocialMedia entity)
    {
        _socialMediaDal.Update(entity);
    }

    public void TDelete(SocialMedia entity)
    {
        _socialMediaDal.Delete(entity);
    }
}