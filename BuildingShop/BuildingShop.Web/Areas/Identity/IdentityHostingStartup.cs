using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(BuildingShop.Web.Areas.Identity.IdentityHostingStartup))]
namespace BuildingShop.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}