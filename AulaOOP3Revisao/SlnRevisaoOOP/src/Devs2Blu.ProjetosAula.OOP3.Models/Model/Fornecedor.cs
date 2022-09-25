using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAula.OOP3.Models.Enum;

namespace Devs2Blu.ProjetosAula.OOP3.Models.Model
{
    public class Fornecedor : Pessoa
    {
        public Int32 CodigoFornecedor { get; set; }
        public String TipoFornecedor { get; set; }
        public Fornecedor()
        {
            TipoPessoa = TipoPessoa.PJ;
        }
        public Fornecedor(Int32 codigo, String nome, String cpf, String tipoFornecedor)
        {
            Codigo = codigo;
            Nome = nome;
            CGCCPF = cpf;
            TipoFornecedor = tipoFornecedor;
            TipoPessoa = TipoPessoa.PJ;
            
            Random rd = new Random();
            CodigoFornecedor = Int32.Parse($"{codigo}{rd.Next(1000, 3999)}");
        }
    }
}
