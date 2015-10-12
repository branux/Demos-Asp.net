using Microsoft.Owin.Hosting;
using Owin;
using System;
using System.Web.Http;

/*
    1. Instalar:
    - Microsoft.Owin.Hosting
    - Microsoft.Owin.Host.HttpListener
    - Microsoft.Owin.Diagnostics
    - Microsoft.AspNet.WebApi.Owin

    2. Criar o controller

    3. Configurar rota

    Testar qualquer url
    Testar ApiController: localhost/api/mensagem
*/


namespace OwinComWebApi
{
    class Program
    {
        static void Main(string[] args)
        {
            var uri = "http://localhost:8080";

            using (WebApp.Start<Startup>(uri))
            {
                Console.WriteLine("Host Iniciado!");
                Console.ReadKey();
                Console.WriteLine("Host Finalizado");
            }
        }
    }

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigurarLog(app);
            ConfigurarWebApi(app);
            app.UseWelcomePage();
        }

        private void ConfigurarLog(IAppBuilder app)
        {
            app.Use(async (environment, next) =>
            {
                Console.WriteLine("Requisição: {0}", environment.Request.Path);
                await next();
                Console.WriteLine("Resposta: {0}", environment.Response.StatusCode);
            });
        }

        private void ConfigurarWebApi(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.Routes
                .MapHttpRoute(
                    "DefaultApi",
                    "api/{controller}/{id}",
                    new { id = RouteParameter.Optional }
                );
            app.UseWebApi(config);
        }
    }
}
