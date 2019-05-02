using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hostal.Vista.Startup))]
namespace Hostal.Vista
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
