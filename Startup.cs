using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(chatter.Startup))]
namespace chatter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
