using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Filter.Startup))]
namespace MVC_Filter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
