using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EudoMenu.Domain
{
    public class Restaurant
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string? Type { get; set; }

        public string? Adress { get; set; }

        public string? Phone { get; set; }

        public string? ImageUrl { get; set; }
        public ICollection<Meal> Meals { get; set; }
    }
}
