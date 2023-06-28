using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EudoMenu.Application.Features.Restaurants.Queries.GetRestaurantsList
{
    // la requete utiliser pas le handler : Retourne une liste des view models que nous avons defini pour cette operation
    public class GetRestaurantsListQuery : IRequest<List<GetRestaurantsListViewModel>>
    {

    }
}
