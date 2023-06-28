using AutoMapper;
using EudoMenu.Application.Features.Meals.Commands.CreateMeal;
using EudoMenu.Application.Features.Meals.Queries.GetMealDetail;
using EudoMenu.Application.Features.Restaurants.Commands.CreateRestaurant;
using EudoMenu.Application.Features.Restaurants.Queries.GetRestaurantDetail;
using EudoMenu.Application.Features.Restaurants.Queries.GetRestaurantsList;
using EudoMenu.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EudoMenu.Application.Profiles
{
    public class AutoMapperProfile : Profile
    {
        // la definition des automappers
        public AutoMapperProfile()
        {
            CreateMap<Restaurant,GetRestaurantsListViewModel>().ReverseMap();
            CreateMap<Restaurant,GetRestaurantDetailViewModel>().ReverseMap();
            CreateMap<Restaurant,CreateRestaurantCommand>().ReverseMap();

            CreateMap<Meal,MealDAO>().ReverseMap();
            CreateMap<Meal,GetMealDetailViewModel>().ReverseMap();
            CreateMap<Meal,CreateMealCommand>().ReverseMap();
        }
    }
}
