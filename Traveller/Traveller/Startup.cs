using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Traveller.Startup))]
namespace Traveller
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
