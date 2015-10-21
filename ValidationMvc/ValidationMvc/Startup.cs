using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ValidationMvc.Startup))]
namespace ValidationMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
