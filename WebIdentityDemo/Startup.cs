using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebIdentityDemo.Startup))]
namespace WebIdentityDemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
