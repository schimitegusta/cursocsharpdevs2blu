using Devs2Blu.PrimeiroExercicioAPIASPNetCore.Services.DTOs;
using Devs2Blu.PrimeiroExercicioAPIASPNetCore.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.PrimeiroExercicioAPIASPNetCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _service;

        public MoviesController(IMovieService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetMovies()
        {
            var movies = _service.GetAll();
            return Ok(movies);
        }

        [HttpPost]
        public IActionResult Create(PostMovieRequest movie)
        {
            try
            {
                _service.Add(movie);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
    }
}