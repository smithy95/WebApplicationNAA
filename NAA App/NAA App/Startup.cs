using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NAA_App.Startup))]
namespace NAA_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
