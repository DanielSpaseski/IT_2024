using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab3_MVC_A.Startup))]
namespace Lab3_MVC_A
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
