using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dinlun.GatewaySite.WebPoint.Startup))]
namespace Dinlun.GatewaySite.WebPoint
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
