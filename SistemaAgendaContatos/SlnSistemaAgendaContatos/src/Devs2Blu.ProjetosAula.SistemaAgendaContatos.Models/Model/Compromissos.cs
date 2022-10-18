using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAula.SistemaAgendaContatos.Models.Enums;

namespace Devs2Blu.ProjetosAula.SistemaAgendaContatos.Models.Model
{
    public class Compromissos
    {
        public Int32 Id { get; set; }
        public String Titulo { get; set; }
        public String Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public Enum Status { get; set; }

        public Compromissos()
        {
            Status = FlStatus.A;
        }

        public Compromissos(int id, string titulo, string descricao, DateTime dataInicio, DateTime dataFim, Enum status)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            DataInicio = dataInicio;
            DataFim = dataFim;

            Status = status;
        }
    }
}
