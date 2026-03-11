using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using MyBlog.BusinessLayer.Abstract;

namespace MyBlogPresentationLayer.ViewComponents.DefaultViewComponents;

public class _DefaultSocialMediaComponentPartial:ViewComponent
{
    private readonly ISocialMediaService _socialMediaService;

    public _DefaultSocialMediaComponentPartial(ISocialMediaService socialMediaService)
    {
        _socialMediaService = socialMediaService;
    }

    public IViewComponentResult Invoke()
    {
        var value = _socialMediaService.TGetAll();
        return View(value);
    }
    
}