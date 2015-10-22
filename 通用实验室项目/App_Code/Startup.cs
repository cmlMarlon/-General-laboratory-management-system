using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(通用实验室.Startup))]
namespace 通用实验室
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
