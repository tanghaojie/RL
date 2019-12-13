using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Abp.Authorization;
using System.Net;
using Abp.Web.Models;
using Abp.Events.Bus.Exceptions;
using Abp.AspNetCore.Mvc.Results;
using Abp.AspNetCore.Mvc.Extensions;
using Abp.Logging;
using AutoMapper.Internal;
using Castle.Core.Logging;
using Abp.Events.Bus;
using Abp.AspNetCore.Configuration;
using Abp.Dependency;
using Abp.Runtime.Validation;
using Abp.Domain.Entities;

namespace RLCore.Web.Startup
{
    public class MvcConfigurer
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddMvc(options =>
            {
                //options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
                options.Filters.AddService(typeof(JTAbpExceptionFilter), 1);
            });
        }

        public static void Use(IApplicationBuilder app)
        {
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
