using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DZ3.Startup))]
namespace DZ3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
