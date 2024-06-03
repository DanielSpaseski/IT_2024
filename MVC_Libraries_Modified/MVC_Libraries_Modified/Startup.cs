using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Libraries_Modified.Startup))]
namespace MVC_Libraries_Modified
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
