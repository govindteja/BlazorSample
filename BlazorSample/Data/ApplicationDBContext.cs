using BlazorSample.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSample.Data
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = Guid.NewGuid(), Name="Wild Dog", ReleaseYear=2021 },
                new Movie { Id = Guid.NewGuid(), Name = "Vakeel Saab", ReleaseYear = 2021 }
            );
        }
    }
}
