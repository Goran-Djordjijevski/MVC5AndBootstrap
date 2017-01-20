using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5AndBootstrap.Startup))]
namespace MVC5AndBootstrap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
