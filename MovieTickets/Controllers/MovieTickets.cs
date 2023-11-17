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

        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetById(int id)
        {
            var movie = await _movieTicketsDbContext.Movies.FindAsync(id);
            return Ok(movie);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateArt(int id, [FromBody] Movie movie)
        {
            var existingMovie = await _movieTicketsDbContext.Movies.FindAsync(id);
            existingMovie.Id = movie.Id;
            existingMovie.MovieTitle = movie.MovieTitle;
            existingMovie.MovieDuration = movie.MovieDuration;
            _movieTicketsDbContext.Movies.Update(existingMovie);
            await _movieTicketsDbContext.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProductById(int id)
        {
            var movie = await _movieTicketsDbContext.Movies.FindAsync(id);
            _movieTicketsDbContext.Movies.Remove(movie);
            await _movieTicketsDbContext.SaveChangesAsync();
            return Ok();
        }

    }
}