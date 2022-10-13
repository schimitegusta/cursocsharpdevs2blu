using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaAgendaContatos.Models.Model
{
    public class Endereco
    {
        public Int32 Id { get; set; }
        public String UF { get; set; }
        public String Descricao { get; set; }
        public Endereco()
        {

        }

        public Endereco(int id, string uF, string descricao)
        {
            Id = id;
            UF = uF;
            Descricao = descricao;
        }
    }
}
