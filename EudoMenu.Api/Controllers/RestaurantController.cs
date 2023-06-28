using EudoMenu.Application.Features.Restaurants.Commands.CreateRestaurant;
using EudoMenu.Application.Features.Restaurants.Queries.GetRestaurantDetail;
using EudoMenu.Application.Features.Restaurants.Queries.GetRestaurantsList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EudoMenu.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase 
    {
        private readonly IMediator _mediator;
        public RestaurantController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// la liste des restaurants disponibles (Fonctionnalité 1)
        /// </summary>
        /// <remarks>Retourne la liste de touts les restaurants disponible</remarks>
        /// <response code="200">les restaurants sont retournes</response>
        /// <response code="404">Restaurants introuvable</response>
        /// <response code="500">Oops! le service est indisponible pour le moment</response>
        [HttpGet("all",Name ="GetAllRestaurant")]
        public async Task<ActionResult<GetRestaurantsListViewModel>> GetAllRestaurants()
        {
            var restaurants = await _mediator.Send(new GetRestaurantsListQuery());
            return Ok(restaurants);
        }

        /// <summary>
        /// Restaurant Par Identifiant et ses plats disponible (Fonctionnalité 3)
        /// </summary>
        /// <remarks>Retourne le restaurant par identifiant</remarks>
        /// <param name="id">id du restaurant</param>   
        /// <response code="200">Restaurant retourne</response>
        /// <response code="404">Restaurant introuvable</response>
        /// <response code="500">Oops! le service est indisponible pour le moment</response>
        [HttpGet("{id}", Name = "GetRestaurantById")]
        public async Task<ActionResult<GetRestaurantDetailViewModel>> GetRestaurantById(Guid id)
        {
            var restaurant = await _mediator.Send(new GetRestaurantDetailQuery() { restaurant_id = id });
            return Ok(restaurant);
        }


        /// <summary>
        /// Ajouter de nouveaux restaurants (Fonctionnalité 2)
        /// </summary>
        /// <remarks>Ajouter de nouveaux restaurants</remarks>
        /// <response code="200">Restaurant ajouté</response>
        /// <response code="500">Oops! le service est indisponible pour le moment</response>
        /// <returns>Identifiant du restaurant ajouté</returns>
        [HttpPost(Name = "AddRestaurant")]
        public async Task<ActionResult<Guid>> CreatePost([FromBody] CreateRestaurantCommand createRestaurantCommand)
        {
            var restaurant_id = await _mediator.Send(createRestaurantCommand);
            return Ok(restaurant_id);
        }
    }
}
