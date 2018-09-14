using Microsoft.AspNetCore.Mvc;

namespace WordCounter.Controller
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
