using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Model
{
    public partial class SqlRepository
    {


        public IQueryable<News> AllNews
        {
            get
            {
                return Db.News;
            }
        }

        public bool CreateNews(News instance)
        {
            if (instance.ID == 0)
            {
                Db.News.InsertOnSubmit(instance);
                Db.News.Context.SubmitChanges();
                return true;
            }

            return false;
        }

        public bool UpdateNews(News instance)
        {
            News cache = Db.News.Where(p => p.ID == instance.ID).FirstOrDefault();
            if (cache != null)
            {
                cache.TitleNew = instance.TitleNew;
                cache.TextNew = instance.TextNew;
                cache.PreviewText = instance.PreviewText;
                cache.PictureNew = instance.PictureNew;
                cache.DateNew = instance.DateNew;
                cache.OtherInfo = instance.OtherInfo;
                Db.News.Context.SubmitChanges();
                return true;
            }

            return false;
        }

        public bool RemoveNews(int idNews)
        {
            News instance = Db.News.Where(p => p.ID == idNews).FirstOrDefault();
            if (instance != null)
            {
                Db.News.DeleteOnSubmit(instance);
                Db.News.Context.SubmitChanges();
                return true;
            }

            return false;
        }

    }
}
