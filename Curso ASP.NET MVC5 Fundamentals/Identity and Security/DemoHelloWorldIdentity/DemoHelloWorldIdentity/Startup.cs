using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoHelloWorldIdentity.Startup))]
namespace DemoHelloWorldIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
