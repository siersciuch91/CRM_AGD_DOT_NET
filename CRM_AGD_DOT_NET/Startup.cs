using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRM_AGD_DOT_NET.Startup))]
namespace CRM_AGD_DOT_NET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
