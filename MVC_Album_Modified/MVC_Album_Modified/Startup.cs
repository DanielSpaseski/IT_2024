using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Album_Modified.Startup))]
namespace MVC_Album_Modified
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
