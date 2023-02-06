using ProjetoSaude.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSaude.Domain.DTO
{
    public class EnderecoDTO
    {
        public int id { get; set; }
        public string rua { get; set; }
        public string numero { get; set; }
        public string cep { get; set; }
        public string regiao { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }

        public ICollection<Pessoa>? pessoa { get; set; }

        public Endereco mapToEntity()
        {
            return new Endereco
            {
                Id = this.id,
                Rua = this.rua,
                Numero = this.numero,
                CEP = this.cep,
                Regiao = this.regiao,
                Cidade = this.cidade,
                Estado = this.estado
            };
        }

        public EnderecoDTO mapToDTO(Endereco endereco)
        {
            return new EnderecoDTO
            {
                id = endereco.Id,
                rua = endereco.Rua,
                numero = endereco.Numero,
                cep = endereco.CEP,
                regiao = endereco.Regiao,
                cidade = endereco.Cidade,
                estado = endereco.Estado
            };
        }
    }
}
