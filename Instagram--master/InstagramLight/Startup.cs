using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InstagramLight.Startup))]
namespace InstagramLight
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
