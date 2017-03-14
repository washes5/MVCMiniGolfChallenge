using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCMiniGolfChallenge.Startup))]
namespace MVCMiniGolfChallenge
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
