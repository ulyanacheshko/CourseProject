using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieTickets.DataAccess;
using MovieTickets.Entities;
namespace MovieTickets.Controllers
{
    [ApiController]
    [Route("controller")]

    public class MovieTicketsController : ControllerBase
    {
        public readonly MovieTicketsDbContext _movieTicketsDbContext;
        public MovieTicketsController(MovieTicketsDbContext movieTicketsDbContext)
        {
            _movieTicketsDbContext = movieTicketsDbContext;
        }
        [HttpGet]
        public async Task<IEnumerable<Movie>> GetAll()
        {
            return await _movieTicketsDbContext.Movies.ToArrayAsync();

        }
        [HttpPost]
        public async Task<ActionResult<int>> Create([FromBody] Movie movie)
        {
            await _movieTicketsDbContext.Movies.AddAsync(movie);
            await _movieTicketsDbContext.SaveChangesAsync();
            return movie.Id;

        }
    }
}