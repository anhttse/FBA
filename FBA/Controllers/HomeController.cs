using System.Web.Mvc;
using FBA.Extension;
using FBA.Models.ActionModels;

namespace FBA.Controllers
{
    [AuthorizeUser]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        [HttpGet]
        public ActionResult Reactions()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Reactions(ReactionModel model)
        {
            var fb = new Facebook.FacebookClient();
            fb.AccessToken = model.Token;
            fb.Post()
            return View();
        }
    }
}
