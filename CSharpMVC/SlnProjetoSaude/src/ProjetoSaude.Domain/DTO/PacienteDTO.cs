using ProjetoSaude.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSaude.Domain.DTO
{
    public class PacienteDTO
    {
        public int id { get; set; }
        public string? tipoSanguineo { get; set; }
        public string limitacao { get; set; }
        public string alergia { get; set; }

        public int pessoaId { get; set; }
        public virtual Pessoa? pessoa { get; set; }
        public ICollection<Agenda>? agenda { get; set; }
        public ICollection<Prontuario>? prontuario { get; set; }

        public Paciente mapToEntity()
        {
            return new Paciente
            {
                Id = this.id,
                TipoSanguineo = this.tipoSanguineo,
                Limitacao = this.limitacao,
                Alergia = this.alergia,
                PessoaId = this.pessoaId
            };
        }

        public PacienteDTO mapToDTO(Paciente paciente)
        {
            return new PacienteDTO
            {
                id = paciente.Id,
                tipoSanguineo = paciente.TipoSanguineo,
                limitacao = paciente.Limitacao,
                alergia = paciente.Alergia,
                pessoaId = paciente.PessoaId
            };
        }
    }
}
