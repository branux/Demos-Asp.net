using Microsoft.Owin.Hosting;
using Owin;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;

namespace HelloWorldComponent
{
    using AppFunc = Func<IDictionary<string, object>, Task>;

    class Program
    {
        static void Main(string[] args)
        {

            var uri = "http://localhost:8080";
            using (WebApp.Start<Startup>(uri))
            {
                Console.WriteLine("App Started..");
                Console.ReadKey();
                Console.WriteLine("App Stopping..");
            }

        }
    }


    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //app.Use<HelloWorldComponent>(); ou
            app.UseHelloWorld();
        }
    }

    #region Componente que adiciona um response à todas as requisições ao pipeline

    public class HelloWorldComponent
    {
        private readonly AppFunc _next;

        public HelloWorldComponent(AppFunc next)
        {
            _next = next;
        }

        public Task Invoke(IDictionary<string, object> ambiente)
        {
            var response = ambiente["owin.ResponseBody"] as Stream;
            using (var writer = new StreamWriter(response))
            {
                return writer.WriteAsync("Hello Component!");
            }
        }
    }

    #endregion

    #region Método de Extensão p/ o IAppBuilder
    public static class AppBuilderExtensions
    {
        public static void UseHelloWorld(this IAppBuilder app)
        {
            app.Use<HelloWorldComponent>();
        }
    }
    #endregion

}
