using GeanAlexandre.Api.Config;
using GeanAlexandre.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GeanAlexandre.Api
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IHostingEnvironment env)
        {
            _configuration = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", true, true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true)
                .AddEnvironmentVariables()
                .Build();
        }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AllowAllCors();
            services.ConfigureGeanAlexandreContext(Settings.Configure(_configuration));
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebpackDevMiddleware();
            }

            app.UseMvcWithDefaultRoute();
            app.UseAllowAllCors();
            app.UseDefaultFiles();
            app.UseStaticFiles();
        }
    }
}