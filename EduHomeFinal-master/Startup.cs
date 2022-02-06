using EduHomeFinal.DAL;
using EduHomeFinal.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal
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
            services.AddIdentity<AppUser, IdentityRole>(identityoptions =>
            {
                identityoptions.Password.RequiredLength = 6;
                identityoptions.Password.RequireDigit = true;
                identityoptions.Password.RequireUppercase = false;
                identityoptions.Password.RequireNonAlphanumeric = false;
                identityoptions.Password.RequireLowercase = true;

                identityoptions.Lockout.MaxFailedAccessAttempts = 5;
                identityoptions.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                identityoptions.Lockout.AllowedForNewUsers = true;

                identityoptions.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<EduDb>().AddDefaultTokenProviders();

            services.AddDbContext<EduDb>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("Default"));
            });
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                        name: "areas",
                        pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
                );
        
                endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Home}/{action=Index}/{id?}"
                    );
            });
        }
    }
}
