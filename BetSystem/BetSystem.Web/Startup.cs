using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BetSystem.Web.Startup))]
namespace BetSystem.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
