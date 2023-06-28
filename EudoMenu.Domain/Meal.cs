using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EudoMenu.Domain
{
    public class Meal
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? DrinkAlternate { get; set; }
        public string? Category { get; set; }
        public string? Area { get; set; }
        public string? Instructions { get; set; }
        public string? Thumb { get; set; }
        public string? Tags { get; set; }
        public string? Youtube { get; set; }

        [ForeignKey("Restaurant")]
        public Guid RestaurantId { get; set; }
        public Restaurant restaurant { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
