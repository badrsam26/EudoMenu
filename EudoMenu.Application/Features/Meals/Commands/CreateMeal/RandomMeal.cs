using EudoMenu.Domain;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EudoMenu.Application.Features.Meals.Commands.CreateMeal
{
    // une class static pour pouvoir recuperer des plats à l'aide de l'API themealdb
    public static class RandomMeal
    {
        // recuperation d'un plat aleatoire + specification de son restaurant 
        public static CreateMealCommand Get(Guid restaurant_id)
        {
            //appel de l'API themealdb
            var client = new RestClient($"https://www.themealdb.com/api/json/v1/1/random.php");
            var request = new RestRequest();
            var task = client.ExecuteAsync(request);
            task.Wait();
            var mealList = JsonSerializer.Deserialize<Content>(task.Result.Content);
            var meal = mealList.Meals[0]; //recuperation du plat
            meal.RestaurantId =  restaurant_id ; // affactation de son restaurant

            // pour strecturer au mieux les données dans notre base: on recuperer les ingredients avec leurs Qte dans une collection pour enregistrement dans une table separer dans la Bd 
            foreach (PropertyInfo prop in meal.GetType().GetProperties())
            {
                // suite a l'annalyse du retour : creation de l'ingredient et ajout a la collection
                if (prop.Name.StartsWith("strIngredient") && prop.GetValue(meal).ToString() !="")
                {
                    string PropName = prop.Name.Split("strIngredient")[1];
                    Ingredient ingredient = new Ingredient() { Name= prop.GetValue(meal).ToString(), 
                                                               Quantity= meal.GetType().GetProperty("strMeasure" + PropName).GetValue(meal).ToString() };
                    meal.ingredients.Add(ingredient);
                }
            }
            return meal;
        }
    }

    public class Content
    {
        [JsonPropertyName("meals")]
        public List<CreateMealCommand> Meals { get; set; }
    }
}
