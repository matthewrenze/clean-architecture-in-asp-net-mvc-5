using System;
using System.Web.Mvc;

namespace CleanArchitectureAspNetMvc5.Contact.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}