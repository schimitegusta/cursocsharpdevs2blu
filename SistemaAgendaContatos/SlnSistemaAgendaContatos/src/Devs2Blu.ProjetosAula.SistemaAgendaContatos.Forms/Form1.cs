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
        public AlteraContato AlteraContato = new AlteraContato();

        #region Events
        public void PopulaGridContatos()
        {
            var listContatos = SalvaContato.GetGridContatos();
            gridCompromissos.DataSource = new BindingSource(listContatos, null);
        }
        public void LimpaForms()
        {
            txtID.Text = "";
            txtNome.Text = "";

            mskTelefone.Text = "";
            mskTelefone.Mask = "0000-0000";

            mskCelular.Text = "";
            mskCelular.Mask = "00 00000-0000";

            txtEmail.Text = "";

            txtRua.Text = "";
            txtNumero.Text = "";
            cboUF.Text = "";
            txtCidade.Text = "";
            txtBairro.Text = "";

            txtTitulo.Text = "";
            txtDescricao.Text = "";
        }
        public bool ValidaForms()
        {
            if (txtNome.Text.Equals(""))
            {
                MessageBox.Show("Por Favor, Informe o Nome!");
                return false;
            }
            if (mskTelefone.Text.Equals(""))
            {
                MessageBox.Show("Por Favor, Informe o Telefone!");
                return false;
            }
            if (mskCelular.Text.Equals(""))
            {
                MessageBox.Show("Por Favor, Informe o Celular!");
                return false;
            }
            if (txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Por Favor, Informe o Email!");
                return false;
            }
            if (txtRua.Text.Equals(""))
            {
                MessageBox.Show("Por Favor, Informe a Rua!");
                return false;
            }
            if (txtNumero.Text.Equals(""))
            {
                MessageBox.Show("Por Favor, Informe o Numero!");
                return false;
            }
            if (cboUF.SelectedIndex == -1)
            {
                MessageBox.Show("Por Favor, Informe a UF!");
                return false;
            }
            if (txtCidade.Text.Equals(""))
            {
                MessageBox.Show("Por Favor, Informe a Cidade!");
                return false;
            }
            if (txtBairro.Text.Equals(""))
            {
                MessageBox.Show("Por Favor, Informe o Bairro!");
                return false;
            }
            if (txtTitulo.Text.Equals(""))
            {
                MessageBox.Show("Por Favor, Insira um Titulo!");
                return false;
            }
            if (txtDescricao.Text.Equals(""))
            {
                MessageBox.Show("Por Favor, Insira uma Descricao!");
                return false;
            }

            return true;
        }
        #endregion

        public Form1()
        {
            InitializeComponent();
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
        #region Methods
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaForms())
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

                if (txtID.Text == "")
                {
                    var salvando = SalvaContato.Save(contatos, compromissos);
                    LimpaForms();
                }
                else
                {
                    //contatos.Id = Int32.Parse(txtID.Text);
                    //var alterar = AlteraContato.Alterar(contatos, compromissos);
                    LimpaForms();
                }
            }
            PopulaGridContatos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaForms();
            PopulaGridContatos();
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

        #endregion

        private void gridCompromissos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow linha = gridCompromissos.Rows[e.RowIndex];

            txtID.Text = linha.Cells[0].Value.ToString();

            txtNome.Text = linha.Cells[1].Value.ToString();
            mskTelefone.Text = linha.Cells[2].Value.ToString();
            mskCelular.Text = linha.Cells[3].Value.ToString();
            txtEmail.Text = linha.Cells[4].Value.ToString();
            txtRua.Text = linha.Cells[5].Value.ToString();
            txtNumero.Text = linha.Cells[6].Value.ToString();
            txtBairro.Text = linha.Cells[7].Value.ToString();
            txtCidade.Text = linha.Cells[8].Value.ToString();
            cboUF.Text = linha.Cells[9].Value.ToString();

            txtTitulo.Text = linha.Cells[10].Value.ToString();
            txtDescricao.Text = linha.Cells[11].Value.ToString();
        }
    }
}
