using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Codly.Startup))]
namespace Codly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
