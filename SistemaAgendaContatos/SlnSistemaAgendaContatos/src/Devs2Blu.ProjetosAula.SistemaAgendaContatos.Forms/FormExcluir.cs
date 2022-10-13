using Devs2Blu.ProjetosAula.SistemaAgendaContatos.Forms.Data;
using Devs2Blu.ProjetosAula.SistemaAgendaContatos.Models.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaAgendaContatos.Forms
{
    public partial class FormExcluir : Form
    {
        public ExcluiContato Excluir = new ExcluiContato();
        public FormExcluir()
        {
            InitializeComponent();
        }

        private void FormExcluir_Load(object sender, EventArgs e)
        {
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            Contatos contatos = new Contatos();

            contatos.Id = Int32.Parse(txtIdContato.Text);

            var excluirContato = Excluir.ExcluirContato(contatos);

            MessageBox.Show($"Contato, Compromisso excluidos com sucesso!", "Excluir contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
