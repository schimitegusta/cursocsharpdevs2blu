using ProjetoSaude.Domain.DTO;
using ProjetoSaude.Domain.IRepositories;
using ProjetoSaude.Domain.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSaude.Application.Service.SQLServerServices
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _repository;

        public PessoaService(IPessoaRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Delete(int id)
        {
            var entity = await _repository.FindById(id);
            return await _repository.Delete(entity);
        }

        public List<PessoaDTO> FindAll()
        {
            return _repository.FindAll()
                              .Select(p => new PessoaDTO()
                                        {
                                            id = p.Id,
                                            nome = p.Nome,
                                            dataNasc = p.DataNasc,
                                            sexo = p.Sexo,
                                            telefone = p.Telefone,
                                            email = p.Email,
                                            enderecoId = p.EnderecoId
                                        }).ToList();
        }

        public async Task<PessoaDTO> FindById(int id)
        {
            var dto = new PessoaDTO();
            return dto.mapToDTO(await _repository.FindById(id));
        }

        public Task<int> Save(PessoaDTO entity)
        {
            if (entity.id > 0)
            {
                return _repository.Update(entity.mapToEntity());
            } else
            {
                return _repository.Save(entity.mapToEntity());
            }
        }
    }
}
