using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSaude.Domain.Entities
{
    public class Paciente
    {
        public int Id { get; set; }
        public string? TipoSanguineo { get; set; }
        public string Limitacao { get; set; }
        public string Alergia { get; set; }

        public int PessoaId { get; set; }
        public virtual Pessoa? Pessoa { get; set; }
        public ICollection<Agenda>? Agenda { get; set; }
        public ICollection<Prontuario>? Prontuario { get; set; }
    }
}
