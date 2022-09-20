using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.Classes
{
    public abstract class Pessoa //classe | o abstract nao permite com que a calsse seja instanciada
    {
        //prop tab tab, cria uma propriedade/atributo
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }

        //metodo
        public string ApresentarNomeCustom()
        {
            string nomeCustom;
            nomeCustom = $"{SobreNome}, {Nome}";
            return nomeCustom;
        }
    }
}
