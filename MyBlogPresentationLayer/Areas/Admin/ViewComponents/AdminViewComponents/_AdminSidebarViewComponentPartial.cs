using Microsoft.AspNetCore.Mvc;

namespace MyBlogPresentationLayer.Areas.Admin.ViewComponents.AdminViewComponents;

public class _AdminSidebarViewComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}