using Microsoft.Owin;
using Owin;
using System.Web.Http;
using System.Web.Routing;

[assembly: OwinStartupAttribute(typeof(WebSite1.Startup))]
namespace WebSite1
{
    public partial class Startup
    {

        public Startup()
        {

            RouteTable.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = System.Web.Http.RouteParameter.Optional }
            );
        }

        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
