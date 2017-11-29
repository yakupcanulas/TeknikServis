using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Teknik.MVC.Startup))]
namespace Teknik.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
