using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(syseng.Web.Startup))]
namespace syseng.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
