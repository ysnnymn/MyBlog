using MyBlog.DataAccessLayer.Abstract;
using MyBlog.DataAccessLayer.Context;
using MyBlog.DataAccessLayer.EntityFramework;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.DataAccessLayer.Concrete;

public class EfSocialMediaDal:EfEntityRepositoryBase<SocialMedia,BlogContext>,ISocialMediaDal
{
    public EfSocialMediaDal(BlogContext context) : base(context)
    {
    }
}