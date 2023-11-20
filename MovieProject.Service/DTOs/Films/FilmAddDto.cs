namespace MovieProject.Service.DTOs.Films
{
    public class FilmAddDto
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int CategoryId { get; set; }
        public List<int>? SelectedActors { get; set; }
    }
}
