using EudoMenu.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EudoMenu.Application.Features.Meals.Queries.GetMealDetail
{
    public class GetMealDetailViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Thumb { get; set; }
        public string Category { get; set; }
        public ICollection<Ingredient> ingredients { get; set; }
    }
}
