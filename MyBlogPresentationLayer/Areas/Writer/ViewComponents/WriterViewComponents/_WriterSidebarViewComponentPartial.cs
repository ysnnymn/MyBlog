using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlog.EntityLayer.Concrete;

namespace MyBlogPresentationLayer.Areas.Writer.ViewComponents.WriterViewComponents;

public class _WriterSidebarViewComponentPartial:ViewComponent
{
    private readonly UserManager<AppUser> _userManager;

    public _WriterSidebarViewComponentPartial(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var user=await _userManager.GetUserAsync(HttpContext.User);
        return View(user);
    }
    
}