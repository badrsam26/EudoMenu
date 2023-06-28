using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace PostLand.Application
{
    public static class ApplicationContainer
    {
        // enregistrement des depencies pour la couche Application
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // enregistrement du service AutoMapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            // enregistrement du service MediatR
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
