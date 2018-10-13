using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BSbook.Startup))]
namespace BSbook
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
