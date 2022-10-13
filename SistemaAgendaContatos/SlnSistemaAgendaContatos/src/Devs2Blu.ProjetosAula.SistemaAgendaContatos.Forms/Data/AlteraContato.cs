using Devs2Blu.ProjetosAula.SistemaAgendaContatos.Models.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaAgendaContatos.Forms.Data
{
    public class AlteraContato
    {
        public Contatos Alterar(Contatos contatos, Compromissos compromissos)
        {
            try
            {
                MySqlConnection conn = ConnectionMySQL.GetConnection();
                contatos.Id = AlterarContato(contatos, conn);
                compromissos.Id = AlterarCompromissos(contatos, compromissos, conn, contatos.Id);

                return contatos;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private Int32 AlterarContato(Contatos contatos, MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_UPDATE_CONTATOS, conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = contatos.Id;
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 45).Value = contatos.Nome;
                cmd.Parameters.Add("@telefone", MySqlDbType.VarChar, 15).Value = contatos.Telefone;
                cmd.Parameters.Add("@celular", MySqlDbType.VarChar, 15).Value = contatos.Celular;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar, 50).Value = contatos.Email;
                cmd.Parameters.Add("@rua", MySqlDbType.VarChar, 45).Value = contatos.Rua;
                cmd.Parameters.Add("@numero", MySqlDbType.Int32).Value = contatos.Numero;
                cmd.Parameters.Add("@bairro", MySqlDbType.VarChar, 45).Value = contatos.Bairro;
                cmd.Parameters.Add("@cidade", MySqlDbType.VarChar, 45).Value = contatos.Cidade;
                cmd.Parameters.Add("@uf", MySqlDbType.VarChar, 2).Value = contatos.UF;

                cmd.ExecuteNonQuery();
                return (Int32)cmd.LastInsertedId;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro ao dar UPDATE contatos MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private Int32 AlterarCompromissos(Contatos contatos, Compromissos compromissos, MySqlConnection conn, Int32 idContato)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_UPDATE_COMPROMISSOS, conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = contatos.Id;
                cmd.Parameters.Add("@id_contatos", MySqlDbType.Int32).Value = idContato;
                cmd.Parameters.Add("@titulo", MySqlDbType.VarChar, 45).Value = compromissos.Titulo;
                cmd.Parameters.Add("@descricao", MySqlDbType.VarChar, 255).Value = compromissos.Descricao;
                cmd.Parameters.Add("@dataini", MySqlDbType.DateTime).Value = compromissos.DataInicio;
                cmd.Parameters.Add("@datafim", MySqlDbType.DateTime).Value = compromissos.DataFim;

                cmd.ExecuteNonQuery();
                return (Int32)cmd.LastInsertedId;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro ao dar UPDATE compromissos MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private const string SQL_UPDATE_CONTATOS = @"UPDATE contatos
id,
nome,
telefone,
celular,
email,
rua,
numero,
bairro,
cidade,
uf,
status
SET
@id,
@nome,
@telefone,
@celular,
@email,
@rua,
@numero,
@bairro,
@cidade,
@uf,
'A' WHERE id = @id";
        private const string SQL_UPDATE_COMPROMISSOS = @"UPDATE compromissos
id_contatos,
titulo,
descricao,
dataini,
datafim,
status
SET
@id_contatos,
@titulo,
@descricao,
@dataini,
@datafim,
'A' WHERE id_contatos = @id";
    }
}
