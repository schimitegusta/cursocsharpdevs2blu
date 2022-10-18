using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaAgendaContatos.Models.Enums
{
    public enum FlStatus
    {
        [Description("Inativo")]
        I = 0,
        [Description("Ativo")]
        A = 1,
        [Description("Concluido")]
        C = 2,
        [Description("Remarcado")]
        R = 3
    }
}
