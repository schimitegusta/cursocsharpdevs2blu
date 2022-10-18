using Devs2Blu.ProjetosAula.SistemaAgendaContatos.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaAgendaContatos.Models.Model
{
    public class Contatos
    {
        public Int32 Id { get; set; }
        public String Nome { get; set; }
        public String Telefone { get; set; }
        public String Celular { get; set; }
        public String Email { get; set; }
        public String Rua { get; set; }
        public Int32 Numero { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public String UF { get; set; }
        public Enum Status { get; set; }
        public Contatos()
        {
            Status = FlStatus.A;
        }

        public Contatos(int id, string nome, string telefone, string celular, string email, string rua, int numero, string bairro, string cidade, string uF, Enum status)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Celular = celular;
            Email = email;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            UF = uF;

            Status = status;
        }
    }
}
