using EudoMenu.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EudoMenu.Application.Contracts
{
    // interface pour manipulation des plats avec 1 methods d plus de ce qu'elle herite de l'interface generique IAsyncRepository
    public interface IMealRepository : IAsyncRepository<Meal>
    {
        // retourne un plat par son identifiant + si avec ses ingredients ou pas 
        Task<Meal> GetMealByIdAsync(Guid id, bool includeIngredients);
    }
}
