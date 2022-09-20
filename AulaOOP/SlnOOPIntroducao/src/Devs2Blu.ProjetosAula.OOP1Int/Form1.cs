using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Devs2Blu.ProjetosAula.Classes;

namespace Devs2Blu.ProjetosAula.OOP1Int
{
    public partial class Form1 : Form
    {
        public List<Recepcionista> RecepcionistasList { get; set; }
        public List<Diretor> DiretorsList { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RecepcionistasList = new List<Recepcionista>();
            DiretorsList = new List<Diretor>();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (rbDiretor.Checked)
            {
                Diretor diretor = new Diretor(txtNome.Text, txtSobreNome.Text, 5000.00);
                //diretor.Nome = txtNome.Text;
                //diretor.SobreNome = txtSobreNome.Text;;
                SalvarDiretor(diretor);
            }
            else if (rbRecepcionista.Checked)
            {
                Recepcionista recepcionista = new Recepcionista(txtNome.Text, txtSobreNome.Text);
                SalvarRecepcionista(recepcionista);
            }
            LimparFormulario();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        #region Metodos
        private void SalvarRecepcionista(Recepcionista recepcionista)
        {
            RecepcionistasList.Add(recepcionista);
        }

        private void SalvarDiretor(Diretor diretor)
        {
            DiretorsList.Add(diretor);
        }

        private void LimparFormulario()
        {
            txtNome.Text = "";
            txtSobreNome.Text = "";

        }
        #endregion
    }
}
