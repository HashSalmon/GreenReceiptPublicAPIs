using System.Web.Mvc;

namespace GreenReceiptRest.Controllers
{
    /// <summary>
    /// The home controller
    /// </summary>
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
