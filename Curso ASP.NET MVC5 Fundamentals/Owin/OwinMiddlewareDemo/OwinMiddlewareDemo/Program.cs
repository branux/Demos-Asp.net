using Microsoft.Owin.Hosting;
using Owin;
using System;


namespace OwinMiddlewareDemo
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

            //Listando todo o pipeline
            app.Use(async (environment, next) =>
            {
                foreach (var pair in environment.Environment)
                {
                    Console.WriteLine("{0} : {1}", pair.Key, pair.Value);
                }

                await next();
            });

            //Exibindo o que foi requisitado e a resposta
            app.Use(async (environment, next) =>
            {
                Console.WriteLine("Requisição: {0}", environment.Request.Path);
                await next();
                Console.WriteLine("Resposta: {0}", environment.Response.StatusCode);
            });

            app.Run(ctx =>
            {
                return ctx.Response.WriteAsync("Fim!");
            });

        }
    }
}
