using AutoMapper;
using EudoMenu.Application.Contracts;
using EudoMenu.Application.Features.Restaurants.Queries.GetRestaurantsList;
using EudoMenu.Application.Profiles;
using EudoMenu.UnitTest.Mocks;
using Moq;
using Shouldly;
using Xunit;

namespace EudoMenu.UnitTest
{
    public class GetRestaurantsListQueryHandlerTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IRestaurantRepository> _mockRepo;
        public GetRestaurantsListQueryHandlerTests()
        {
            _mockRepo = MockRestaurantRepository.GetRestaurantRepository();

            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<AutoMapperProfile>();
            });

            _mapper = mapperConfig.CreateMapper();
        }

        [Fact]
        public async Task GetRestaurantsListTest()
        {
            var handler = new GetRestaurantsListQueryHandler(_mockRepo.Object, _mapper);

            var result = await handler.Handle(new GetRestaurantsListQuery(), CancellationToken.None);
            
            result.ShouldBeOfType<List<GetRestaurantsListViewModel>>();

            result.Count.ShouldBe(3);
        }
    }
}