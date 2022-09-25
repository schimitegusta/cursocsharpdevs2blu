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
        }
        public void CargaMock()
        {
            CargaPacientes();
            CargaMedicos();
            CargaRecepcionistas();
            CargaFornecedores();
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
            for (int i = 0; i < 5; i++)
            {
                //Int32 codigo, String nome, String cpf, Int32 crm, String especialidade
                Medico medico = new Medico(i, $"Medico {i + 1}", $"{i}32{i}65{i}198{i}", rd.Next(1, 999), "Oftamologia");
                ListaMedicos.Add(medico);
            }
        }
        public void CargaRecepcionistas()
        {
            for (int i = 0; i < 5; i++)
            {
                //Int32 codigo, String nome, String cpf, String setor
                Recepcionista recepcionista = new Recepcionista(i, $"Recepcionista {i+1}", $"{i}11{i}11{i}111{i}", "Agendamento");
                ListaRecepcionistas.Add(recepcionista);
            }
        }
        public void CargaFornecedores()
        {
            for (int i = 0; i < 5; i++)
            {
                //(Int32 codigo, String nome, String cpf, String tipoFornecedor)
                Fornecedor fornecedor = new Fornecedor(i, $"Fornecedor: {i+1}", $"{i}22{i}22{i}222{i}", "Reabastecimento");
                ListaFornecedores.Add(fornecedor);
            }
        }
    }
}
