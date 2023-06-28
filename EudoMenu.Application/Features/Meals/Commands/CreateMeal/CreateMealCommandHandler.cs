using AutoMapper;
using EudoMenu.Application.Contracts;
using EudoMenu.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EudoMenu.Application.Features.Meals.Commands.CreateMeal
{
    public class CreateMealCommandHandler : IRequestHandler<CreateMealCommand, Guid>
    {
        private readonly IMealRepository repository;
        private readonly IMapper mapper;

        public CreateMealCommandHandler(IMealRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<Guid> Handle(CreateMealCommand request, CancellationToken cancellationToken)
        {
            Meal meal = mapper.Map<Meal>(request);
            meal = await repository.AddAsync(meal);
            return meal.Id;
        }
    }
}
