using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MatsDevOpsTraining.Startup))]
namespace MatsDevOpsTraining
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
