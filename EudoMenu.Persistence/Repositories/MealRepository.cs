using EudoMenu.Application.Contracts;
using EudoMenu.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EudoMenu.Persistence.Repositories
{
    public class MealRepository : BaseRepository<Meal>, IMealRepository
    {
        public MealRepository(EudoMenuDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Meal> GetMealByIdAsync(Guid id, bool includeIngredients)
        {
            Meal meal = new Meal();
            meal = includeIngredients ? await dbContext.Meals.Include(m => m.Ingredients).FirstOrDefaultAsync(m => m.Id == id) : await GetByIdAsync(id);
            return meal;
        }
    }
}
