using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using PrimeNGApplication.Data;
using PrimeNGApplication.Repository;
using PrimeNGApplication.Interface;

namespace PrimeNGApplication
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<AdventureworksContext>(options => options.UseSqlServer(("AdventureWorks")));
            services.AddAutoMapper();
            services.AddScoped<IStoreRepository, StoreRepository>();

            services.AddCors(cfg =>
            {
                cfg.AddPolicy("MyApplication", bldr =>
                {
                    bldr.AllowAnyHeader()
                        .AllowAnyMethod();
                });

                cfg.AddPolicy("AnyGET", bldr =>
                {
                    bldr.AllowAnyHeader()
                       .AllowAnyMethod()
                        .AllowAnyOrigin();
                });
            });
            services.AddMvc(opt =>
            {
                opt.Filters.Add(new RequireHttpsAttribute());
            })
           .AddJsonOptions(opt =>
           {
               opt.SerializerSettings.ReferenceLoopHandling =
                 ReferenceLoopHandling.Ignore;
           });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();
            //app.UseDeveloperExceptionPage();
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UseExceptionHandler(appBuilder =>
            //    {
            //        appBuilder.Run(async context =>
            //        {
            //            var exceptionHandlerFeature = context.Features.Get<IExceptionHandlerFeature>();
            //            if (exceptionHandlerFeature != null)
            //            {
            //                var logger = loggerFactory.CreateLogger("Global exception logger");
            //                logger.LogError(500,
            //                    exceptionHandlerFeature.Error,
            //                    exceptionHandlerFeature.Error.Message);
            //            }

            //            context.Response.StatusCode = 500;
            //            await context.Response.WriteAsync("An unexpected fault happened. Try again later.");

            //        });
            //    });
            //}

            app.UseMvc();
        }
    }
}
