using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    Id= 1,
                    Username="Rumeysa"
                },

                new UserComment
                {
                    Id= 2,
                    Username="Ömer"
                },

                new UserComment
                {
                    Id= 3,
                    Username="Beyza"
                },

            };
            return View(commentValues);
        }

    }
}
