using Correios.CorreiosServiceReference;
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
    public class ExcluiContato
    {
        public ExcluiContato excluir { get; set; }

        public ExcluiContato ExcluirContato(Contatos contatos)
        {
            try
            {
                MySqlConnection conn = ConnectionMySQL.GetConnection();

                MySqlCommand cmdCompromissos = new MySqlCommand(SQL_DELETE_COMPROMISSOS, conn);
                cmdCompromissos.Parameters.Add("@id", MySqlDbType.Int32).Value = contatos.Id;
                cmdCompromissos.ExecuteNonQuery();

                MySqlCommand cmdContatos = new MySqlCommand(SQL_DELETE_CONTATOS, conn);
                cmdContatos.Parameters.Add("@id", MySqlDbType.Int32).Value = contatos.Id;
                cmdContatos.ExecuteNonQuery();

                return excluir;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        #region SQLs
        private const string SQL_DELETE_COMPROMISSOS = @"DELETE FROM compromissos WHERE id_contatos = @id";
        private const string SQL_DELETE_CONTATOS = @"DELETE FROM contatos WHERE id = @id";
        #endregion
    }
}
