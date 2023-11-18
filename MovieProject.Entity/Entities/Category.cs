using MovieProject.Core.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Entity.Entities
{
    public class Category : EntityBase
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public List<Film> Films { get; set; }
    }
}
