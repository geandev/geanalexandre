using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace GeanAlexandre.Api.Config
{
    public static class Cors
    {
        private const string CorsPolicyName = "AllowAllOrigins";

        public static void AllowAllCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(CorsPolicyName,
                    builder =>
                    {
                        builder
                            .AllowAnyOrigin()
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    }
                );
            });
        }

        public static void UseAllowAllCors(this IApplicationBuilder app)
        {
            app.UseCors(CorsPolicyName);
        }
    }
}