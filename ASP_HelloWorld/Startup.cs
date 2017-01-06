using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP_HelloWorld.Startup))]
namespace ASP_HelloWorld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
