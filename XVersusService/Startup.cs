using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XVersusService.Startup))]
namespace XVersusService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
