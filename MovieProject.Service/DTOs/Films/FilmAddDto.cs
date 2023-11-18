using MovieProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Service.DTOs.Films
{
    public class FilmAddDto
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int CategoryId { get; set; }
        public int ActorId { get; set; }
        //public List<Actor>? Actors { get; set; }
    }
}
