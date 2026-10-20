using Microsoft.AspNetCore.Mvc;

namespace bai2.Controllers
{
    public class HelloController : Controller
    {
        public string Greeting()
        {
            return "Chao mung cac ban den voi mon hoc ASP.NET";
        }

        public string Welcome(int id, string name)
        {
            return $"Xin chao {id} - {name}, chuc ban hoc tot";
        }

        public IActionResult Welcome1(int id1, string name)
        {
            ViewBag.Id = id1;
            ViewBag.Name = name ?? "Sinh vien";

            return View();
        }
    }
}

// View Component
namespace bai2.ViewComponents
{
    public class GreetingViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.Message = "Xin chao tu View Component!";
            return View();
        }
    }
}