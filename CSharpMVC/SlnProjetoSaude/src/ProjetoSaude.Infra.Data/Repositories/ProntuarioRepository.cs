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
    public class ProntuarioRepository : BaseRepository<Prontuario>, IProntuarioRepository
    {
        private readonly SQLServerContext _context;
        public ProntuarioRepository(SQLServerContext context) : base(context)
        {
        }
    }
}
