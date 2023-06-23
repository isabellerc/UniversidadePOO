using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade
{
    internal class MatriculaProfessor
    {

        List<Professor> ListaProfessor = new List<Professor>();

        public void CadastrarProfessor(Professor professor)
        {
            ListaProfessor.Add(professor);

        }

        public void SolicitarDadosProfessor()
        {
            ListaProfessor.Add(new Professor
            {
                nome = "Ana Souza",
                cpf = "111.222.333-44",
                endereco = "Rua D, 567",
                dataNascimento = new DateTime(2001, 3, 20),
                idade = (DateTime.Now.Year - new DateTime(2001, 3, 20).Year),
                curso = "Psicologia",
                periodo = 3
            });

            ListaProfessor.Add(new Professor
            {
                nome = "Lucas Santos",
                cpf = "555.444.333-22",
                endereco = "Avenida E, 789",
                dataNascimento = new DateTime(1998, 9, 8),
                idade = (DateTime.Now.Year - new DateTime(1998, 9, 8).Year),
                curso = "Arquitetura",
                periodo = 5
            });

            ListaProfessor.Add(new Professor
            {
                nome = "Camila Lima",
                cpf = "999.888.777-66",
                endereco = "Rua F, 321",
                dataNascimento = new DateTime(2003, 7, 12),
                idade = (DateTime.Now.Year - new DateTime(2003, 7, 12).Year),
                curso = "Letras",
                periodo = 2
            });
        }
        public void ImprimirProfessores()
        {
            Console.WriteLine("       ---  Lista de Professores Cadastrados --- ");
            foreach (var item in ListaProfessor)
            {
                Console.WriteLine($"Nome: {item.nome}");
                Console.WriteLine($"CPF: {item.cpf}");
                Console.WriteLine($"Endereço: {item.endereco}");
                Console.WriteLine($"Data de Nascimento: {item.dataNascimento}");
                Console.WriteLine($"Idade: {item.idade}");
                Console.WriteLine($"Curso: {item.curso}");
                Console.WriteLine($"Período: {item.periodo}º");

                Console.WriteLine();
            }
        }

    }
}
