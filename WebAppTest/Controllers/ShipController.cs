using System.Web.Mvc;

namespace WebAppTest.Controllers
{
    public class ShipController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View("Index", "_Admin");
        }
    }
}