using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MelWebApp.Startup))]
namespace MelWebApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
