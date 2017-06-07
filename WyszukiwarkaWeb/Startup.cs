using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WyszukiwarkaWeb.Startup))]
namespace WyszukiwarkaWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
