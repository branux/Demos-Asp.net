using System.Web.Http;
using System.Web.Http.Cors;

namespace DemoCORS.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            //var cors = new EnableCorsAttribute("*","*","GET");
            //config.EnableCors(cors);
            //Substitui pelo filtro [EnableCors("*","*","GET")]
            var cors = new EnableCorsAttribute(
            origins: "*",
            headers: "*",
            methods: "*");
            config.EnableCors(cors);


            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
