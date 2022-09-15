using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula6.Jogo21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtConsole.Text += "\r\n Pressione \"Iniciar\" para começar!";
            txtConsole.Enabled = false;
        }
        private void btIniciar_Click(object sender, EventArgs e)
        {
            txtConsole.Text = "Primeira rodada!";
            txtConsole.Text = "Informe um número de 1 à 20:";
            btPlayer1.Enabled = true;
            txtPlayer1.Enabled = true;
            txtPlayer1.Focus();
        }
        private void btPlayer1_Click(object sender, EventArgs e)
        {
            txtConsole.Enabled = false;

            txtConsole.Text = "\r\nPlayer 1 escolheu seu numero...";

            string numPlayer1 = txtPlayer1.Text;

            int numPlayer1Validate = Convert.ToInt32(numPlayer1);

            if (numPlayer1Validate <= 0)
            {
                txtConsoleP1.Text = ("Valor informado invalido!!!");
                return;
            }
            else if (numPlayer1Validate > 20)
            {
                txtConsoleP1.Text = ("Valor acima do permitido!!!");
                return;
            }

            txtConsoleP1.Text = $"Numero escolhido: {numPlayer1}";

            Random rd = new Random();
            string numPlayer2 = rd.Next(1, 20).ToString();
            txtConsole.Text += "\r\nPlayer 2 escolheu seu numero...";

            txtConsoleP2.Text = $"Numero escolhido: {numPlayer2}";

            string numGerador = rd.Next(1, 20).ToString();
            txtConsole.Text += $"\r\nNumero gerado para rodada: {numGerador}";

            Int32.TryParse(numPlayer1, out int numP1);
            Int32.TryParse(numPlayer2, out int numP2);
            Int32.TryParse(numGerador, out int numGerado);

            int soma1 = numP1 + numGerado;
            int soma2 = numP2 + numGerado;

            string pontosP1 = "", pontosP2 = "";

            switch (soma1){
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    pontosP1 = "1";
                    break;
                case 7:
                    pontosP1 = "10";
                    break;
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                    pontosP1 = "5";
                    break;
                case 14:
                    pontosP1 = "20";
                    break;
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    pontosP1 = "6";
                    break;
                case 21:
                    pontosP1 = "30";
                    break;
                default:
                    pontosP1 = "0";
                    break;
            }

            switch (soma2){
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    pontosP2 = "1";
                    break;
                case 7:
                    pontosP2 = "10";
                    break;
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                    pontosP2 = "5";
                    break;
                case 14:
                    pontosP2 = "20";
                    break;
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    pontosP2 = "6";
                    break;
                case 21:
                    pontosP2 = "30";
                    break;
                default:
                    pontosP2 = "0";
                    break;
            }

            txtConsoleP1.Text += $"\r\nPontos P1: {pontosP1}";
            txtConsoleP2.Text += $"\r\nPontos P2: {pontosP2}";

            Int32.TryParse(pontosP1, out soma1);
            Int32.TryParse(pontosP2, out soma2);

            if (soma1 > soma2)
            {
                txtConsoleP1.Text += $"\r\nJOGADOR 1 VENCEU A RODADA!";
                txtConsoleP2.Text += $"\r\nJOGADOR 1 VENCEU A RODADA!";
                txtConsole.Text += "\r\nJOGADOR 1 VENCEU A RODADA!";
            } else if (soma2 > soma1)
            {
                txtConsoleP1.Text += $"\r\nJOGADOR 2 VENCEU A RODADA!";
                txtConsoleP2.Text += $"\r\nJOGADOR 2 VENCEU A RODADA!";
                txtConsole.Text += "\r\nJOGADOR 2 VENCEU A RODADA!";
            } else
            {
                txtConsole.Text += "\r\nEMPATE";
                txtConsoleP1.Text += "\r\nEMPATE";
                txtConsoleP2.Text += "\r\nEMPATE";
            }

            btPlayer1.Enabled = false;
            txtPlayer1.Enabled = false;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtConsole.Text = "";
            txtConsoleP1.Text = "";
            txtConsoleP2.Text = "";
            txtPlayer1.Text = "";
            txtPlayer2.Text = "";
            btPlayer1.Enabled = false;
            txtPlayer1.Enabled = false;
        }
    }
}
