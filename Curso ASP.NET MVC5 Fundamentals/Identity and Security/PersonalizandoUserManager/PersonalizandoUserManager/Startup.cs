using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersonalizandoUserManager.Startup))]
namespace PersonalizandoUserManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
