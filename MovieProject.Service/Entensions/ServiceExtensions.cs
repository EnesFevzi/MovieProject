using Microsoft.Extensions.DependencyInjection;
using MovieProject.Service.Services.Abstract;
using MovieProject.Service.Services.Concrete;
using System.Reflection;

namespace MovieProject.Service.Entensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddScoped<IActorService, ActorService>();
            services.AddScoped<IFilmService, FilmService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddAutoMapper(assembly);
           

            return services;
        }
    }
}
