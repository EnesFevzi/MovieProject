using MovieProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Service.DTOs.Films
{
    public class FilmUpdateDto
    {
        public int FilmId { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int CategoryId { get; set; }
        public List<int>? SelectedActors { get; set; }
        public List<Actor>? Actors { get; set; }
    }
}
