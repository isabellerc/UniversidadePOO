using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade
{

    public class Administrador
    {
        MatriculaAluno matriculaAluno = new MatriculaAluno();
        MatriculaProfessor matriculaProfessor = new MatriculaProfessor();

        public void MenuAdministrador()
        {
            while (true)
            {
                Console.WriteLine("MENU ADMINISTRADOR:");
                
                Console.WriteLine("1 - Imprimir lista de Alunos");
                Console.WriteLine("2 - Imprimir lista de Professores");
                Console.WriteLine("3 - Voltar para o Menu Principal");
                Console.WriteLine("x - Sair");

                int opcaoPessoa = int.Parse(Console.ReadLine());
                switch (opcaoPessoa)
                {
                    case 1:
                        matriculaAluno.AdicionandoDadosAluno();
                        matriculaAluno.ImprimirAlunos();
                        break;

                    case 2:
                        matriculaProfessor.ImprimirProfessores();
                        break;

                    case 3:
                        return; // Retorna ao menu principal
                        break;
                    case 'x':
                        break;

                }
            }

            //    int opcaoPessoa = 1;
            //    do
            //    {
            //        Console.WriteLine("MENU ADMINISTRADOR:");
            //        Console.WriteLine("1 - Novo Cadastro de Aluno:");
            //        Console.WriteLine("2 - Novo Cadastro de Professor");
            //        Console.WriteLine("3 - Imprimir lista de Alunos");
            //        Console.WriteLine("4 - Imprimir lista de Professores");
            //        Console.WriteLine("5 - Voltar para o Menu Principal");
            //        Console.WriteLine("0 - Sair");

            //        opcaoPessoa = int.Parse(Console.ReadLine());
            //        switch (opcaoPessoa)
            //        {
            //            case 1:
            //                matriculaAluno.SolicitarDadosAluno();
            //                break;

            //            case 2:
            //                matriculaProfessor.SolicitarDadosProfessor();
            //                break;

            //            case 3:
            //                matriculaAluno.ImprimirAlunos();
            //                break;

            //            case 4:
            //                matriculaProfessor.ImprimirProfessores();
            //                break;

            //            case 5:
            //                return; // Retorna ao menu principal sem chamar recursivamente

            //        } 
            //    } while (opcaoPessoa != 0);
            //}
        }
    }
}


