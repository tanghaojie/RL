using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace RLCore.Web.Startup
{
    public class SwagConfigurer
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.AddSecurityRequirement(new Dictionary<string, IEnumerable<string>> { { "Bearer", new string[] { } }, });

                options.SwaggerDoc("v1", new Info
                {
                    Title = "RLCore API",
                    Version = "v1",
                    Description = "接口文档说明",
                    TermsOfService = "None",
                });
                options.DocInclusionPredicate((docName, description) => true);

                options.AddSecurityDefinition("Bearer", new ApiKeyScheme()
                {
                    Description = "Bearer {token}",
                    Name = "Authorization",
                    In = "header",
                    Type = "apiKey"
                });

                options.CustomSchemaIds(x => x.FullName);
            });
        }

        public static void Use(IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "RLCore API V1");
                options.IndexStream = () => Assembly.GetExecutingAssembly().GetManifestResourceStream("RLCore.Web.wwwroot.swagger.ui.index.html");
            });
        }
    }
}
