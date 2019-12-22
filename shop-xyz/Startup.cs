using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(shop_xyz.Startup))]
namespace shop_xyz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
