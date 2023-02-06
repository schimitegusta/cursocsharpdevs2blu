using ProjetoSaude.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSaude.Domain.DTO
{
    public class PessoaDTO
    {
        public int id { get; set; }
        public string nome { get; set; }
        public DateTime dataNasc { get; set; }
        public string sexo { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public int enderecoId { get; set; }
        public virtual Endereco? endereco { get; set; }
        public ICollection<Paciente>? paciente { get; set; }

        public Pessoa mapToEntity()
        {
            return new Pessoa
            {
                Id = this.id,
                Nome = this.nome,
                DataNasc = this.dataNasc,
                Sexo = this.sexo,
                Telefone = this.telefone,
                Email = this.email,
                EnderecoId = this.enderecoId
            };
        }
        public PessoaDTO mapToDTO(Pessoa pessoa)
        {
            return new PessoaDTO
            {
                id = pessoa.Id,
                nome = pessoa.Nome,
                dataNasc = pessoa.DataNasc,
                sexo = pessoa.Sexo,
                telefone = pessoa.Telefone,
                email = pessoa.Email,
                enderecoId = pessoa.EnderecoId
            };
        }
    }
}
