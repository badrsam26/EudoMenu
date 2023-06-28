using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EudoMenu.Application.Features.Meals.Queries.GetMealDetail
{
    public class GetMealDetailQuery : IRequest<GetMealDetailViewModel>
    {
        public Guid meal_id { get; set; }
    }
}
