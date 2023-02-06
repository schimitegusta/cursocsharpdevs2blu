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
    public class PacienteService : IPacienteService
    {
        private readonly IPacienteRepository _repository;

        public PacienteService(IPacienteRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Delete(int id)
        {
            var entity = await _repository.FindById(id);
            return await _repository.Delete(entity);
        }

        public List<PacienteDTO> FindAll()
        {
            return _repository.FindAll()
                              .Select(p => new PacienteDTO()
                              {
                                  id = p.Id,
                                  tipoSanguineo = p.TipoSanguineo,
                                  limitacao = p.Limitacao,
                                  alergia = p.Alergia,
                                  pessoaId = p.PessoaId
                              }).ToList();
        }

        public async Task<PacienteDTO> FindById(int id)
        {
            var dto = new PacienteDTO();
            return dto.mapToDTO(await _repository.FindById(id));
        }

        public Task<int> Save(PacienteDTO entity)
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
