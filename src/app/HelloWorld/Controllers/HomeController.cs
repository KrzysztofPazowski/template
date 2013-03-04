using System.Web.Mvc;
using HelloWorld.Models;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var message = new Print().For("Hello World");
            ViewData["message"] = message;
            return View("Index");
        }

    }
}
