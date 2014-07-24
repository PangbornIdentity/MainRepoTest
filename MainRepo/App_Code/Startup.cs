using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MainRepoTest.Startup))]
namespace MainRepoTest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
