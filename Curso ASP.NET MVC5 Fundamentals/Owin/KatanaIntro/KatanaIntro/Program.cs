using Microsoft.Owin.Hosting;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatanaIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            var uri = "http://localhost:8080";

            //classe estática que recebe a classe com as configurações da aplicação e a url
            using (WebApp.Start<AmbienteKatana>(uri))
            {
                Console.WriteLine("Host Iniciado!");
                Console.ReadKey();
                Console.WriteLine("Host Finalizado");
            }
        }
    }

    public class AmbienteKatana
    {
        //Obrigatório ter o método void Configuration
        public void Configuration(IAppBuilder app)
        {
            //responde a requisição http://localhost:8080/ 
            app.Run(ctx =>
            {
                return ctx.Response.WriteAsync("Hello World in Katana!");
            });
        }
    }
}
