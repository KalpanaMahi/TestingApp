using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestingApp.Startup))]
namespace TestingApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
