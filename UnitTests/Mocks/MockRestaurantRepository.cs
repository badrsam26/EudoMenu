using EudoMenu.Application.Contracts;
using EudoMenu.Domain;
using Moq;
using System.Collections.Generic;

namespace EudoMenu.UnitTest.Mocks
{
    public static class MockRestaurantRepository
    {
        public static Mock<IRestaurantRepository> GetRestaurantRepository()
        {
            var Restaurants = new List<Restaurant>
            {
                new Restaurant
                {
                    Id = new Guid("575dc7ad-d105-4e84-af0f-d54dafdcf1d4"),
                    Name = "Restaurant test 1",
                    Type = "Type 1",
                    Adress = "aaaa",
                    Phone="bbbbb",
                    ImageUrl="iiiiiii",
                    Meals= {}
                },
                new Restaurant
                {
                    Id = new Guid("575dc7ad-d105-4e84-af0f-d54dafdcf1d5"),
                    Name = "Restaurant test 3",
                    Type = "Type 1",
                    Adress = "aaaa",
                    Phone="bbbbb",
                    ImageUrl="iiiiiii",
                    Meals= {}
                },
                new Restaurant
                {
                    Id =new Guid("575dc7ad-d105-4e84-af0f-d54dafdcf1d6"),
                    Name = "Restaurant test 3",
                    Type = "Type 3",
                    Adress = "aaaa",
                    Phone="bbbbb",
                    ImageUrl="iiiiiii",
                    Meals= {}
                }
            };

            var mockRepo = new Mock<IRestaurantRepository>();

            mockRepo.Setup(r => r.GetAllRestaurantAsync()).ReturnsAsync(Restaurants);

            mockRepo.Setup(r => r.AddAsync(It.IsAny<Restaurant>())).ReturnsAsync((Restaurant restaurant) =>
            {
                Restaurants.Add(restaurant);
                return restaurant;
            });

            return mockRepo;

        }
    }
}
