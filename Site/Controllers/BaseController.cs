using Ninject;
using Site.Global.Auth;
using Site.Mappers;
using Site.Model;
using System.Web.Mvc;

namespace Site.Controllers
{
    public abstract class BaseController : Controller
    {
        [Inject]
        public IRepository Repository { get; set; }

        [Inject]
        public IMapper ModelMapper { get; set; }

        [Inject]
        public Site.Global.Auth.IAuthentication Auth { get; set; }

        public User CurrentUser
        {
            get
            {
                return ((Site.Global.Auth.IUserProvider)Auth.CurrentUser.Identity).User;
            }
        }
    }
}