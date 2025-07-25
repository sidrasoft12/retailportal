﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Razor;
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

            //services.AddRazorPages(o=>
            //{
            //    o.Conventions.AddPageRoute("/login", "");
            //});
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
            app.UseSession(); // Enable session middleware
            app.UseAuthorization();
           

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllerRoute(
          name: "default",
          pattern: "{controller=Panel}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "Panel",
                    pattern: "Login/{agent_id}",
                    defaults: new { controller = "Account", action = "Login" });
                endpoints.MapControllerRoute(
                    name: "login",
                    pattern: "Login/{agent_id}",
                    defaults: new { controller = "Account", action = "Login" });
                endpoints.MapControllerRoute(
                    name: "gmQuotations",
                    pattern: "/GMQuotation/{action=Index}");
                endpoints.MapControllerRoute(
                    name: "Members",
                    pattern: "/Member/{action=Index}");
                endpoints.MapControllerRoute(
                    name: "product",
                    pattern: "/Product/{action=Index}");
                endpoints.MapControllerRoute(
                    name: "memberdetails",
                    pattern: "/Member/{action=_MemberDetails}");


            });
        }
    }
}

