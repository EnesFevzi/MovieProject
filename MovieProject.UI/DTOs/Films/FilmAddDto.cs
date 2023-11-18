using MovieProject.Entity.Entities;

namespace MovieProject.UI.DTOs.Films
{
    public class FilmAddDto
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int CategoryId { get; set; }
        public List<Category>? Categories { get; set; }
        public int ActorId { get; set; }
        public List<Actor>? Actors { get; set; }
    }
}
