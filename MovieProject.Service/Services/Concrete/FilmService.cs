using AutoMapper;
using MovieProject.Core.BaseRepositories;
using MovieProject.Entity.Entities;
using MovieProject.Service.DTOs.Films;
using MovieProject.Service.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
            var map = _mapper.Map<Film>(film);
            if (film.SelectedActors != null)
            {
                foreach (var item in film.SelectedActors)
                {
                    var findExtra = await _actorRepository.GetByIDAsync(item);
                    map.Actors.Add(findExtra);
                }
            }
            await _filmRepository.AddAsync(map);
        }
        public async Task<Film> UpdateFilm(FilmUpdateDto film)
        {
            var updatedFilm = _mapper.Map<Film>(film);

            if (film.SelectedActors != null)
            {
                foreach (var selectedActorId in film.SelectedActors)
                {
                    var selectedActor = await _actorRepository.GetByIDAsync(selectedActorId);
                    if (selectedActor != null && !updatedFilm.Actors.Any(extra => extra.ActorId == selectedActorId))
                    {
                        updatedFilm.Actors.Add(selectedActor);
                    }
                }
            }

            await _filmRepository.UpdateAsync(updatedFilm);
            return updatedFilm;
        }

        public async Task DeleteFilm(int filmId)
        {
            var film = await _filmRepository.GetByIDAsync(filmId);
            await _filmRepository.DeleteAsync(film);

        }
        public async Task<Film> GetFilmById(int filmId)
        {
            var film = await _filmRepository.GetAsync(x => x.FilmId == filmId);
            return film;
        }

        public async Task<List<ResultFilmDto>> GetFilms()
        {
            var films = await _filmRepository.GetAllAsync(x => x.Category, x => x.Actors);
            var map = _mapper.Map<List<ResultFilmDto>>(films);
            return map;
        }


    }
}
