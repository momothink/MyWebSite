using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cmomo.Startup))]
namespace cmomo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
