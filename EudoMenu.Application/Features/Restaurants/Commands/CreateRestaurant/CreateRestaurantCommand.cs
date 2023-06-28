using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EudoMenu.Application.Features.Restaurants.Commands.CreateRestaurant
{
    public class CreateRestaurantCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string ImageUrl { get; set; }
    }
}
