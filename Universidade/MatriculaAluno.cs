using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade
{
    internal class MatriculaAluno
        // FALTOU O Nº DA MATRICULA
    {
        Aluno aluno = new Aluno();
        public List<Aluno> ListaAluno = new List<Aluno>();

        public void CadastrarAluno(Aluno aluno)
        {
            ListaAluno.Add(aluno);

        }

        public void AdicionandoDadosAluno()
        {

            ListaAluno.Add(new Aluno
            {
                nome = "João da Silva",
                cpf = "123.456.789-00",
                endereco = "Rua A, 123",
                dataNascimento = new DateTime(2000, 1, 1),
                idade = (DateTime.Now.Year - new DateTime(2000, 1, 1).Year),
                curso = "Engenharia",
                periodo = 4
               
            }) ;
            

            ListaAluno.Add(new Aluno
            {
                nome = "Maria Oliveira",
                cpf = "987.654.321-00",
                endereco = "Avenida B, 456",
                dataNascimento = new DateTime(1999, 5, 10),
                idade = (DateTime.Now.Year - new DateTime(1999, 5, 10).Year),
                curso = "Administração",
                periodo = 6
            });

            ListaAluno.Add(new Aluno
            {
                nome = "Pedro Santos",
                cpf = "555.555.555-55",
                endereco = "Rua C, 789",
                dataNascimento = new DateTime(2002, 8, 15),
                idade = (DateTime.Now.Year - new DateTime(2002, 8, 15).Year), // Cálculo da idade com base na data de nascimento
                curso = "Medicina",
                periodo = 2,
                
            });
            


        }

        public void ImprimirAlunos()
        {
            Console.WriteLine();
            Console.WriteLine("---  Lista de Alunos Cadastrados:  ---");
            foreach (var item in ListaAluno)
            {
                Console.WriteLine($"Nome: {item.nome}");
                Console.WriteLine($"CPF: {item.cpf}");
                Console.WriteLine($"Endereço: {item.endereco}");
                Console.WriteLine($"Data de Nascimento: {item.dataNascimento}");
                Console.WriteLine($"Idade: {item.idade}");
                Console.WriteLine($"Curso: {item.curso}");
                Console.WriteLine($"Período: {item.periodo}º");

                Console.WriteLine();
                ImprimirAlunos();
            }
        }

        //int novaInscricao = 1;
        //do
        //{

        //    Aluno aluno = new Aluno();
        //    Console.Write("Digite seu nome: ");
        //    aluno.nome = Console.ReadLine();

        //    Console.Write("Digite seu CPF: ");
        //    aluno.cpf = Console.ReadLine();

        //    Console.Write("Digite seu endereço: ");
        //    aluno.endereco = Console.ReadLine();

        //    DateTime data;
        //    bool dataValida = false;

        //    while (!dataValida)
        //    {
        //        Console.Write("Digite sua data de nascimento no formato dd/mm/aaaa: ");
        //        string inputData = Console.ReadLine();

        //        if (DateTime.TryParseExact(inputData, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out data))
        //        {

        //            dataValida = true;

        //            DateTime dataAtual = DateTime.Now;
        //            int idade = dataAtual.Year - data.Year;

        //            if (dataAtual.Month < data.Month || (dataAtual.Month == data.Month && dataAtual.Day < data.Day))
        //            {
        //                idade--;
        //                aluno.idade = idade;
        //            }

        //            Console.WriteLine("Sua idade: " + idade);
        //        }
        //        else
        //        {
        //            Console.WriteLine("Data inválida! Tente novamente.");
        //        }
        //    }

        //    Console.Write("Informe seu curso: ");
        //    aluno.curso = Console.ReadLine();

        //    Console.Write("Informe qual é o seu período: ");
        //    aluno.periodo = int.Parse(Console.ReadLine());

        //    CadastrarAluno(aluno);
        //    Console.WriteLine("Inscrição feita com sucesso!");
        //    Console.WriteLine("Nova inscrição?");
        //    Console.WriteLine("1 - Sim");
        //    Console.WriteLine("2 - Não");
        //    novaInscricao = int.Parse(Console.ReadLine());
        //} while (novaInscricao == 1);
    }

}

       
   

