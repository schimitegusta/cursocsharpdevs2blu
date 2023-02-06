using Devs2Blu.PrimeiroExercicioAPIASPNetCore.Domain.Entities;
using Devs2Blu.PrimeiroExercicioAPIASPNetCore.Domain.Interfaces.Repositories;
using Devs2Blu.PrimeiroExercicioAPIASPNetCore.Repository.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.PrimeiroExercicioAPIASPNetCore.Repository.Repositories
{
    public class MovieRepository : BaseRepository<Movie>, IMovieRepository
    {
        public MovieRepository(SQLServerContext context)
            : base(context)
        {
            
        }
    }
}
