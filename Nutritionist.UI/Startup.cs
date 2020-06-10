using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Nutritionist.UI
{
    public class Startup
    {

        public static bool[] MongoWatch = { false, false, false, false, false, false, false, false, false };//Alarm,Main,Sub1,Sub2,Sub3,Sub4 Categories,Client,Login,SessionTimeout
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMemoryCache();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(20);
            });

            services.AddDistributedMemoryCache();
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddSignalR(options =>
            {
                options.EnableDetailedErrors = true;
            });






        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        [Obsolete]
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseMvc(routes =>
            {
                routes.MapRoute("start", "", new { controller = "Start", action = "Index" }); 
                routes.MapRoute("anasayfa", "anasayfa", new { controller = "Home", action = "Index" });

                routes.MapRoute("login", "login", new { controller = "Login", action = "Index" });

                routes.MapRoute("log", "log", new { controller = "Login", action = "Login" }); //Register
                routes.MapRoute("logg", "logg", new { controller = "Login", action = "ReallyLogin" }); //Logina

                routes.MapRoute("LogOut", "exit", new { controller = "LogOut", action = "LogOut" }); //


                routes.MapRoute("addProduct", "add-product", new { controller = "AddList", action = "Index" }); //Add Product
                routes.MapRoute("Product", "product", new { controller = "AddList", action = "AddProduct" }); //Add Product
                routes.MapRoute("DeleteProduct", "deleteProduct", new { controller = "AddList", action = "DeleteProduct" }); //Add Product

                routes.MapRoute("Basket", "basket", new { controller = "Basket", action = "Index" }); //Add Product
                routes.MapRoute("BasketAdd", "add-basket", new { controller = "Basket", action = "AddBasket" }); //Add Product
            });

        }
    }
}
