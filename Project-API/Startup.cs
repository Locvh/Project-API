using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Project_API.Models;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitOfWorkPattern.Repositories;

namespace Project_API
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

           // services.AddDbContext<CarRentalContext>(options => options.UseSqlServer(Configuration["Database:ConnectionString"]));

           // services.AddDbContext<CarRentalContext>(options => options.UseInMemoryDatabase(Guid.NewGuid().ToString()));
           // services.AddDbContext<CarRentalContext>(o => o.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<CarRentalContext>(options => options.UseSqlServer(Configuration["Database:ConnectionString"]));
            services.AddDbContext<CarRentalContext>(options => options.UseInMemoryDatabase(Guid.NewGuid().ToString()));
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));

            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<IGarageRepository, GarageRepository>();

            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IGarageService, GarageService>();

            services.AddControllersWithViews();

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("V1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "CarRental",
                    Description = "Api for Project",
                    Version = "1.0"
                });
            }
          );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

            });

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/V1/swagger.json", "Swagger demo");
            }
            );
        }
    }
}
