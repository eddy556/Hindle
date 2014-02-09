using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KindleHighlights.Startup))]
namespace KindleHighlights
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
