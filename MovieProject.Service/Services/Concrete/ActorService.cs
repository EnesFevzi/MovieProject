using AutoMapper;
using MovieProject.Core.BaseRepositories;
using MovieProject.Entity.Entities;
using MovieProject.Service.DTOs.Actors;
using MovieProject.Service.Services.Abstract;

namespace MovieProject.Service.Services.Concrete
{
    public class ActorService : IActorService
    {
        private readonly IRepository<Actor> _actorsRepository;
        private readonly IMapper _mapper;

        public ActorService(IRepository<Actor> actorsRepository, IMapper mapper)
        {
            _actorsRepository = actorsRepository;
            _mapper = mapper;
        }

        public async Task<Actor> CreateActor(ActorAddDto actor)
        {
            var map = _mapper.Map<Actor>(actor);
            await _actorsRepository.AddAsync(map);
            return map;
        }

        public async Task DeleteActor(int actorId)
        {
            var actor = await _actorsRepository.GetByIDAsync(actorId);
            await _actorsRepository.DeleteAsync(actor);
        }

        public Task<Actor> GetActorById(int actorId)
        {
            return _actorsRepository.GetByIDAsync(actorId);
        }

        public async Task<List<Actor>> GetActors()
        {
            return await _actorsRepository.GetAllAsync();
        }


        public async Task<Actor> UpdateActor(ActorUpdateDto actor)
        {
            var map = _mapper.Map<Actor>(actor);
            await _actorsRepository.UpdateAsync(map);
            return map;
        }
    }
}
