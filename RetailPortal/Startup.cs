﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RetailPortal.Models;

namespace RetailPortal
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
            services.AddControllersWithViews();
            services.AddSession();
            services.AddTransient<GMQuotations>();// Add session services
            services.AddTransient<Members>();// Add session services
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseSession(); // Enable session middleware

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Account}/{action=Login}/{agent_id?}");
                endpoints.MapControllerRoute(
                   name: "gmQuotations",
                   pattern: "{agent_id}/GMQuotations/{action=Index}");
                endpoints.MapControllerRoute(
                   name: "Members",
                   pattern: "{agent_id}/Members/{action=Index}");
                endpoints.MapControllerRoute(
                   name: "product",
                   pattern: "{agent_id}/Product/{action=Index}");
            });
        }
    }
}

