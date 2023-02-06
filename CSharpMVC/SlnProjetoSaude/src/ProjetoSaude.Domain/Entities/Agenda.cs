using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSaude.Domain.Entities
{
    public class Agenda
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataConsulta { get; set; }
        public int PacienteId { get; set; }
        public virtual Paciente? Paciente { get; set; }
    }
}
