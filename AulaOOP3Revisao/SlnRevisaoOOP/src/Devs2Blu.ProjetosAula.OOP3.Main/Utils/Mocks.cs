using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Utils
{
    public class Mocks
    {
        public List<Paciente> ListaPacientes { get; set; }
        public List<Medico> ListaMedicos { get; set; }
        public List<Recepcionista> ListaRecepcionistas { get; set; }
        public List<Fornecedor> ListaFornecedores { get; set; }
        public Mocks()
        {
            ListaPacientes = new List<Paciente>();
            ListaMedicos = new List<Medico>();
            ListaRecepcionistas = new List<Recepcionista>();
            ListaFornecedores = new List<Fornecedor>();

            CargaMock();
            CargaMedicos();
        }
        public void CargaMock()
        {
            CargaPacientes();
        }

        public void CargaPacientes()
        {
            for (int i = 0; i < 10; i++)
            {
                //o "paciente" e a variavel que representa a classe
                Paciente paciente = new Paciente(i, $"Paciente {i+1}", $"{i}23{i}56{i}891{i}", "Unimed");
                ListaPacientes.Add(paciente);
            }
        }

        public void CargaMedicos()
        {
            Random rd = new Random();
            for (int i = 0; i < 10; i++)
            {
                //Int32 codigo, String nome, String cpf, Int32 crm, String especialidade
                Medico medico = new Medico(i, $"Medico {i + 1}", $"{i}32{i}65{i}198{i}", (rd.Next(1, 999)), "Oftamologia");
                ListaMedicos.Add(medico);
            }
        }
    }
}
