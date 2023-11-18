using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MovieProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.DataAccess.SeedData
{
    public class ActorSeedData : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.HasData(new Actor
            {
                ActorId = 1,
                Name = "Morgan Freeman",

            },
            new Actor
            {
                ActorId = 2,
                Name = "Tom Holland",

            },
            new Actor
            {
                ActorId = 3,
                Name = "Cillian Murphy",

            });
        }
    }
}
