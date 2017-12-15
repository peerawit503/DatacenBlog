using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DsBlog.Startup))]
namespace DsBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
