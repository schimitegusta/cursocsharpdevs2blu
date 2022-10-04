using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Enums;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model
{
    public class Paciente
    {
        public Int32 Id { get; set; }
        public Pessoa Pessoa { get; set; }
        public String Convenio { get; set; }

        public Paciente()
        {
            Pessoa = new Pessoa();
            Pessoa.TipoPessoa = TipoPessoa.PF;
        }
        
    }
}
