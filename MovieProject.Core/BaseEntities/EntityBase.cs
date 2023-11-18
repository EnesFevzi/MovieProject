using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Core.BaseEntities
{
    public class EntityBase : IEntityBase
    {
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
