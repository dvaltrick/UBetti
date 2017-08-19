using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ubetti.Startup))]
namespace Ubetti
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
