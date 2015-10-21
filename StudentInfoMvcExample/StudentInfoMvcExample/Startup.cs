using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentInfoMvcExample.Startup))]
namespace StudentInfoMvcExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
