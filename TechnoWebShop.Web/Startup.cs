
using CloudinaryDotNet;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using System.Linq;
using System.Reflection;
using TechnoWebShop.Data;
using TechnoWebShop.Data.Models;
using TechnoWebShop.Services;
using TechnoWebShop.Services.Mapping;
using TechnoWebShop.Services.Models;
using TechnoWebShop.Web.InputModels;
using TechnoWebShop.Web.ViewModels.Home.Index;

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
            Account cloudinaryCredentials = new Account(
                this.Configuration["Cloudinary:CloudName"],
                this.Configuration["Cloudinary:ApiKey"],
                this.Configuration["Cloudinary:ApiSecret"]);

            Cloudinary cloudinaryUtility = new Cloudinary(cloudinaryCredentials);

            services.AddSingleton(cloudinaryUtility);
            services.Configure<IdentityOptions>(options =>
            {
                // Password settings.
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 3;
                options.Password.RequiredUniqueChars = 0;

                options.User.RequireUniqueEmail = true;
            });
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IReceiptService, ReceiptService>();
            services.AddTransient<ICloudinaryService, CloudinaryService>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                AutoMapperConfig.RegisterMappings(
                typeof(ProductCreateInputModel).GetTypeInfo().Assembly,
                typeof(ProductHomeViewModel).GetTypeInfo().Assembly,
                typeof(ProductServiceModel).GetTypeInfo().Assembly);

                CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
                CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

                using (var service = app.ApplicationServices.CreateScope())
                {
                    using (var context = service.ServiceProvider.GetRequiredService<TechnoWebShopDbContext>())
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

                        if (!context.OrderStatuses.Any())
                        {
                            context.OrderStatuses.Add(new OrderStatus
                            {
                                Name = "Active"
                            });

                            context.OrderStatuses.Add(new OrderStatus
                            {
                                Name = "Completed"
                            });

                            context.SaveChanges();
                        }
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
