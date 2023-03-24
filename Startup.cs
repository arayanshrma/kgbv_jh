using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(kgbvjh.Startup))]
namespace kgbvjh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
