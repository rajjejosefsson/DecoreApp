using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DecoreApp.Startup))]
namespace DecoreApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

        }
    }
}
