using AutoMapper;
using MovieProject.Core.BaseRepositories;
using MovieProject.Entity.Entities;
using MovieProject.Service.DTOs.Films;
using MovieProject.Service.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Service.Services.Concrete
{
    public class FilmService : IFilmService
    {
        private readonly IRepository<Film> _filmRepository;
        private readonly IRepository<Actor> _actorRepository;
        private readonly IRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public FilmService(IRepository<Film> filmRepository, IRepository<Actor> actorRepository, IRepository<Category> categoryRepository, IMapper mapper)
        {
            _filmRepository = filmRepository;
            _actorRepository = actorRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task CreateFilm(FilmAddDto film)
        {
            var actor = await _actorRepository.GetByIDAsync(film.ActorId);
            var map = _mapper.Map<Film>(film);

            map.Actors.Add(actor);
            await _filmRepository.AddAsync(map);
        }
        public async Task<Film> UpdateFilm(FilmUpdateDto film)
        {
            var existingFilm = await _filmRepository.GetByIDAsync(film.FilmId);
            var actor = await _actorRepository.GetByIDAsync(film.ActorId);
            var map = _mapper.Map<Film>(film);
            if (existingFilm != null)
            {
                foreach (var item in existingFilm.Actors)
                {
                    if (item.ActorId != film.ActorId)
                    {
                        map.Actors.Add(actor);

                    }
                }
                await _filmRepository.UpdateAsync(map);
            }
            return map;
        }

        public async Task DeleteFilm(int filmId)
        {
            var film = await _filmRepository.GetByIDAsync(filmId);
            await _filmRepository.DeleteAsync(film);

        }
        public async Task<Film> GetFilmById(int filmId)
        {
            return await _filmRepository.GetByIDAsync(filmId);
        }

        public async Task<List<ResultFilmDto>> GetFilms()
        {

            var films = await _filmRepository.GetAllAsync(x => x.Category);
            var map = _mapper.Map<List<ResultFilmDto>>(films);
            return map;
        }


    }
}
