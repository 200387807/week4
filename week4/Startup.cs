using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(week4.Startup))]
namespace week4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
