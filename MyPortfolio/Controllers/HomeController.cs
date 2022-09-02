using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using System.Diagnostics;
using MyPortfolio.Data;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            Userticket userticket=new Userticket();
            return View(userticket);
        }
        [HttpPost]
        //public IActionResult ContactUs(IFormCollection form)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View();
        //    }

        //       var Name=form["name"];
        //       return Json(Ok());
        //}

        public IActionResult ContactUs(Userticket userticket)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Error = "اطلاعات وارد شده صحیح نیست لطفا دوباره تلاش کنید!!!";
                return View(userticket);
            }

            ViewBag.Succes = "پیام شما با موفقیت ثبت شد ";
            ModelState.Clear();


            return View();
        }

        public IActionResult ProjectDetail(int id)
        {
            var project = ProjectData.GetProjectBy(id);
            return View(project);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}