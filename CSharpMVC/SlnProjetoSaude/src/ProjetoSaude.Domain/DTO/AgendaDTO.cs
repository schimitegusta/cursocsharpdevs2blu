using ProjetoSaude.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSaude.Domain.DTO
{
    public class AgendaDTO
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
        public DateTime dataConsulta { get; set; }
        public int pacienteId { get; set; }
        public virtual Paciente? paciente { get; set; }

        public Agenda mapToEntity()
        {
            return new Agenda
            {
                Id = this.id,
                Titulo = this.titulo,
                Descricao = this.descricao,
                DataConsulta = this.dataConsulta,
                PacienteId = this.pacienteId
            };
        }

        public AgendaDTO mapToDTO(Agenda agenda)
        {
            return new AgendaDTO
            {
                id = agenda.Id,
                titulo = agenda.Titulo,
                descricao = agenda.Descricao,
                dataConsulta = agenda.DataConsulta,
                pacienteId = agenda.PacienteId
            };
        }
    }
}
