using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.ViewConponents
{
    public class ProjectViewComponent:ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            var project = new List<Project>()
            {
                new Project(1,"MyFirstShop","","Me","project-1.jpg"),
                new Project(2,"MyFirstShop","","Me","project-2.jpg"),
                new Project(3,"MyFirstShop","","Me","project-3.jpg"),
                new Project(4,"MyFirstShop","","Me","project-4.jpg")
            };
            return View("_Project", project);
        }
    }
}
