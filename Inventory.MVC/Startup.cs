using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Inventory.MVC.Startup))]
namespace Inventory.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
