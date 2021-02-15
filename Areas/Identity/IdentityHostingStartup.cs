using System;
using EBookShop.Areas.Identity.Data;
using EBookShop.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(EBookShop.Areas.Identity.IdentityHostingStartup))]
namespace EBookShop.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<EBookShopAuthContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("EBookShopAuthContextConnection")));

                services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<EBookShopAuthContext>();
            });
        }
    }
}