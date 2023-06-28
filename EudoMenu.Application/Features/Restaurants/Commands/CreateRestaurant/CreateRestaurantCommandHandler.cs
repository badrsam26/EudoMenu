using AutoMapper;
using EudoMenu.Application.Contracts;
using EudoMenu.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EudoMenu.Application.Features.Restaurants.Commands.CreateRestaurant
{
    public class CreateRestaurantCommandHandler : IRequestHandler<CreateRestaurantCommand, Guid>
    {
        private readonly IRestaurantRepository repository;
        private readonly IMapper mapper;

        public CreateRestaurantCommandHandler(IRestaurantRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<Guid> Handle(CreateRestaurantCommand request, CancellationToken cancellationToken)
        {
            Restaurant restaurant = mapper.Map<Restaurant>(request);
            CreateRestaurantCommandValidator validator = new CreateRestaurantCommandValidator();
            var result = await validator.ValidateAsync(request);
            if (result.Errors.Any())
            {
                throw new Exception("Restaurant not valid !");
            }
            restaurant = await repository.AddAsync(restaurant);
            return restaurant.Id;
        }
    }
}
