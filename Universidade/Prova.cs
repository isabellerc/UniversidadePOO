using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Universidade;

namespace Universidade
{


    internal class Prova
    {



        public decimal notaProva1 { get; set; }
        public decimal notaProva2 { get; set; }
        public decimal notaProva3 { get; set; }




        private List<Aluno> listaAluno;

        public Prova(List<Aluno> listaAluno)
        {
            this.listaAluno = listaAluno;
        }

        public void LancarNotas()
        {
            foreach (var aluno in listaAluno)
            {
                Console.WriteLine("Digite as notas para o aluno " + aluno.nome);

                Console.Write("Prova 1: ");
                aluno.notaProva1 = decimal.Parse(Console.ReadLine());

                Console.Write("Prova 2: ");
                aluno.notaProva2 = decimal.Parse(Console.ReadLine());

                Console.Write("Prova 3: ");
                aluno.notaProva3 = decimal.Parse(Console.ReadLine());

                Console.WriteLine();
            }
        }

        public void ImprimirNotas()
        {
            foreach (var aluno in listaAluno)
            {
                Console.WriteLine("               ------- Notas do Aluno " + aluno.nome + " -------");
                Console.WriteLine("Prova 1: " + aluno.notaProva1);
                Console.WriteLine("Prova 2: " + aluno.notaProva2);
                Console.WriteLine("Prova 3: " + aluno.notaProva3);
                Console.WriteLine();
            }
        }

        public void GerarRelatorio()
        {
            Console.WriteLine();
            Console.WriteLine("------- Relatório dos Alunos -------");
            Console.WriteLine();

            Console.Write("Digite o nome do aluno: ");
            string nomeAluno = Console.ReadLine();

            
            Aluno aluno = listaAluno.FirstOrDefault(a => a.nome.Equals(nomeAluno, StringComparison.OrdinalIgnoreCase));

            if (aluno != null)
            {
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





