using AutoMapper;
using EudoMenu.Application.Features.Meals.Commands.CreateMeal;
using EudoMenu.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EudoMenu.Persistence
{
    public class EudoMenuDbContext : DbContext
    {
        public EudoMenuDbContext(DbContextOptions<EudoMenuDbContext> options) : base(options)
        {

        }

        // La table qui stock les restaurants
        public DbSet<Restaurant> Restaurants { get; set; }

        // la table qui stock les plats
        public DbSet<Meal> Meals { get; set; }

        // la table qui stock les ingredients des plats
        public DbSet<Ingredient> Ingredients { get; set; }

        // a la creation du model on ajout qlq donne pour test
        protected override void OnModelCreating(ModelBuilder modelBuilder )
        {
            // ajout d'un premier restaurant pour les test
            var restaurant_id = Guid.Parse("{0A99AEC6-044A-4A1E-897E-54FB39A84155}");
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                Id = restaurant_id,
                Name = "Restaurant 1",
                Type = "Fast Food",
                Adress = "78 Avenue Franklin, Paris",
                Phone = "0601 67 57 88 23",
                ImageUrl = "https://img.freepik.com/vecteurs-premium/logo-style-vintage-retro-restaurant_642964-120.jpg?w=2000"
            });

            // Ajout des plats provenant de l'API TheMealDb

            // Plat 1
            CreateMealCommand meal1 = RandomMeal.Get(restaurant_id);
            Guid meal_id = Guid.NewGuid();
            modelBuilder.Entity<Meal>().HasData(new Meal
            {
                Id = meal_id,
                RestaurantId = meal1.RestaurantId,
                Name = meal1.Name,
                DrinkAlternate = meal1.DrinkAlternate,
                Category = meal1.Category,
                Area = meal1.Area,
                Instructions = meal1.Instructions,
                Thumb = meal1.Thumb,
                Tags = meal1.Tags,
                Youtube = meal1.Youtube
            });
            for (int j = 0; j < meal1.ingredients.Count; j++)
            {
                meal1.ingredients.ElementAt(j).Id = Guid.NewGuid();
                meal1.ingredients.ElementAt(j).MealId = meal_id;
            }
            modelBuilder.Entity<Ingredient>().HasData(meal1.ingredients);

            //Plat 2
            CreateMealCommand meal2 = RandomMeal.Get(restaurant_id);
            Guid meal_id2 = Guid.NewGuid();
            modelBuilder.Entity<Meal>().HasData(new Meal
            {
                Id = meal_id2,
                RestaurantId = meal2.RestaurantId,
                Name = meal2.Name,
                DrinkAlternate = meal2.DrinkAlternate,
                Category = meal2.Category,
                Area = meal2.Area,
                Instructions = meal2.Instructions,
                Thumb = meal2.Thumb,
                Tags = meal2.Tags,
                Youtube = meal2.Youtube
            });
            for (int j = 0; j < meal2.ingredients.Count; j++)
            {
                meal2.ingredients.ElementAt(j).Id = Guid.NewGuid();
                meal2.ingredients.ElementAt(j).MealId = meal_id2;
            }
            modelBuilder.Entity<Ingredient>().HasData(meal2.ingredients);
        }
    }
}
