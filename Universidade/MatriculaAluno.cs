using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade
{
    internal class MatriculaAluno
        
    {
        Aluno aluno = new Aluno();
        public List<Aluno> ListaAluno = new List<Aluno>();
       

        public void AdicionandoDadosAluno()
        {
            ListaAluno.Add(new Aluno 
            {
                nome = "Isabelle Resende",
                cpf = "123.456.789-00",
                endereco = "Rua A, 123",
                dataNascimento = new DateTime(2000, 1, 1),
                idade = (DateTime.Now.Year - new DateTime(2000, 1, 1).Year),
                curso = "Sistemas de Informação",
                periodo = 3
               
            }) ;
            

            ListaAluno.Add(new Aluno
            {
                nome = "Paulo Ricardo Faria",
                cpf = "987.654.321-00",
                endereco = "Avenida B, 456",
                dataNascimento = new DateTime(1999, 5, 10),
                idade = (DateTime.Now.Year - new DateTime(1999, 5, 10).Year),
                curso = "Educação Física",
                periodo = 1
            });

            ListaAluno.Add(new Aluno
            {
                nome = "Robinson Crusoé",
                cpf = "555.555.555-55",
                endereco = "Rua C, 789",
                dataNascimento = new DateTime(2002, 8, 15),
                idade = (DateTime.Now.Year - new DateTime(2002, 8, 15).Year), 
                curso = "Medicina",
                periodo = 2,
                
            });
            


        }

        public void ImprimirAlunos()
        {
            Console.WriteLine();
            Console.WriteLine("       ---  Lista de Alunos Cadastrados:  ---");
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
            }
        }

        
    }

}

       
   

