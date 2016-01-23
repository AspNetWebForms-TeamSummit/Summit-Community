using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SummitCommunity.Startup))]
namespace SummitCommunity
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
