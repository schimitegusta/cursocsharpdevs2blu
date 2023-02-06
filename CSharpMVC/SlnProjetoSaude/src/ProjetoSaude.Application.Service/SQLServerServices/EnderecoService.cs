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
    public class EnderecoService : IEnderecoService
    {
        private readonly IEnderecoRepository _repository;

        public EnderecoService(IEnderecoRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Delete(int id)
        {
            var entity = await _repository.FindById(id);
            return await _repository.Delete(entity);
        }

        public List<EnderecoDTO> FindAll()
        {
            return _repository.FindAll()
                              .Select(e => new EnderecoDTO()
                              {
                                  id = e.Id,
                                  rua = e.Rua,
                                  numero = e.Numero,
                                  cep = e.CEP,
                                  regiao = e.Regiao,
                                  cidade = e.Cidade,
                                  estado = e.Estado
                              }).ToList();
        }

        public async Task<EnderecoDTO> FindById(int id)
        {
            var dto = new EnderecoDTO();
            return dto.mapToDTO(await _repository.FindById(id));
        }

        public Task<int> Save(EnderecoDTO entity)
        {
            if (entity.id > 0)
            {
                return _repository.Update(entity.mapToEntity());
            }
            else
            {
                return _repository.Save(entity.mapToEntity());
            }
        }
    }
}
