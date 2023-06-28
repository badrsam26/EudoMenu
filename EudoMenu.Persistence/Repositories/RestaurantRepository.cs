using EudoMenu.Application.Contracts;
using EudoMenu.Domain;
using Microsoft.EntityFrameworkCore;

namespace EudoMenu.Persistence.Repositories
{
    public class RestaurantRepository : BaseRepository<Restaurant>, IRestaurantRepository
    {

        public RestaurantRepository(EudoMenuDbContext dbContext): base(dbContext)
        {

        }

        public async Task<IReadOnlyList<Restaurant>> GetAllRestaurantAsync()
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            restaurants = await dbContext.Restaurants.ToListAsync();
            return restaurants;
        }

        public async Task<Restaurant> GetRestaurantByIdAsync(Guid id, bool includeMeals)
        {
            Restaurant restaurant =  new Restaurant();
            if (includeMeals)
            {
                restaurant = await dbContext.Restaurants.Include(c => c.Meals).FirstOrDefaultAsync(p => p.Id == id);
            }else
            {
                restaurant = await GetByIdAsync(id);
            }
            
            return restaurant;
        }

    }
}
