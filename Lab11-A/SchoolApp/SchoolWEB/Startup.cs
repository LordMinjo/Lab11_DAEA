using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SchoolWEB.Startup))]
namespace SchoolWEB
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
