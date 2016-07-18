using Site.Controllers;
using Site.Model;
using Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Areas.Default.Controllers
{
    public class RoleController : DefaultController
    {
        public ActionResult Index()
        {
            var roles = Repository.Roles.ToList();
            return View(roles);
        }

        public ActionResult CheckAdmin(int id)
        {
            var model = new UserRoleViewModel()
            {
                ID = id,
                UserRoles = Repository.UserRoles.ToList()
            };

            return View(model);
        }
    }
}