using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Enums;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model
{
    public class Medico : Pessoa
    {
        public Int32 Id { get; set; }
        public String CRM { get; set; }
        public String Especialidade { get; set; }
        public Medico()
        {
            TipoPessoa = TipoPessoa.PF;
        }
    }
}
