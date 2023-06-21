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
            Professor professor = new Professor();
            Console.Write("Digite seu nome: ");
            professor.nome = Console.ReadLine();

            Console.Write("Digite seu CPF: ");
            professor.cpf = Console.ReadLine();

            Console.Write("Digite seu endereço: ");
            professor.endereco = Console.ReadLine();

            DateTime data;
            bool dataValida = false;

            while (!dataValida)
            {
                Console.Write("Digite sua data de nascimento no formato dd/mm/aaaa: ");
                string inputData = Console.ReadLine();

                if (DateTime.TryParseExact(inputData, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out data))
                {

                    dataValida = true;

                    DateTime dataAtual = DateTime.Now;
                    int idade = dataAtual.Year - data.Year;

                    if (dataAtual.Month < data.Month || (dataAtual.Month == data.Month && dataAtual.Day < data.Day))
                    {
                        idade--;
                        professor.idade = idade;
                    }

                    Console.WriteLine("Sua idade: " + idade);
                }
                else
                {
                    Console.WriteLine("Data inválida! Tente novamente.");
                }
            }

            Console.Write("Informe seu curso: ");
            professor.curso = Console.ReadLine();

            Console.Write("Informe qual é o seu período: ");
            professor.periodo = int.Parse(Console.ReadLine());

            CadastrarProfessor(professor);
        }
        public void ImprimirProfessores()
        {
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
