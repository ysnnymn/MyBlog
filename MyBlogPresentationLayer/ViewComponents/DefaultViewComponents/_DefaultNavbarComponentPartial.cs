using Microsoft.AspNetCore.Mvc;

namespace MyBlogPresentationLayer.ViewComponents.DefaultViewComponents;

public class _DefaultNavbarComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}