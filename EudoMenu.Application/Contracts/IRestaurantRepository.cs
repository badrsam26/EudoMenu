using EudoMenu.Domain;

namespace EudoMenu.Application.Contracts
{
    // interface pour manipulation des restaurants avec 2 methods de plus de ce qu'elle herite de l'interface generique IAsyncRepository
    public interface IRestaurantRepository : IAsyncRepository<Restaurant>
    {
        // recuperation de tout les restaurants
        Task<IReadOnlyList<Restaurant>> GetAllRestaurantAsync();

        // recuperation d'un restaurant par son identifiant + avec ses plats ou pas
        Task<Restaurant> GetRestaurantByIdAsync(Guid id, bool includeMeals);

    }
}
