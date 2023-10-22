using Microsoft.AspNetCore.Mvc;

namespace HomeController.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("result")]
        public IActionResult Result(string Iname, string Ilocation, string Ifavorite, string Icomment)
        {
            ViewBag.Iname = Iname;
            ViewBag.Ilocation = Ilocation;
            ViewBag.Ifavorite = Ifavorite;
            ViewBag.IComment = Icomment;
            return View();
        }
    }
}