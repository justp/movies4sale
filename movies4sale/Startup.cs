using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(movies4sale.Startup))]
namespace movies4sale
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
