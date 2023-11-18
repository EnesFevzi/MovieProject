using MovieProject.Core.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Entity.Entities
{
    public class Actor : EntityBase
    {
        public Actor()
        {
            Films = new List<Film>();
        }
        public int ActorId { get; set; }
        public string Name { get; set; }

        // An actor can act in multiple films.
        public List<Film> Films { get; set; }
    }
}
