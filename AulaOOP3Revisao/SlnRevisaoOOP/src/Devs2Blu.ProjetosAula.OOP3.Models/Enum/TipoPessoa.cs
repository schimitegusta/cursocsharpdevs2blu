using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Models.Enum
{
    public enum TipoPessoa
    {
        [Description("Pessoa Fisica")]
        PF = 1,
        [Description("Pessoa Juridica")]
        PJ = 2
    }
}
