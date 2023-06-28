using AutoMapper;
using EudoMenu.Application.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EudoMenu.Application.Features.Restaurants.Queries.GetRestaurantsList
{
    // handler qui vas executer la query et retourné les resultats sous forme d'une list de view models
    public class GetRestaurantsListQueryHandler : IRequestHandler<GetRestaurantsListQuery, List<GetRestaurantsListViewModel>>
    {
        private readonly IRestaurantRepository repository;
        private readonly IMapper mapper;

        // injection des services repository + mapper
        public GetRestaurantsListQueryHandler(IRestaurantRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        // Handling de notre query et retour des resultats
        public async Task<List<GetRestaurantsListViewModel>> Handle(GetRestaurantsListQuery request, CancellationToken cancellationToken)
        {
            var allRestaurants = await repository.GetAllRestaurantAsync(); // recuperation des restaurants
            return mapper.Map<List<GetRestaurantsListViewModel>>(allRestaurants); // mapping des restaurants pour une list des view models
        }
    }
}
