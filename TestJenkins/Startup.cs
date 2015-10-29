using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestJenkins.Startup))]
namespace TestJenkins
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
