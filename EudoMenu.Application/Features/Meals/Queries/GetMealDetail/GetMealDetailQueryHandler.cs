using AutoMapper;
using EudoMenu.Application.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EudoMenu.Application.Features.Meals.Queries.GetMealDetail
{
    public class GetMealDetailQueryHandler : IRequestHandler<GetMealDetailQuery, GetMealDetailViewModel>
    {
        private readonly IMealRepository repository;
        private readonly IMapper mapper;

        public GetMealDetailQueryHandler(IMealRepository repository,IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<GetMealDetailViewModel> Handle(GetMealDetailQuery request, CancellationToken cancellationToken)
        {
            var meal = await repository.GetMealByIdAsync(request.meal_id, true);
            return mapper.Map<GetMealDetailViewModel>(meal);
        }
    }
}
