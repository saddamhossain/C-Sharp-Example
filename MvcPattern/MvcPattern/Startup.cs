using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcPattern.Startup))]
namespace MvcPattern
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
