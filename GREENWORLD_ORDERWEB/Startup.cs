using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GREENWORLD_ORDERWEB.Startup))]
namespace GREENWORLD_ORDERWEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
