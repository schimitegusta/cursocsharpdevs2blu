using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSaude.Domain.Entities
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string CEP { get; set; }
        public string Regiao { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public ICollection<Pessoa>? Pessoa { get; set; }
    }
}
