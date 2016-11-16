using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SNHMVCWebApp.Startup))]
namespace SNHMVCWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
