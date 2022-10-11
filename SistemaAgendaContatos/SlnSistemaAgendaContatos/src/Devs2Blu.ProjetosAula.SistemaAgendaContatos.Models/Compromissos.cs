using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaAgendaContatos.Models
{
    public class Compromissos
    {
        public Int32 Id { get; set; }
        public DateTime Data { get; set; }
        public String Local { get; set; }
        public Enum EnumDiaSemana { get; set; }
    }
}
