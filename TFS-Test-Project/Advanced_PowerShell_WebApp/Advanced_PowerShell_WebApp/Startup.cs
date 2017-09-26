using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Advanced_PowerShell_WebApp.Startup))]
namespace Advanced_PowerShell_WebApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
