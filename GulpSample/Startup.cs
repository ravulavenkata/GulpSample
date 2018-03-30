using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GulpSample.Startup))]
namespace GulpSample
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
