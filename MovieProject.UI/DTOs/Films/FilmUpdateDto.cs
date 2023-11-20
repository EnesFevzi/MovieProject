using MovieProject.Entity.Entities;

namespace MovieProject.UI.DTOs.Films
{
    public class FilmUpdateDto
    {
        public int FilmId { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int CategoryId { get; set; }
        public List<Category>? Categories { get; set; }
        public List<int>? SelectedActors { get; set; }
        public List<Actor>? Actors { get; set; }
    }
}
