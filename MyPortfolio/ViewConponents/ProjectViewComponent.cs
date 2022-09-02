using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Data;
using MyPortfolio.Models;

namespace MyPortfolio.ViewConponents
{
    public class ProjectViewComponent:ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            var project = ProjectData.GetAllProjects();
            return View("_Project", project);
        }
    }
}
