using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PortFolioWeb.Startup))]
namespace PortFolioWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
