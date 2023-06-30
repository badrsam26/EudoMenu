using EudoMenu.Application.Contracts;
using EudoMenu.Domain;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EudoMenu.UnitTest.Mocks
{
    public static class MockRestaurantRepository
    {
        public static Mock<IRestaurantRepository> GetRestaurantRepository()
        {
            var restaurants = new List<Restaurant>
            {
                new Restaurant
                {
                    Id = Guid.NewGuid(),
                    Name = "Restaurant test 1",
                    Type = "Type 1",
                    Adress = "aaaa",
                    Phone="bbbbb",
                    ImageUrl="iiiiiii"
                },
                new Restaurant
                {
                    Id = Guid.NewGuid(),
                    Name = "Restaurant test 3",
                    Type = "Type 1",
                    Adress = "aaaa",
                    Phone="bbbbb",
                    ImageUrl="iiiiiii"
                },
                new Restaurant
                {
                    Id = Guid.NewGuid(),
                    Name = "Restaurant test 3",
                    Type = "Type 3",
                    Adress = "aaaa",
                    Phone="bbbbb",
                    ImageUrl="iiiiiii"
                }
            };

            var mockRepo = new Mock<IRestaurantRepository>();

            mockRepo.Setup(r => r.GetAllAsync()).ReturnsAsync(restaurants);

            mockRepo.Setup(r => r.AddAsync(It.IsAny<Restaurant>())).Returns((Restaurant restaurant) =>
            {
                restaurants.Add(restaurant);
                return restaurants;
            });

            return mockRepo;

        }
    }
}
