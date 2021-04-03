using BlazorSample.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSample.Data
{
    public class MoviesService : IMoviesService
    {
        private readonly MoviesContext _dbContext;
        public MoviesService(MoviesContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Movie>> GetMovies()
        {
            return await _dbContext.Movies.ToListAsync();
        }

        public async Task<Movie> GetMovie(Guid movieId)
        {
            return await _dbContext.Movies.FirstOrDefaultAsync(x => x.Id == movieId);
        }

        public async Task AddMovie(Movie movieRequest)
        {
            _dbContext.Movies.Add(movieRequest);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateMovie(Movie movieRequest)
        {
            var movie = await this.GetMovie(movieRequest.Id);
            
            movie.Name = movieRequest.Name;
            movie.ReleaseYear = movieRequest.ReleaseYear;
            
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteMovie(Guid movieId)
        {
            var movie = await this.GetMovie(movieId);
            _dbContext.Movies.Remove(movie);
            await _dbContext.SaveChangesAsync();
        }
    }
}
