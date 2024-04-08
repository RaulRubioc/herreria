using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(herreria.Startup))]
namespace herreria
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
