using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Lab3_ExamVersion.Startup))]
namespace MVC_Lab3_ExamVersion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
