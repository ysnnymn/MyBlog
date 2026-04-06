using Microsoft.AspNetCore.Mvc;

namespace MyBlogPresentationLayer.Areas.Admin.ViewComponents.AdminViewComponents;

public class _AdminNavbarViewComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}