using AutoMapper;
using EudoMenu.Application.Contracts;
using EudoMenu.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EudoMenu.Application.Features.Restaurants.Queries.GetRestaurantDetail
{
    internal class GetRestaurantDetailQueryHandler : IRequestHandler<GetRestaurantDetailQuery, GetRestaurantDetailViewModel>
    {
        private readonly IRestaurantRepository repository;
        private readonly IMapper mapper;

        // injection des services repository + mapper
        public GetRestaurantDetailQueryHandler(IRestaurantRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        // Handling de notre query et retour du resultat
        public async Task<GetRestaurantDetailViewModel> Handle(GetRestaurantDetailQuery request, CancellationToken cancellationToken)
        {
            var restaurant = await repository.GetRestaurantByIdAsync(request.restaurant_id, true); // recuperation du restaurant
            return mapper.Map<GetRestaurantDetailViewModel>(restaurant); //mapping pour retourner le view model et non le restaurant complet
        }
    }
}
