using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebIdentityDemo.Startup))]
namespace WebIdentityDemo
{
    //i hate dotnet
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
