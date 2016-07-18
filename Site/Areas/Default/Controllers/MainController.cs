using Site.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Areas.Default.Controllers
{
    public class MainController : DefaultController
    {
        // GET: Default/Main
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult Services()
        {
            var services = Repository.Services.ToList();
            return View(services);
        }
    }
}