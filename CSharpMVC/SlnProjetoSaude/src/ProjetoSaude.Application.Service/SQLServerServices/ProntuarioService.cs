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
    public class ProntuarioService : IProntuarioService
    {
        private readonly IProntuarioRepository _repository;

        public ProntuarioService(IProntuarioRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Delete(int id)
        {
            var entity = await _repository.FindById(id);
            return await _repository.Delete(entity);
        }

        public List<ProntuarioDTO> FindAll()
        {
            return _repository.FindAll()
                              .Select(p => new ProntuarioDTO()
                              {
                                  id = p.Id,
                                  dataAbertura = p.DataAbertura,
                                  pacienteId = p.PacienteId
                              }).ToList();
        }

        public async Task<ProntuarioDTO> FindById(int id)
        {
            var dto = new ProntuarioDTO();
            return dto.mapToDTO(await _repository.FindById(id));
        }

        public Task<int> Save(ProntuarioDTO entity)
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
