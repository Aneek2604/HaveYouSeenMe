using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HYSM.Startup))]
namespace HYSM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
