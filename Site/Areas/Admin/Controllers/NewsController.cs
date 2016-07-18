using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Site.Model;
using Site.Models;
using Site.Controllers;
using AutoMapper;
using Site.Filters;

namespace Site.Areas.Admin.Controllers
{
    [MyAuthorize(Roles = "admin")]
    public class NewsController : BaseController
    {

        // GET: Admin/News
        public ActionResult Index()
        {

            var ne = ModelMapper.Map(Repository.AllNews.ToList(), typeof(List<News>), typeof(IEnumerable<NewsModel>));

            return View(ne);
        }

        // GET: Admin/News/Details/5
        public ActionResult Details(int? id)
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
        
        // GET: Admin/News/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/News/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NewsModel news)
        {
            if (ModelState.IsValid)
            {
                News n = (News)ModelMapper.Map(news, typeof(NewsModel), typeof(News));
                Repository.CreateNews(n);
                return RedirectToAction("Index");
            }

            return View(news);
        }
        
        // GET: Admin/News/Edit/5
        public ActionResult Edit(int? id)
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

        // POST: Admin/News/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( NewsModel news)
        {
            if (ModelState.IsValid)
            {
                News n = (News)ModelMapper.Map(news, typeof(NewsModel), typeof(News));
                Repository.UpdateNews(n);
                return RedirectToAction("Index");
            }
            return View(news);
        }
        
        // GET: Admin/News/Delete/5
        public ActionResult Delete(int? id)
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

        // POST: Admin/News/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Repository.RemoveNews(id);
            return RedirectToAction("Index");
        }
        
    }
}
