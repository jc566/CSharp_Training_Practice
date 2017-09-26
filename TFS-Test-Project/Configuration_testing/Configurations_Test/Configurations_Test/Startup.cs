using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Configurations_Test.Startup))]
namespace Configurations_Test
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
