using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dinlun.GatewaySite.HouTaiManager.Startup))]
namespace Dinlun.GatewaySite.HouTaiManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
