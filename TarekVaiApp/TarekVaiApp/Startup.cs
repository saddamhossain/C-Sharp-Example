using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TarekVaiApp.Startup))]
namespace TarekVaiApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
