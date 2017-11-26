using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyStore.UI.Startup))]
namespace MyStore.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
