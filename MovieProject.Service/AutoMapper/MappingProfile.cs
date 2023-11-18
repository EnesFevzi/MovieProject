using AutoMapper;
using MovieProject.Entity.Entities;
using MovieProject.Service.DTOs.Actors;
using MovieProject.Service.DTOs.Categories;
using MovieProject.Service.DTOs.Films;

namespace MovieProject.Service.AutoMapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<FilmAddDto, Film>().ReverseMap();
            CreateMap<FilmUpdateDto, Film>().ReverseMap();
            CreateMap<ResultFilmDto, Film>().ReverseMap();

            CreateMap<CategoryAddDto, Category>().ReverseMap();
            CreateMap<CategoryUpdateDto, Category>().ReverseMap();
            CreateMap<ResultCategoryDto, Category>().ReverseMap();

            CreateMap<ActorAddDto, Actor>().ReverseMap();
            CreateMap<ActorUpdateDto, Actor>().ReverseMap();
            CreateMap<ResultActorDto, Actor>().ReverseMap();
        }
    }
}
