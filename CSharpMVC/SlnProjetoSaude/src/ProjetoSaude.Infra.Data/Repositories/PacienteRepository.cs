using ProjetoSaude.Domain.Entities;
using ProjetoSaude.Domain.IRepositories;
using ProjetoSaude.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSaude.Infra.Data.Repositories
{
    public class PacienteRepository : BaseRepository<Paciente>, IPacienteRepository
    {
        private readonly SQLServerContext _context;
        public PacienteRepository(SQLServerContext context) : base(context)
        {
        }
    }
}
