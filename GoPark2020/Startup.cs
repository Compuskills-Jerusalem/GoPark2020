using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoPark2020.Startup))]
namespace GoPark2020
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
