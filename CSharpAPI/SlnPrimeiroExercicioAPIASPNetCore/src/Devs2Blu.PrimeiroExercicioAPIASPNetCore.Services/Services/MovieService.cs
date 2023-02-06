using Devs2Blu.PrimeiroExercicioAPIASPNetCore.Domain.Entities;
using Devs2Blu.PrimeiroExercicioAPIASPNetCore.Domain.Interfaces.Repositories;
using Devs2Blu.PrimeiroExercicioAPIASPNetCore.Services.DTOs;
using Devs2Blu.PrimeiroExercicioAPIASPNetCore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.PrimeiroExercicioAPIASPNetCore.Services.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _repository;

        public MovieService(IMovieRepository repository)
        {
            _repository = repository;
        }

        public void Add(PostMovieRequest request)
        {
            var movie = new Movie(request.Id, request.Title, request.Description, request.Rating);
            _repository.Add(movie);
        }

        public IEnumerable<Movie> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
