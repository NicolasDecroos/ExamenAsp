using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Opdracht2.Startup))]
namespace Opdracht2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
