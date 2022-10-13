using Correios;
using Devs2Blu.ProjetosAula.SistemaAgendaContatos.Forms.Data;
using Devs2Blu.ProjetosAula.SistemaAgendaContatos.Models.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaAgendaContatos.Forms
{
    public partial class Form1 : Form
    {
        public MySqlConnection Conn { get; set; }
        public SalvaContato SalvaContato = new SalvaContato();
        public Form1()
        {
            InitializeComponent();
        }
        public void PopulaGridContatos()
        {
            var listContatos = SalvaContato.GetGridContatos();
            gridCompromissos.DataSource = new BindingSource(listContatos, null);
        }
        public void LimpaForms()
        {
            txtNome.Text = "";

            mskTelefone.Text = "";
            mskTelefone.Mask = "0000-0000";

            mskCelular.Text = "";
            mskCelular.Mask = "00 00000-0000";

            txtEmail.Text = "";

            mskCEP.Text = "";
            mskCEP.Mask = "00.000-000";

            txtRua.Text = "";
            txtNumero.Text = "";
            cboUF.Text = "";
            txtCidade.Text = "";
            txtBairro.Text = "";

            txtTitulo.Text = "";
            txtDescricao.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            #region TesteConexao
            /*Conn = ConnectionMySQL.GetConnection();

            if (Conn.State == ConnectionState.Open)
            {
                MessageBox.Show("Conexão efetuada com sucesso!", "Conexão ao MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Conn.Close();
            }*/
            #endregion
            LimpaForms();
            PopulaGridContatos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Contatos contatos = new Contatos();
            contatos.Nome = txtNome.Text;
            contatos.Telefone = mskTelefone.Text;
            contatos.Celular = mskCelular.Text;
            contatos.Email = txtEmail.Text;
            contatos.Rua = txtRua.Text;
            contatos.Numero = Int32.Parse(txtNumero.Text);
            contatos.UF = cboUF.Text;
            contatos.Cidade = txtCidade.Text;
            contatos.Bairro = txtBairro.Text;

            Compromissos compromissos = new Compromissos();
            compromissos.Titulo = txtTitulo.Text;
            compromissos.Descricao = txtDescricao.Text;
            compromissos.DataInicio = dtpInicio.Value;
            compromissos.DataFim = dtpFim.Value;

            var salvando = SalvaContato.Save(contatos, compromissos);
            PopulaGridContatos();
            LimpaForms();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaForms();
            PopulaGridContatos();
        }

        private void mskCEP_TextChanged(object sender, EventArgs e)
        {
            if (mskCEP.Text.Length == 10)
            {
                try
                {
                    CorreiosApi correiosApi = new CorreiosApi();
                    var retorno = correiosApi.consultaCEP(mskCEP.Text);
                    txtBairro.Text = retorno.bairro;
                    txtCidade.Text = retorno.cidade;
                    txtRua.Text = retorno.end;
                    cboUF.Text = retorno.uf;
                }
                catch (Exception erro)
                {
                    MessageBox.Show("CEP não encontrado!", erro.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskCEP.Text = "";
                    mskCEP.Focus();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            FormExcluir formExcluir = new FormExcluir();
            formExcluir.Show();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            PopulaGridContatos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Contatos contatos = new Contatos();
            contatos.Id = Int32.Parse(txtIdBuscar.Text);
        }
    }
}
