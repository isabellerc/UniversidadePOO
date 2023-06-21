using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade
{
    internal class Professor : Pessoa
    {
        Prova prova = new Prova();
        public void MenuProfessor()
        {
            Console.WriteLine("Menu do Professor");
            Console.WriteLine("1 - Lançar Provas");
            Console.WriteLine("2 - Lançar Notas");
            Console.WriteLine("3 - Consultar Notas");
            Console.WriteLine("4 - Gerar Relatório");
            int opcaoProfessor = int.Parse(Console.ReadLine());

            switch (opcaoProfessor)
            {
                case 1:
                    Console.WriteLine("Lançar Prova");
                    prova.CadastrarProva();
                    break;
                case 2:
                    Console.WriteLine("Lançar Notas");
                    prova.LancarNotas();
                    break;
                case 3:
                    Console.WriteLine("Consultar Notas");
                    break;
                case 4:
                    Console.WriteLine("Gerar Relatório");
                    break;
            }
        }

    }
}
