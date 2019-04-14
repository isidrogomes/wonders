using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wonders.Startup))]
namespace Wonders
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
