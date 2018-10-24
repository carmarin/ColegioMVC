using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ColegioApp.Startup))]
namespace ColegioApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
