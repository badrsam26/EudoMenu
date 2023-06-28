using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EudoMenu.Domain
{
    public class Ingredient
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Quantity { get; set; }

        [ForeignKey("Meal")]
        public Guid MealId { get; set; }

    }
}
