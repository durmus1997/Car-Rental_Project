using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KiralamaProjesi.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace KiralamaProjesi
{
    public class Startup
    {
        private IConfiguration _configration;

        public Startup(IConfiguration configration)
        {
            _configration = configration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<KiralamaDbContext>(options => options.UseSqlServer(_configration["ConnectionStrings:DefaultConnection"]));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            app.UseStaticFiles();
            app.UseMvc(ConfigureRoutes);
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            DbInitializer.InitializeDb(app);


        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute("default", "{controller=home}/{action=index}/{id?}");
        }
    }
}
