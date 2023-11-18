using MovieProject.Entity.Entities;
using MovieProject.Service.DTOs.Films;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Service.Services.Abstract
{
    public interface IFilmService
    {
        Task<List<ResultFilmDto>> GetFilms();
        Task<Film> GetFilmById(int filmId);
        Task CreateFilm(FilmAddDto film);
        Task<Film> UpdateFilm(FilmUpdateDto film);
        Task DeleteFilm(int filmId);
    }
}
