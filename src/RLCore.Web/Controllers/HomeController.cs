using Microsoft.AspNetCore.Mvc;

namespace RLCore.Web.Controllers
{
    public class HomeController : RLCoreControllerBase
    {
        public ActionResult Index()
        {
            return Redirect("/swagger");
            return View();
        }

        public ActionResult About()
        {


            return View();
        }
    }
}