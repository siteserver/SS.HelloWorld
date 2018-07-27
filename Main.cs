using SiteServer.Plugin;

namespace SS.HelloWorld
{
    public class Main : PluginBase
    {
        public override void Startup(IService service)
        {
            service.AddSiteMenu(siteId => new Menu
            {
                Text = "Hello World",
                Href = "index.html"
            });
        }
    }
}
