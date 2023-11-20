using MovieProject.Entity.Entities;

namespace MovieProject.UI.DTOs.Films
{
    public class ResultFilmDto
    {
        public int FilmId { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Category Category { get; set; }
        public List<Actor> Actors { get; set; }
    }
}

