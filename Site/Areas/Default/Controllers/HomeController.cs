using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Site.Model;
using Site.Controllers;
using Site.Models;
using System.Net;
using Site.Models.Info;

namespace Site.Areas.Default.Controllers
{
    public class HomeController : DefaultController
    {
        public ActionResult Index()
        {
            
            return View(User);
        }

        public ActionResult AllNews(int page = 1)
        {
            List<News> ne = Repository.AllNews.ToList();
            var data = new PageableData<News>(Repository.AllNews.OrderByDescending(s => s.DateNew), page, 5);
            return View(data);
        }

        public PartialViewResult GetNews(News news)
        {
            var ne = ModelMapper.Map(Repository.AllNews.Take(3).OrderByDescending(s => s.DateNew).ToList(), typeof(List<News>), typeof(IEnumerable<NewsModel>));

            return PartialView(ne);
        }

        public ActionResult GetNew(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            News news = Repository.AllNews.Where(p => p.ID == id).FirstOrDefault();

            NewsModel n = (NewsModel)ModelMapper.Map(news, typeof(News), typeof(NewsModel));

            if (news == null)
            {
                return HttpNotFound();
            }
            return View(n);

        }

        public ActionResult Contacts()
        {
            return View();
        }

        public ActionResult UserLogin()
        {
            return View(CurrentUser);
        }
    }
}