using MovieProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Service.DTOs.Films
{
    public class ResultFilmDto
    {
        public int FilmId { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Category Category { get; set; }
    }
}
