using eMovieTickets.Data.Base;
using eMovieTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMovieTickets.Data.ViewModels;
namespace eMovieTickets.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
    }
}
