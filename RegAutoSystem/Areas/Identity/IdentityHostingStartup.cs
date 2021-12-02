using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RegAutoSystem.Areas.Identity.Data;
using RegAutoSystem.Data;

[assembly: HostingStartup(typeof(RegAutoSystem.Areas.Identity.IdentityHostingStartup))]
namespace RegAutoSystem.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<RegAutoSystemContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("RegAutoSystemContextConnection")));

                services.AddDefaultIdentity<RegAutoSystemUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<RegAutoSystemContext>();
            });
        }
    }
}