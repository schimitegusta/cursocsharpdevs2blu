using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Devs2Blu.ProjetosAula.OOP2Classes;

namespace Devs2Blu.ProjetosAula.AulaOOP2
{
    public partial class Form1 : Form
    {
        public Contato Contato { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        #region Eventos
        private void Form1_Load(object sender, EventArgs e)
        {
            Contato = new Contato();
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!ValidaForm())
            {
                MessageBox.Show(this, "Preencha todos os campos!", "Erro - Fomrulario de contato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BindClasse();

            String txttoMsg = $"{txtNome.Text}, enviado com sucesso!";
            MessageBox.Show(this, txttoMsg, "Formulario de contato");
            LimparForm();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparForm();
        }
        private void txtCEP_TextChanged(object sender, EventArgs e)
        {
            //89026720 (Length - 8)
            if(txtCEP.Text.Length == 8)
            {
                txtEstado.Text = "Santa Catarina";
                txtCidade.Text = "Blumenau";
                txtBairro.Text = "Centro";
                txtRua.Text = "7 de setembro, 56";
            } else
            {
                txtEstado.Clear();
                txtCidade.Clear();
                txtBairro.Clear();
                txtRua.Clear();
            }
        }
        #endregion

        #region Metodos
        public void BindClasse()
        {
            Contato.Nome = txtNome.Text;
            Contato.TelCel = txtTelCel.Text;
            Contato.Email = txtEmail.Text;
            Contato.CEP = txtCEP.Text;
            Contato.Estado = txtEstado.Text;
            Contato.Cidade = txtCidade.Text;
            Contato.Bairro = txtBairro.Text;
            Contato.Rua = txtRua.Text;
            Contato.Texto = txtTexto.Text;
        }
        private void LimparForm()
        {
            txtNome.Clear();
            txtTelCel.Clear();
            txtEmail.Clear();
            txtCEP.Clear();
            txtEstado.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            txtRua.Clear();
            txtTexto.Text = "Texto";
        }
        public bool ValidaForm()
        {
            if (txtNome.Text.Equals("")) return false;
            if (txtTelCel.Text.Equals("")) return false;
            if (txtEmail.Text.Equals("")) return false;
            if (txtCEP.Text.Equals("")) return false;
            if (txtEstado.Text.Equals("")) return false;
            if (txtCidade.Text.Equals("")) return false;
            if (txtBairro.Text.Equals("")) return false;
            if (txtRua.Text.Equals("")) return false;
            if (txtTexto.Text.Equals("")) return false;

            return true;
        }
        #endregion
    }
}
