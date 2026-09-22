using ProductCatalogApp;
using System.Web.Mvc;
using System.Web.Routing;

namespace Practical_6  // Ya ProductCatalogApp (Jo aapke Global.asax me likha ho)
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}