using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EudoMenu.Application.Features.Restaurants.Queries.GetRestaurantDetail
{
    // la query pour recuperation de restaurant sous form de GetRestaurantDetailViewModel 
    public class GetRestaurantDetailQuery : IRequest<GetRestaurantDetailViewModel>
    {
        // avec identifiant du restaurant comme parametre
        public Guid restaurant_id { get; set; }
    }
}
