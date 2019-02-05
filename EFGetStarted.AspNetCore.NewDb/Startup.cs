using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using EFGetStarted.AspNetCore.NewDb.Data;

namespace EFGetStarted.AspNetCore.NewDb
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            var builder = new ConfigurationBuilder().AddJsonFile("apptest.json");
           
            
        }
        public IConfiguration configuration2{ get; set; }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
              services.AddDbContext<BloggingContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            
            services.AddMvc();
        }



        

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
           
               if (env.IsDevelopment())
            {
                
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            
            app.UseDefaultFiles(); // will BY DEFAULT DISPLAY THE HTML PAGE
            app.UseStaticFiles(); // will display static files if appointed to
            app.UseFileServer(); //default files and static files in correct order using System;
            app.UseDirectoryBrowser(); // browse directory'
            

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

           
        
        }
    }
}
