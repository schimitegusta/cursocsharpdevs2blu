using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.Classes
{
    public class Recepcionista : Pessoa
    {
        public int NumeroCracha { get; set; }
        public Recepcionista()
        {
            Nome = "NOVO";
            SobreNome = "RECEPCIONISTA";
            NumeroCracha = 9999999;
        }
        //construtor
        public Recepcionista(string nome, string sobreNome)
        {
            //this e usado para refenciar a propriedade que esta no mesmo projeto
            this.Nome = nome;
            this.SobreNome = sobreNome;
        }
        public Recepcionista(int numeroCracha, string endereco)
        {
            NumeroCracha = numeroCracha;
            Endereco = endereco;
        }
        //modificador de acesso / retorno / nomeclatura
        public string AgendarConsulta()
        {
            return $"Consulta agendada!";
        }
    }
}
