using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade
{
    internal class Aluno : Pessoa
    {
        public float notaProva1 { get; set; }
        public float notaProva2 { get; set; }
        public float notaProva3 { get; set; }

        public void MenuAluno()
        {
            Console.WriteLine("Menu do Aluno");
            Console.WriteLine("1 - Consultar notas");

            int opcaoAluno = int.Parse(Console.ReadLine());

            switch (opcaoAluno)
            {
                case 1:
                    Console.WriteLine("Lançar Notas");
                    break;
                case 2:
                    Console.WriteLine("Consultar notas");
                    break;
                case 3:
                    Console.WriteLine("Gerar Relatório");
                    break;
            }
        }
    }
}

