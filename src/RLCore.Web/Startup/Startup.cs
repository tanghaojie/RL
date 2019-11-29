using Abp.AspNetCore;
using Abp.Castle.Logging.Log4Net;
using Abp.EntityFrameworkCore;
using Castle.Facilities.Logging;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RLCore.Configuration;
using RLCore.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace RLCore.Web.Startup
{
    public class Startup
    {
        private readonly IConfigurationRoot _appConfiguration;
        public Startup(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            //Configure DbContext
            services.AddAbpDbContext<RLCoreDbContext>(options => { DbContextOptionsConfigurer.Configure(options.DbContextOptions, options.ConnectionString); });

            MvcConfigurer.Configure(services);
            CorsConfigurer.Configure(services);
            AuthConfigurer.Configure(services, _appConfiguration);
            SwagConfigurer.Configure(services);

            //Configure Abp and Dependency Injection
            return services.AddAbp<RLCoreWebModule>(options =>
            {
                //Configure Log4Net logging
                options.IocManager.IocContainer.AddFacility<LoggingFacility>(
                    f => f.UseAbpLog4Net().WithConfig("log4net.config")
                );
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseAbp(); //Initializes ABP framework.
            app.UseAuthentication();
            app.UseStaticFiles();
            if (env.IsDevelopment())
            {
                ExceptionHandlerConfigurer.UseDev(app);
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            CorsConfigurer.Use(app);
            MvcConfigurer.Use(app);
            SwagConfigurer.Use(app);
        }
    }
}
