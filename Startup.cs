using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FrogMusicFest.Startup))]
namespace FrogMusicFest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
