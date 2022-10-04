using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Enums;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model
{
    public class Fornecedor : Pessoa
    {
        public Int32 Id { get; set; }
        public String TipoFornecedor { get; set; }
        public Fornecedor()
        {
            TipoPessoa = TipoPessoa.PJ;
        }
    }
}
