using Abraham.Models;
using System.Web.Mvc;

namespace Abraham.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            /*
             * if(loginSucceed) 
             *      ViewBag.ReturnUrl = http://home.....
             * else
             *      return fail;
             */

            ViewBag.ReturnUrl = "http://localhost:50562/";

            return Content("", "application/json");
        }
    }
}