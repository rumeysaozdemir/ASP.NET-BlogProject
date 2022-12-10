using BusinessLayer.Concrete;
using CoreDemo.Models;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Comments
{
    public class CommentListByBlog : ViewComponent
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IViewComponentResult Invoke()
        {
            var values = cm.GetList(2);
            return View(values);
        }
    }
}
