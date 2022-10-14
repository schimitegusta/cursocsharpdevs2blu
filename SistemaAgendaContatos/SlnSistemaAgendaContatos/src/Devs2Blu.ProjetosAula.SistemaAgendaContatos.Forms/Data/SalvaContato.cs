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
    public class SalvaContato
    {
        public Contatos Save(Contatos contatos, Compromissos compromissos)
        {
            try
            {
                MySqlConnection conn = ConnectionMySQL.GetConnection();
                contatos.Id = SaveContato(contatos, conn);
                compromissos.Id = SaveCompromissos(compromissos, conn, contatos.Id);

                return contatos;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro ao SALVAR MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private Int32 SaveContato(Contatos contatos, MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_CONTATOS, conn);
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
                MessageBox.Show(myExc.Message, "Erro ao INSERIR contatos MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private Int32 SaveCompromissos(Compromissos compromissos, MySqlConnection conn, Int32 idContato)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_COMPROMISSOS, conn);
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
                MessageBox.Show(myExc.Message, "Erro ao INSERIR compromissos MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public MySqlDataReader GetGridContatos()
        {
            try
            {
                MySqlConnection conn = ConnectionMySQL.GetConnection();
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_ALL, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                return dataReader;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        #region SQLs
        private const string SQL_INSERT_CONTATOS = @"INSERT INTO contatos
(nome,
telefone,
celular,
email,
rua,
numero,
bairro,
cidade,
uf,
status)
VALUES
(@nome,
@telefone,
@celular,
@email,
@rua,
@numero,
@bairro,
@cidade,
@uf,
'A')";
        private const string SQL_INSERT_COMPROMISSOS = @"INSERT INTO compromissos
(id_contatos,
titulo,
descricao,
dataini,
datafim,
status)
VALUES
(@id_contatos,
@titulo,
@descricao,
@dataini,
@datafim,
'A')";
        private const string SQL_SELECT_ALL = @"SELECT c.ID,
c.Nome,
c.Telefone,
c.Celular,
c.Email,
c.Rua,
c.Numero,
c.Bairro,
c.Cidade,
c.UF,
com.Titulo,
com.Descricao,
com.dataini as Data_Inicio,
com.datafim as Data_Fim
FROM contatos c
INNER JOIN compromissos com ON c.id = com.id_contatos";
        #endregion
    }
}
