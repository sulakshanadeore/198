using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace ServerSideStateMgtDemo
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["cnt"] = 0;
        }

        void Application_End(object sender, EventArgs e)
        {

        }

        void Session_Start(object sender, EventArgs e)
        {
            //    HttpContext.Current.Session["v1"] = 100;
            Application["cnt"] = Convert.ToInt32(Application["cnt"]) + 1;

        }

        void Session_End(object sender, EventArgs e)
        {
            //Response.Write(Session["username"].ToString());

            Session.Clear();
            //Session.Remove("username");
            //Session.RemoveAll();
            // Session.RemoveAt()




            Session.RemoveAll();//RemoveAt,RemoveAll()
            Session.Abandon();

        }     
        
        void Application_Error(object sender, EventArgs e)
        {
        }
    }
}