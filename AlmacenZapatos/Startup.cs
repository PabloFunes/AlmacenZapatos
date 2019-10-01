using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlmacenZapatos.Startup))]
namespace AlmacenZapatos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
