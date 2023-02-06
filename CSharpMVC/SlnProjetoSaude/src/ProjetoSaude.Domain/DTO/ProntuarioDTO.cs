using ProjetoSaude.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSaude.Domain.DTO
{
    public class ProntuarioDTO
    {
        public int id { get; set; }
        public DateTime dataAbertura { get; set; }
        public int pacienteId { get; set; }
        public virtual Paciente? paciente { get; set; }

        public Prontuario mapToEntity()
        {
            return new Prontuario
            {
                Id = this.id,
                DataAbertura = this.dataAbertura,
                PacienteId = this.pacienteId
            };
        }

        public ProntuarioDTO mapToDTO(Prontuario prontuario)
        {
            return new ProntuarioDTO
            {
                id = prontuario.Id,
                dataAbertura = this.dataAbertura,
                pacienteId = this.pacienteId
            };
        }
    }
}
