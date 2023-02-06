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
    public class EnderecoRepository : BaseRepository<Endereco>, IEnderecoRepository
    {
        private readonly SQLServerContext _context;
        public EnderecoRepository(SQLServerContext context) : base(context)
        {
        }
    }
}
