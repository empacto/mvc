﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using EFGetStarted.AspNetCore.NewDb.Data;
using EFGetStarted.AspNetCore.NewDb.Services;
using Microsoft.Extensions.Logging;


namespace EFGetStarted.AspNetCore.NewDb
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
            
              services.AddDbContext<BloggingContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

         services.AddDbContext<OdeToFoodDBContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            
            
            services.AddMvc();
            services.AddScoped<IRestaurantData,InMemoryRestaurantData>();
            services.AddScoped<IFactoryData,InMemoryFactoryData>();
            services.AddScoped<ICar,InMemoryCarData>();
            services.AddScoped<IShop,InMemoryShopData>();
            
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

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
