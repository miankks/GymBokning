using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ovning17.Startup))]
namespace Ovning17
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
