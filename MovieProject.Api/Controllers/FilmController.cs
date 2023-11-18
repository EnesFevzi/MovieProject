using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieProject.Service.DTOs.Films;
using MovieProject.Service.FluentValidations;
using MovieProject.Service.Services.Abstract;

namespace MovieProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private readonly IFilmService _filmService;
        public FilmController(IFilmService filmService)
        {
            _filmService = filmService;
        }

        [HttpGet]
        public async Task<IActionResult> GetFilms()
        {
            var films = await _filmService.GetFilms();
            return Ok(films);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFilmById(int id)
        {
            var film = await _filmService.GetFilmById(id);

            if (film == null)
            {
                return NotFound();
            }

            return Ok(film);
        }

        [HttpPost("CreateFilm")]
        public async Task<IActionResult> CreateFilm(FilmAddDto filmDTO)
        {
            var validator = new FilmAddDtoValidator();
            var validationResult = validator.Validate(filmDTO);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            await _filmService.CreateFilm(filmDTO);
            return Ok("Ekleme İşlemi Başarılı");
        }

        [HttpPut("UpdateFilm")]
        public async Task< IActionResult> UpdateFilm(FilmUpdateDto filmDTO)
        {
            var validator = new FilmUpdateDtoValidator();
            var validationResult = validator.Validate(filmDTO);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }
            var updatedFilm = await _filmService.UpdateFilm(filmDTO);

            if (updatedFilm == null)
            {
                return NotFound();
            }
            return Ok(updatedFilm);
        }

        [HttpDelete("DeleteFilm/{id}")]
        public async Task<IActionResult> DeleteFilm(int id)
        {
            await _filmService.DeleteFilm(id);
            return Ok("silindi");
        }
    }

}
