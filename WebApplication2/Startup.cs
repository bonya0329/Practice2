using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebApplication2.Data;

namespace WebApplication2
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MoviesContext>(options =>
            {
                options.UseSqlite("Filename=movies.db");
            });
            services.AddMvc();
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "calculator",
                    template: "Calculator/{action}/{number:int}",
                    defaults: new { Controller = "Calculator" });

                routes.MapRoute(
                    name: "messages",
                    template: "say/{**message}",
                    defaults: new { controller = "Messages", action = "ShowMessage" });

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Hello}/{action=Index}/{id?}");
            });

            app.UseStaticFiles();
        }
    }
}
