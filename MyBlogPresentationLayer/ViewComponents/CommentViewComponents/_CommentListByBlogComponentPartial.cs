using Microsoft.AspNetCore.Mvc;
using MyBlog.BusinessLayer.Abstract;
using MyBlog.DataAccessLayer.Abstract;

namespace MyBlogPresentationLayer.ViewComponents.CommentViewComponents;

public class _CommentListByBlogComponentPartial:ViewComponent
{
    private readonly ICommentService _commentService;

    public _CommentListByBlogComponentPartial(ICommentService commentService)
    {
        _commentService = commentService;
    }


    public IViewComponentResult Invoke(int id)
    {
        id = 21;
        var value=_commentService.TGetCommentByBlog(id);
        return View(value);
    }
}