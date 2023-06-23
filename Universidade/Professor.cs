using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade
{
    public class Professor : Pessoa
    {

        private List<Aluno> listaAluno;
        private Prova prova;

        public void MenuProfessor()
        {
            MenuPrincipal menuPrincipal= new MenuPrincipal();
            MatriculaAluno matriculaAluno = new MatriculaAluno();
           matriculaAluno.AdicionandoDadosAluno();
            listaAluno = matriculaAluno.ListaAluno;
            prova = new Prova(listaAluno);

            int opcaoProfessor;
            bool sair = false; 

            while (!sair)
            {
                Console.WriteLine("Menu do Professor");
                Console.WriteLine("1 - Lançar Notas");
                Console.WriteLine("2 - Consultar Notas");
                Console.WriteLine("3 - Gerar Relatório");
                Console.WriteLine("4 - Sair");
                Console.WriteLine("5 - Retornar ao Menu Principal");

                opcaoProfessor = int.Parse(Console.ReadLine());

                switch (opcaoProfessor)
                {
                    case 1:
                        prova.LancarNotas();
                        break;

                    case 2:
                        prova.ImprimirNotas();
                        break;

                    case 3:
                       
                        prova.GerarRelatorio();
                        break;

                    case 4:
                        Console.WriteLine("Saindo do Menu do Professor");
                        sair = true; 
                        break;

                    case 5:

                        menuPrincipal.Menu();
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}

