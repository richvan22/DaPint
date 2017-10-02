using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DaPint.Startup))]
namespace DaPint
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
