using GeanAlexandre.Context.Domain.CommandHandler;
using GeanAlexandre.Context.Domain.QueryHandler;
using GeanAlexandre.Context.Domain.Repository;
using GeanAlexandre.Context.Domain.Uow;
using GeanAlexandre.Context.Infra.Database;
using GeanAlexandre.Context.Infra.Repository;
using GeanAlexandre.Context.Settings;
using Microsoft.Extensions.DependencyInjection;

namespace GeanAlexandre.Context.Infra.CrossCutting.IoC
{
    public class DependencyInject
    {
        private readonly IServiceCollection _serviceCollection;

        public DependencyInject(IServiceCollection serviceCollection)
        {
            _serviceCollection = serviceCollection;
        }

        public void Resolve<TSettings>(TSettings settings)
            where TSettings : IMongoSettings
        {
            ResolveSettings(settings)
                .ResolveDatabase()
                .ResolveUow()
                .ResolveRepositories()
                .ResolveCommands()
                .ResolveQueries();
        }


        private DependencyInject ResolveSettings(IMongoSettings mongoSettings)
        {
            _serviceCollection.AddSingleton<IMongoSettings>(mongoSettings);
            return this;
        }

        private DependencyInject ResolveDatabase()
        {
            
            _serviceCollection.AddSingleton<IMemoryDatabase, MemoryDatabase>();
            return this;
        }

        private DependencyInject ResolveUow()
        {
            _serviceCollection.AddSingleton<IUow, Uow.UowMemory>();
            return this;
        }

        private DependencyInject ResolveRepositories()
        {
            _serviceCollection.AddScoped<IUserRepository, UserMemoryRepository>();
            return this;
        }

        private DependencyInject ResolveCommands()
        {
            _serviceCollection.AddScoped<ICreateResumeCommandHandler, CreateResumeCommandHandler>();
            return this;
        }

        private DependencyInject ResolveQueries()
        {
            _serviceCollection.AddScoped<IGetUserQueryHandler, GetUserQueryHandler>();
            return this;
        }
    }
}