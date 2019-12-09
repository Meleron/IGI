using Blogger.Models;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using Blogger.SignalR;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Options;

namespace Blogger
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
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
                options.LoginPath = new PathString("/Auth/Login");
            });
            services.AddDbContext<ApiDbContext>();
            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.AddMvc().AddFluentValidation().AddViewLocalization(options => options.ResourcesPath = "Resources");
            services.AddAutoMapper();
            services.AddSignalR();
            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new[]
                {
                    new CultureInfo("en"),
                    new CultureInfo("ru")
                };
                options.DefaultRequestCulture = new RequestCulture("ru");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            var locOptions = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
            app.UseRequestLocalization(locOptions.Value);
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseSignalR(routes =>
            {
                routes.MapHub<AlertHub>("/alert");
            });
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                        name: "root",
                        template: "{action}/{id?}",
                        defaults: new { controller = "Home", action = "Index" });

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
