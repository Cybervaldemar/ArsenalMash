using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using Site.Areas.Default;
using Site.Areas.Admin;
using System.Web.Optimization;
using Site.App_Start;
using Site.Infrastructure;
using Site.Models;

namespace Site
{
    public class GlobalApp : HttpApplication
    {
        //private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        void Application_Start(object sender, EventArgs e)
        {
            //logger.Info("Application Start");
            // Код, выполняемый при запуске приложения
            //AreaRegistration.RegisterAllAreas();

            var adminArea = new AdminAreaRegistration();
            var adminAreaContext = new AreaRegistrationContext(adminArea.AreaName, RouteTable.Routes);
            adminArea.RegisterArea(adminAreaContext);

            var defaultArea = new DefaultAreaRegistration();
            var defaultAreaContext = new AreaRegistrationContext(defaultArea.AreaName, RouteTable.Routes);
            defaultArea.RegisterArea(defaultAreaContext);

            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ModelBinders.Binders.Add(typeof(Cart), new CartModelBinder());

        }
        public override void Init()
        {
            //logger.Info("Application Init");
        }

        public override void Dispose()
        {
            //logger.Info("Application Dispose");
        }

        protected void Application_Error()
        {
            //logger.Info("Application Error");
        }


        protected void Application_End()
        {
           // logger.Info("Application End");
        }
    }
}