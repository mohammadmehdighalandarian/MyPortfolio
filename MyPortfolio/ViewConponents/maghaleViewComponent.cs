using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.ViewConponents
{
    public class maghaleViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var maghalat = new List<maghale>()
            {
                new maghale(1, "Top 3 JavaScript Frameworks",
                    "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient",
                    "blog-post-thumb-2.jpg"),
                new maghale(2, "About Remote Working",
                    " elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturien",
                    "blog-post-thumb-3.jpg"),
                new maghale(3, "About Remote Working",
                    " elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturien",
                    "blog-post-thumb-4.jpg"),
            };
            return View("_maghaleh", maghalat);
        }
    }
}