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
                        matriculaProfessor.SolicitarDadosProfessor();
                        matriculaProfessor.ImprimirProfessores();
                        break;

                    case 3:
                        return; 
                        break;
                    case 'x':
                        break;

                }
            }

            
        }
    }
}


