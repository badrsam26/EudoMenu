using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EudoMenu.Application.Features.Restaurants.Queries.GetRestaurantsList
{
    // view model a utiliser pour l'operation, en cohérence avec ce que nous souhaitons comme infos en retour de la query
    // seulemenent les proprietes dont nous avons besoin
    public class GetRestaurantsListViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }

    }
}
