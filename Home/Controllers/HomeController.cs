using System;
using System.Web.Mvc;

namespace CleanArchitectureAspNetMvc5.Home.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}