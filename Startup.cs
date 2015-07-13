using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EasyFarm.Startup))]
namespace EasyFarm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
