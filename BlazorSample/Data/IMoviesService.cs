using BlazorSample.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorSample.Data
{
    interface IMoviesService
    {
        Task<IEnumerable<Movie>> GetMovies();
        Task<Movie> GetMovie(Guid movieId);
        Task AddMovie(Movie movieRequest);
        Task UpdateMovie(Movie movieRequest);
        Task DeleteMovie(Guid movieId);
    }
}