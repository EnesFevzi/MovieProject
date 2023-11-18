using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieProject.Entity.Entities;

namespace MovieProject.DataAccess.SeedData
{
    public class CategorySeedData : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                CategoryId = 1,
                Name ="Komedi",
            },
            new Category
            {
                CategoryId = 2,
                Name = "Bilim Kurgu",
            }, 
            new Category
            {
                CategoryId = 3,
                Name = "Gerilim",
            });
        }
    }
}
