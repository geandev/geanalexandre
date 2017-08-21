using GeanAlexandre.Context.Settings;
using Microsoft.Extensions.Configuration;

namespace GeanAlexandre.Api
{
    public class Settings : IMongoSettings
    {
        public string ConnectionString { get; }

        private Settings(IConfiguration configuration)
        {
            ConnectionString = configuration.GetConnectionString("Mongo");
        }

        public static Settings Configure(IConfiguration configuration) => new Settings(configuration);
    }
}