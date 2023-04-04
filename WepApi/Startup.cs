using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepApi
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
            services.AddDbContext<Context>();

            services.AddScoped<IAboutDal, EfAboutDal>();
            services.AddScoped<IAboutService, AboutManager>();

            services.AddScoped<IChefDal, EfChefDal>();
            services.AddScoped<IChefService, ChefManager>();

            services.AddScoped<IContactDal, EfContactDal>();
            services.AddScoped<IContactService, ContactManager>();

            services.AddScoped<IFoodDal, EfFoodDal>();
            services.AddScoped<IFoodService, FoodManager>();

            services.AddScoped<IFood2Dal, EfFood2Dal>();
            services.AddScoped<IFood2Service, Food2Manager>();

            services.AddScoped<IFood3Dal, EfFood3Dal>();
            services.AddScoped<IFood3Service, Food3Manager>();

            services.AddScoped<IFood4Dal, EfFood4Dal>();
            services.AddScoped<IFood4Service, Food4Manager>();

            services.AddScoped<IFood5Dal, EfFood5Dal>();
            services.AddScoped<IFood5Service, Food5Manager>();

            services.AddScoped<IHomePageDal, EfHomePageDal>();
            services.AddScoped<IHomePageService, HomePageManager>();

            services.AddScoped<IServiceDal, EfServiceDal>();
            services.AddScoped<IServiceService, ServiceManager>();

            services.AddScoped<ISocialDal, EfSocialDal>();
            services.AddScoped<ISocialService, SocialManager>();

            services.AddCors(opt =>
            {
                opt.AddPolicy("MimozaApiCors", opts =>
                {
                    opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WepApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WepApi v1"));
            }



            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
