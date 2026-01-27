using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.FullName = "Hello Nguyễn Trung Hiếu 2221050691";
            return View();
        }
        public IActionResult Demo()
        {
            return View();
        }
    }
}