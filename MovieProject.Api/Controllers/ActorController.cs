using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieProject.Service.DTOs.Actors;
using MovieProject.Service.DTOs.Categories;
using MovieProject.Service.FluentValidations;
using MovieProject.Service.Services.Abstract;

namespace MovieProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly IActorService _actorService;
        public ActorController(IActorService actorService)
        {
            _actorService = actorService;
        }

        [HttpGet]
        public async Task<IActionResult> GetActors()
        {
            var films = await _actorService.GetActors();
            return Ok(films);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetActorById(int id)
        {
            var film = await _actorService.GetActorById(id);

            if (film == null)
            {
                return NotFound();
            }

            return Ok(film);
        }

        [HttpPost("CreateActor")]
        public async Task<IActionResult> CreateActor(ActorAddDto filmDTO)
        {
            var validator = new ActorAddDtoValidator();
            var validationResult = validator.Validate(filmDTO);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            await _actorService.CreateActor(filmDTO);
            return Ok("Ekleme İşlemi Başarılı");
        }

        [HttpPut("UpdateActor")]
        public async Task<IActionResult> UpdateActor(ActorUpdateDto filmDTO)
        {
            var validator = new ActorUpdateDtoValidator();
            var validationResult = validator.Validate(filmDTO);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }
            var updatedActor = await _actorService.UpdateActor(filmDTO);

            if (updatedActor == null)
            {
                return NotFound();
            }
            return Ok(updatedActor);
        }

        [HttpDelete("DeleteActor/{id}")]
        public async Task<IActionResult> DeleteActor(int id)
        {
            await _actorService.DeleteActor(id);
            return Ok("silindi");
        }
    }
}
