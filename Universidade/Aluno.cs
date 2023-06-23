using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade
{
    internal class Aluno : Pessoa
    {
        public decimal notaProva1 { get; set; }
        public decimal notaProva2 { get; set; }
        public decimal notaProva3 { get; set; }

        MatriculaAluno matriculaAluno;
        List<Aluno> listaAluno;

        public void MenuAluno()
        {
            matriculaAluno = new MatriculaAluno();
            matriculaAluno.AdicionandoDadosAluno();
            listaAluno = matriculaAluno.ListaAluno;
            Console.WriteLine("Menu do Aluno");
            Console.WriteLine("1 - Visualizar dados");
            Console.WriteLine("2 - Consultar notas");
            Console.WriteLine("3 - Gerar Relatório");

            int opcaoAluno = int.Parse(Console.ReadLine());

            switch (opcaoAluno)
            {
                case 1:
                   
                    ImprimirDadosAluno(); 
                    break;
               
                case 2:
                   
                    ConsultarNotas(); 
                    break;

                case 3:
                    Console.WriteLine("Gerar Relatório");
                    GerarRelatorio(); 
                    break;
            }
        }

        public void ImprimirDadosAluno()
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Aluno aluno = listaAluno.FirstOrDefault(a => a.nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

                if (aluno != null)
                {
                    Console.WriteLine("Dados do Aluno:");
                    Console.WriteLine("Nome: " + aluno.nome);
                    Console.WriteLine("CPF: " + aluno.cpf);
                    Console.WriteLine("Endereço: " + aluno.endereco);
                    Console.WriteLine("Data de Nascimento: " + aluno.dataNascimento.ToShortDateString());
                    Console.WriteLine("Idade: " + aluno.idade);
                    Console.WriteLine("Curso: " + aluno.curso);
                    Console.WriteLine("Período: " + aluno.periodo);
                }
                else
                {
                    Console.WriteLine("Aluno não encontrado!");
                }
        }

        
            public void ConsultarNotas()
            
            {
                Console.Write("Digite seu nome: ");
                string nomeAluno = Console.ReadLine();

                // Busca o aluno na lista pelo nome
                Aluno aluno = listaAluno.FirstOrDefault(a => a.nome.Equals(nomeAluno, StringComparison.OrdinalIgnoreCase));

                if (aluno != null)
                {
                    Console.WriteLine("------- Notas do Aluno " + aluno.nome + " -------");
                    Console.WriteLine("Prova 1: " + aluno.notaProva1.ToString("F2"));
                    Console.WriteLine("Prova 2: " + aluno.notaProva2.ToString("F2"));
                    Console.WriteLine("Prova 3: " + aluno.notaProva3.ToString("F2"));
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Aluno não encontrado.");
                }
            }


        public void GerarRelatorio()
        {
           
            Console.WriteLine();
            
            Console.WriteLine();

            Console.Write("Digite seu nome: ");
            string nomeAluno = Console.ReadLine();

            // Busca o aluno na lista pelo nome
            Aluno aluno = listaAluno.FirstOrDefault(a => a.nome.Equals(nomeAluno, StringComparison.OrdinalIgnoreCase));

            if (aluno != null)
            {
                Console.WriteLine($"------- Relatório dos {aluno} -------");
                Console.WriteLine("ALUNO: " + aluno.nome);
                decimal somaNotas = aluno.notaProva1 + aluno.notaProva2 + aluno.notaProva3;
                Console.WriteLine("SOMA DAS NOTAS: " + somaNotas);
                decimal mediaNotas = somaNotas / 3;
                Console.WriteLine("MÉDIA: " + mediaNotas.ToString("F2"));

                if (somaNotas < 7)
                {
                    Console.WriteLine("SITUAÇÃO: REPROVADO");
                }
                else
                {
                    Console.WriteLine("SITUAÇÃO: APROVADO");
                }
            }
            else
            {
                Console.WriteLine("Aluno não encontrado.");
            }

            Console.WriteLine(); 
        }

        

    }
}

