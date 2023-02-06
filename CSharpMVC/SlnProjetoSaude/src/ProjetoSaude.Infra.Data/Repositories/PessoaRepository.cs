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
    public class PessoaRepository : BaseRepository<Pessoa>, IPessoaRepository
    {
        private readonly SQLServerContext _context;
        public PessoaRepository(SQLServerContext context) : base(context)
        {
        }
    }
}
