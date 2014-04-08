using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(longan1.Startup))]
namespace longan1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
