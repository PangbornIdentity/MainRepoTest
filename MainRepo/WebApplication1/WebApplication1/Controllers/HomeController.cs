using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string mestring = "HELLO";
            var rep = new SharedRepo.RepoShare();
            return View();
        }
    }
}
