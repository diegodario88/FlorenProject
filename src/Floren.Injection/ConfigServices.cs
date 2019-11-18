using Floren.Data.EntityFramework;
using Floren.Data.EntityFramework.Repositories;
using Floren.Domain.Contracts.Repositories;
using Floren.Services;
using Microsoft.Extensions.DependencyInjection;






namespace Floren.Injection
{
    public static class ConfigServices
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            //  Diferença no ciclo de vida do objeto:

            //  Instância única em todo projeto.
            //  services.AddSingleton<>();

            //  Escopo por requisição 
            //  services.AddScoped<>();

            //  Por chamada
            //  services.AddTransient<>();

            services.AddScoped<FlorenDataContext>();
            services.AddTransient<IFarmaciaRepository, FarmaciaRepositoryEF>();
            services.AddTransient<IPlantaoRepository, PlantaoRepositoryEF>();
            services.AddTransient<IPlantaoService, PlantaoService>();

        }
    }
}