using Devs2Blu.PrimeiroExercicioAPIASPNetCore.Domain.Entities;
using Devs2Blu.PrimeiroExercicioAPIASPNetCore.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.PrimeiroExercicioAPIASPNetCore.Services.Interfaces
{
    public interface IMovieService
    {
        IEnumerable<Movie> GetAll();
        void Add(PostMovieRequest request);
    }
}
