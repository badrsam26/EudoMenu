using EudoMenu.Application.Contracts;
using EudoMenu.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EudoMenu.Persistence
{
    public static class PersistenceContainer
    {

        // enregistrement des depencies de persistence
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            // enregistrement de la chaine de connexion pour la base des données SQLSERVER
            services.AddDbContext<EudoMenuDbContext>(options => 
                                    options.UseSqlServer (configuration.GetConnectionString("EudoMenuConnectionString")));

            // enregistrement du service BaseRepository
            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository <>));
            // enregistrement du service RestaurantRepository
            services.AddScoped(typeof(IRestaurantRepository), typeof(RestaurantRepository));
            // enregistrement du service MealRepository
            services.AddScoped(typeof(IMealRepository), typeof(MealRepository));

            return services;
        }
    }
}
