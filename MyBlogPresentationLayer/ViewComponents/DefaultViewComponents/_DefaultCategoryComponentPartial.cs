using Microsoft.AspNetCore.Mvc;
using MyBlog.BusinessLayer.Abstract;

namespace MyBlogPresentationLayer.ViewComponents.DefaultViewComponents;

public class _DefaultCategoryComponentPartial:ViewComponent
{
    private readonly ICategoryService _categoryService;

    public _DefaultCategoryComponentPartial(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    public IViewComponentResult Invoke()
    {
        var value = _categoryService.TGetAll();
        return View(value);
    }
    
}