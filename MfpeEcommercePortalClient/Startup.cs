using EcommercePortalClient.Models;
using EcommercePortalClient.Provider;
using EcommercePortalClient.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommercePortalClient
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddTransient<IAuthProvider, AuthProvider>();
            services.AddTransient<IProductProvider, ProductProvider>();
            services.AddTransient<ICartRepository, CartRepository>();
            services.AddDbContextPool<CartDbContext>(
          options => options.UseSqlServer(Configuration.GetConnectionString("constr")));
            services.AddTransient<IProceedToBuyProvider, ProceedToBuyProvider>();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(15);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
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
            loggerFactory.AddLog4Net();

            app.UseRouting();
            app.UseSession();
            app.UseAuthorization();
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
