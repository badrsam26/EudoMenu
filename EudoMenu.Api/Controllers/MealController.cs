using EudoMenu.Application.Features.Meals.Commands.CreateMeal;
using EudoMenu.Application.Features.Meals.Queries.GetMealDetail;
using EudoMenu.Application.Features.Restaurants.Queries.GetRestaurantDetail;
using EudoMenu.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using CreateMealCommand = EudoMenu.Application.Features.Meals.Commands.CreateMeal.CreateMealCommand;

namespace EudoMenu.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MealController(IMediator mediator )
        {
            this._mediator = mediator;
        }

        /// <summary>
        /// Plat Par Identifiant (Fonctionnalité 4)
        /// </summary>
        /// <remarks>Retourne un plat par son identifiant</remarks>
        /// <param name="id">id du plat</param>   
        /// <response code="200">Plat retourné</response>
        /// <response code="404">Plat introuvable</response>
        /// <response code="500">Oops! le service est indisponible pour le moment</response>
        [HttpGet("{id}", Name = "GetMealById")]
        public async Task<ActionResult<GetMealDetailViewModel>> GetMealById(Guid id)
        {
            var meal = await _mediator.Send(new GetMealDetailQuery() { meal_id = id });
            return Ok(meal);
        }


        /// <summary>
        /// Ajout d'un plat à un restaurant grace à l'API TheMealDb (Fonctionnalité 5)
        /// </summary>
        /// <remarks>Ajouter un plat à un restaurant grace à la proposition (aléatoire) de l'API TheMealDb</remarks>
        /// <param name="RestaurantId">id du restaurant</param>   
        /// <response code="200">Plat Ajouté</response>
        /// <response code="404">Plat introuvable</response>
        /// <response code="500">Oops! le service est indisponible pour le moment</response>
        [HttpGet("add/{RestaurantId}", Name = "AddRandomMeal")]
        public async Task<ActionResult<Guid>> AddRandomMeal(Guid RestaurantId)
        {
            CreateMealCommand createMealCommand = RandomMeal.Get(RestaurantId);

            var restaurant = await _mediator.Send(createMealCommand);
            return Ok(restaurant);
        }
    }
}
