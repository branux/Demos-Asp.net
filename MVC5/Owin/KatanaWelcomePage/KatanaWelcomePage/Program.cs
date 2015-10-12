using Microsoft.Owin.Hosting;
using Owin;
using System;

namespace KatanaWelcomePage
{
    class Program
    {
        static void Main(string[] args)
        {
            var uri = "http://localhost:8080";

            using (WebApp.Start<Startup>(uri))
            {
                Console.WriteLine("Iniciando a aplicação!");
                Console.ReadKey();
                Console.WriteLine("Finalizando a aplicação!");
            }
        }
    }

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseWelcomePage();
        }
    }
}
