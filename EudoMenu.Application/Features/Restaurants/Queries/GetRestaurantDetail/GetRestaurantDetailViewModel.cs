using EudoMenu.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EudoMenu.Application.Features.Restaurants.Queries.GetRestaurantDetail
{
    public class GetRestaurantDetailViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Type { get; set; }
        
        public ICollection<MealDAO> Meals { get; set; }
    }
}
