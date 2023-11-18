using MovieProject.Core.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Entity.Entities
{
    public class Film : EntityBase
    {
        public Film()
        {
            Actors= new List<Actor>();
        }
        public int FilmId { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }


        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<Actor> Actors { get; set; }
    }
}
