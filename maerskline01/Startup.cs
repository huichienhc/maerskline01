using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(maerskline01.Startup))]
namespace maerskline01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
