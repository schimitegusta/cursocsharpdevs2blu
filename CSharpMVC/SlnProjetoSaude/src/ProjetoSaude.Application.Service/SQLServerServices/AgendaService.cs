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
    public class AgendaService : IAgendaService
    {
        private readonly IAgendaRepository _repository;

        public AgendaService(IAgendaRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Delete(int id)
        {
            var entity = await _repository.FindById(id);
            return await _repository.Delete(entity);
        }

        public List<AgendaDTO> FindAll()
        {
            return _repository.FindAll()
                              .Select(p => new AgendaDTO()
                              {
                                  id = p.Id,
                                  titulo = p.Titulo,
                                  descricao = p.Descricao,
                                  dataConsulta = p.DataConsulta,
                                  pacienteId = p.PacienteId
                              }).ToList();
        }

        public async Task<AgendaDTO> FindById(int id)
        {
            var dto = new AgendaDTO();
            return dto.mapToDTO(await _repository.FindById(id));
        }

        public Task<int> Save(AgendaDTO entity)
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
