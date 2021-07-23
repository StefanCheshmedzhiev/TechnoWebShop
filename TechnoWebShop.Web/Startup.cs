
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using TechnoWebShop.Data;
using TechnoWebShop.Data.Models;

namespace TechnoWebShop.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<TechnoWebShopDbContext>(options =>
                 options.UseSqlServer(
                     Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<WebShopUser, IdentityRole>()
                .AddEntityFrameworkStores<TechnoWebShopDbContext>()
                .AddDefaultTokenProviders();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetRequiredService<TechnoWebShopDbContext>())
                {
                    context.Database.EnsureCreated();

                    if (!context.Roles.Any())
                    {
                        context.Roles.Add(new IdentityRole
                        {
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });

                        context.Roles.Add(new IdentityRole
                        {
                            Name = "User",
                            NormalizedName = "USER"
                        });

                        context.SaveChanges();
                    }
                }
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
                app.UseHsts();
                app.UseHttpsRedirection();
                app.UseStaticFiles();

                app.UseAuthentication();

                app.UseMvc(routes =>
                {
                    routes.MapRoute(
                    name: "areas",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                    routes.MapRoute(
                        name: "default",
                        template: "{controller=Home}/{action=Index}/{id?}");
                });
            }
        }
    }
}
