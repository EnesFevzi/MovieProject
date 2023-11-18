using MovieProject.Entity.Entities;
using MovieProject.Service.DTOs.Actors;

namespace MovieProject.Service.Services.Abstract
{
    public interface IActorService
    {
        Task<List<Actor>> GetActors();
        Task<Actor> GetActorById(int actorId);
        Task<Actor> CreateActor(ActorAddDto actor);
        Task<Actor> UpdateActor(ActorUpdateDto actor);
        Task DeleteActor(int actorId);

    }
}
