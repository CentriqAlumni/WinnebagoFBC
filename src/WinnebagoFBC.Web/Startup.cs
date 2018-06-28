using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WinnebagoFBC.Web.Startup))]
namespace WinnebagoFBC.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
