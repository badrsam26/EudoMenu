using EudoMenu.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EudoMenu.Application.Features.Meals.Commands.CreateMeal
{
    public class CreateMealCommand : IRequest<Guid>
    {
        public Guid RestaurantId { get; set; }

        [JsonPropertyName("strMeal")]
        public string Name { get; set; }

        [JsonPropertyName("strDrinkAlternate")]
        public string DrinkAlternate { get; set; }

        [JsonPropertyName("strCategory")]
        public string Category { get; set; }

        [JsonPropertyName("strArea")]
        public string Area { get; set; }

        [JsonPropertyName("strInstructions")]
        public string Instructions { get; set; }

        [JsonPropertyName("strMealThumb")]
        public string Thumb { get; set; }

        [JsonPropertyName("strTags")]
        public string Tags { get; set; }

        [JsonPropertyName("strYoutube")]
        public string Youtube { get; set; }

        public ICollection<Ingredient> ingredients { get; set; } = new List<Ingredient>();

        #region "INGREDIENTS"
        [JsonPropertyName("strIngredient1")]
        public string strIngredient1 { get; set; }

        [JsonPropertyName("strIngredient2")]
        public string strIngredient2 { get; set; }

        [JsonPropertyName("strIngredient3")]
        public string strIngredient3 { get; set; }

        [JsonPropertyName("strIngredient4")]
        public string strIngredient4 { get; set; }

        [JsonPropertyName("strIngredient5")]
        public string strIngredient5 { get; set; }

        [JsonPropertyName("strIngredient6")]
        public string strIngredient6 { get; set; }

        [JsonPropertyName("strIngredient7")]
        public string strIngredient7 { get; set; }

        [JsonPropertyName("strIngredient8")]
        public string strIngredient8 { get; set; }

        [JsonPropertyName("strIngredient9")]
        public string strIngredient9 { get; set; }

        [JsonPropertyName("strIngredient10")]
        public string strIngredient10 { get; set; }

        [JsonPropertyName("strIngredient11")]
        public string strIngredient11 { get; set; }

        [JsonPropertyName("strIngredient12")]
        public string strIngredient12 { get; set; }

        [JsonPropertyName("strIngredient13")]
        public string strIngredient13 { get; set; }

        [JsonPropertyName("strIngredient14")]
        public string strIngredient14 { get; set; }

        [JsonPropertyName("strIngredient15")]
        public string strIngredient15 { get; set; }


        [JsonPropertyName("strIngredient16")]
        public string strIngredient16 { get; set; }

        [JsonPropertyName("strIngredient17")]
        public string strIngredient17 { get; set; }

        [JsonPropertyName("strIngredient18")]
        public string strIngredient18 { get; set; }

        [JsonPropertyName("strIngredient19")]
        public string strIngredient19 { get; set; }

        [JsonPropertyName("strIngredient20")]
        public string strIngredient20 { get; set; }
        #endregion

        #region "QUANTITES"
        [JsonPropertyName("strMeasure1")]
        public string strMeasure1 { get; set; }

        [JsonPropertyName("strMeasure2")]
        public string strMeasure2 { get; set; }

        [JsonPropertyName("strMeasure3")]
        public string strMeasure3 { get; set; }

        [JsonPropertyName("strMeasure4")]
        public string strMeasure4 { get; set; }

        [JsonPropertyName("strMeasure5")]
        public string strMeasure5 { get; set; }

        [JsonPropertyName("strMeasure6")]
        public string strMeasure6 { get; set; }

        [JsonPropertyName("strMeasure7")]
        public string strMeasure7 { get; set; }

        [JsonPropertyName("strMeasure8")]
        public string strMeasure8 { get; set; }

        [JsonPropertyName("strMeasure9")]
        public string strMeasure9 { get; set; }

        [JsonPropertyName("strMeasure10")]
        public string strMeasure10 { get; set; }

        [JsonPropertyName("strMeasure11")]
        public string strMeasure11 { get; set; }

        [JsonPropertyName("strMeasure12")]
        public string strMeasure12 { get; set; }

        [JsonPropertyName("strMeasure13")]
        public string strMeasure13 { get; set; }

        [JsonPropertyName("strMeasure14")]
        public string strMeasure14 { get; set; }

        [JsonPropertyName("strMeasure15")]
        public string strMeasure15 { get; set; }

        [JsonPropertyName("strMeasure16")]
        public string strMeasure16 { get; set; }

        [JsonPropertyName("strMeasure17")]
        public string strMeasure17 { get; set; }

        [JsonPropertyName("strMeasure18")]
        public string strMeasure18 { get; set; }

        [JsonPropertyName("strMeasure19")]
        public string strMeasure19 { get; set; }

        [JsonPropertyName("strMeasure20")]
        public string strMeasure20 { get; set; }
        #endregion
    }
}
