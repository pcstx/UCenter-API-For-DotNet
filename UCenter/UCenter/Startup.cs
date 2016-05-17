using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UCenter.Startup))]
namespace UCenter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
