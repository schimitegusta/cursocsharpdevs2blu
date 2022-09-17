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
        public List<Diretor> DiretorList { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
