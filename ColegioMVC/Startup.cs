using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ColegioMVC.Startup))]
namespace ColegioMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
